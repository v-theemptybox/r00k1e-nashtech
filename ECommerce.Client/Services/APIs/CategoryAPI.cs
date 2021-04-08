using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ECommerce.Client.Services.Interfaces;
using ECommerce.Shared;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Client.Services.APIs
{
    public class CategoryAPI : ICategoryAPI
    {
        private readonly IHttpClientFactory _client;
        private readonly IConfiguration _configuration;

        public CategoryAPI(IHttpClientFactory client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<IList<CategoryVm>> GetCategories()
        {
            var client = _client.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/categories/");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<CategoryVm>>();
        }
        public async Task<CategoryVm> GetCategory(int id)
        {
            var client = _client.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/categories/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CategoryVm>();
        }
    }
}