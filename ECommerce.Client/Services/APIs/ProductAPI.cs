using ECommerce.Client.Services.Interfaces;
using ECommerce.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace ECommerce.Client.Services.APIs
{
    public class ProductAPI : IProductAPI
    {
        private readonly IHttpClientFactory _client;

        public ProductAPI(IHttpClientFactory client)
        {
            _client = client;
        }

        public async Task<IList<ProductVm>> GetProducts()
        {
            //var response = await _client.GetAsync("api/products");

            //response.EnsureSuccessStatusCode();

            //return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();

            var client = _client.CreateClient();
            var response = await client.GetAsync("https://localhost:44318/api/products");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();
        }
    }
}
