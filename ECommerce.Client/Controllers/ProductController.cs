using ECommerce.Client.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductAPI _productApiClient;

        public ProductController(IProductAPI productApiClient)
        {
            _productApiClient = productApiClient;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var products = await _productApiClient.GetProducts();
            return View(products);
        }
    }
}
