using ECommerce.Backend.Controllers;
using ECommerce.Backend.Data;
using ECommerce.Backend.Models;
using ECommerce.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTest
{
    public class CategoriesControllerTest
    {
        private ApplicationDbContext _dbContext;
        private SqliteConnection _connection;

        public CategoriesControllerTest()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(_connection)
                .Options;
            _dbContext = new ApplicationDbContext(options);
            _dbContext.Database.EnsureCreated();
        }
        

        [Fact]
        public async Task ValidatePostCategory()
        {
            var category = new CategoryCreateRequest()
            {
                CategoryName = "Stadia",
                Description = "..."
            };

            var controller = new CategoriesController(_dbContext);
            var result = await controller.PostCategory(category);
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnValue = Assert.IsType<CategoryVm>(createdAtActionResult.Value);
            Assert.Equal("Stadia", returnValue.CategoryName);
            Assert.Equal("...", returnValue.Description);
        }

        [Fact]
        public async Task ValidateGetCategories()
        {
            _dbContext.Categories.Add(new Category
            {
                CategoryName = "Stadia",
                Description = "..."
            });
            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.GetCategorys();
            var actionResult = Assert.IsType<ActionResult<IEnumerable<CategoryVm>>>(result);
            
            Assert.NotEmpty(actionResult.Value);
        }
        [Fact]
        public async Task ValidateGetCategoryById()
        {
            _dbContext.Categories.Add(new Category
            {
                CategoryId = 222,
                CategoryName = "Stadia",
                Description = "..."
            });
            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.GetCategory(222);
            var actionResult = Assert.IsType<ActionResult<CategoryVm>>(result);

            Assert.NotNull(actionResult);
            Assert.NotNull(result);
            Assert.Equal("Stadia", result.Value.CategoryName);
            Assert.Equal("...", result.Value.Description);
        }
        [Fact]
        public async Task ValidateDeleteCategoryById()
        {
            _dbContext.Categories.Add(new Category
            {
                CategoryId = 222,
                CategoryName = "Stadia",
                Description = "..."
            });
            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.DeleteCategory(222);
            var actionResult = Assert.IsType<OkResult>(result);

            Assert.NotNull(result);
            Assert.NotNull(actionResult);
            
            
        }


    }
}
