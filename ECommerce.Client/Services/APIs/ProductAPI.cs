using ECommerce.Client.Services.Interfaces;
using ECommerce.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Client.Services.APIs
{
    public class ProductAPI : IProductAPI
    {
        private readonly IHttpClientFactory _client;
        private readonly IConfiguration _configuration;

        public ProductAPI(IHttpClientFactory client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<IList<ProductVm>> GetProducts()
        {
            var client = _client.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/products");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();
        }
        public async Task<ProductVm> GetProduct(int id)
        {
            var client = _client.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/products/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductVm>();
        }

        public async Task<IList<ProductVm>> GetProductByCategory(int idCate)
        {
            var client = _client.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/products/GetByCategory/" + idCate);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();
        }
    }
}
