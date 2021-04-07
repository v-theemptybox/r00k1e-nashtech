using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ECommerce.Client.Services.Interfaces;
using ECommerce.Shared;
using System.Net.Http.Json;

namespace ECommerce.Client.Services.APIs
{
    public class CategoryAPI : ICategoryAPI
    {
        private readonly IHttpClientFactory _client;

        public CategoryAPI(IHttpClientFactory client)
        {
            _client = client;
        }

        public async Task<IList<CategoryVm>> GetCategories()
        {
            var client = _client.CreateClient();
            var response = await client.GetAsync("https://localhost:44318/api/products");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<CategoryVm>>();
        }
    }
}