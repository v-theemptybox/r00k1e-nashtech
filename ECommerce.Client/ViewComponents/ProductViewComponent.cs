using ECommerce.Client.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Client.Components
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductAPI _productApiClient;

        public ProductViewComponent(IProductAPI productApiClient)
        {
            _productApiClient = productApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productApiClient.GetProducts();
            return View(products);
        }
    }
}
