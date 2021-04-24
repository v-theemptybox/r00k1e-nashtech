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
    public class BrandControllerTest 
    {
        private ApplicationDbContext _dbContext;
        private SqliteConnection _connection;

        public BrandControllerTest()
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
        public async Task ValidatePostBrand()
        {
            var brand = new BrandCreateRequest()
            {
                Name = "GOG.com"
            };

            var controller = new BrandsController(_dbContext);
            var result = await controller.PostBrand(brand);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnValue = Assert.IsType<BrandVm>(createdAtActionResult.Value);
            Assert.Equal("GOG.com", returnValue.Name);
        }

        [Fact]
        public async Task ValidateGetBrandById()
        {
            _dbContext.Brands.Add(new Brand
            {
                Id = 99,
                Name = "GOG.com"
            });
            var controller = new BrandsController(_dbContext);
            var result = await controller.GetBrand(99);
            var actionResult = Assert.IsType<ActionResult<BrandVm>>(result);

            Assert.NotNull(result);
            Assert.NotNull(actionResult);
            Assert.Equal("GOG.com", result.Value.Name);
            Assert.True(99 == result.Value.Id);
        }

        [Fact]
        public async Task ValidateDeleteBrand()
        {
            _dbContext.Brands.Add(new Brand
            {
                Id = 99,
                Name = "GOG.com"
            });

            var controller = new BrandsController(_dbContext);
            var result = await controller.DeleteBrand(99);
            var actionResult = Assert.IsType<NoContentResult>(result);
            
            Assert.NotNull(result);
            Assert.NotNull(actionResult);
        }
        [Fact]
        public async Task ValidateGetBrands()
        {
            _dbContext.Brands.Add(new Brand
            {
                Id = 99,
                Name = "GOG.com"
            });
            await _dbContext.SaveChangesAsync();

            var controller = new BrandsController(_dbContext);
            var result = await controller.GetBrands();
            var actionResult = Assert.IsType<ActionResult<IEnumerable<BrandVm>>>(result);

            Assert.NotEmpty(actionResult.Value);
        }


    }
}
