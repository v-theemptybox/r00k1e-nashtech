using ECommerce.Client.Models;
using ECommerce.Client.Services.Interfaces;
using ECommerce.Client.Models;
using ECommerce.Client.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IProductAPI _productAPI;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IProductAPI productAPI)
        {
            _logger = logger;
            _configuration = configuration;
            _productAPI = productAPI;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productAPI.GetProducts();
            //Set url backend for image
            foreach (var x in products)
            {
                //for (int i = 0; i < x.Images.Count(); i++)
                //{
                    x.Images = _configuration["BackendUrl:Default"] + x.Images;
                //    x.Images[i] = setUrl;
                //}
            }
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
