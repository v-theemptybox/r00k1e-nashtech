using ECommerce.Client.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.Client.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryAPI _categoryApiClient;

        public CategoryViewComponent(ICategoryAPI categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryApiClient.GetCategories();
            return View(categories);
        }
    }
}
