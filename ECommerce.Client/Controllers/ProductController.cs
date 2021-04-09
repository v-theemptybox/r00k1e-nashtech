using ECommerce.Client.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductAPI _productApiClient;
        private readonly IConfiguration _configuration;

        public ProductController(IProductAPI productApiClient, IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var products = await _productApiClient.GetProducts();

            foreach (var x in products)
            {
                //for (int i = 0; i < x.ImageLocation.Count; i++)
                //{
                    x.Images = _configuration["BackendUrl:Default"] + x.Images;
                //    x.ImageLocation[i] = setUrl;
                //}
            }
            return View(products);
        }

        public async Task<IActionResult> GetProductByCategory(int idCate)
        {
            var products = await _productApiClient.GetProductByCategory(idCate);

            foreach (var x in products)
            {
                //for (int i = 0; i < x.ImageLocation.Count; i++)
                //{
                    x.Images = _configuration["BackendUrl:Default"] + x.Images;
                //    x.ImageLocation[i] = setUrl;
                //}
            }
            return View(products);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var product = await _productApiClient.GetProduct(id);

            //foreach (var x in product)
            //{
            //    //for (int i = 0; i < x.ImageLocation.Count; i++)
            //    //{
                product.Images = _configuration["BackendUrl:Default"] + product.Images;
            //    //    x.ImageLocation[i] = setUrl;
            //    //}
            //}
            return View(product);
        }
    }
}
