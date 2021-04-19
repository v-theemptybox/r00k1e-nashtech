using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ECommerce.Backend.Data;
using ECommerce.Backend.Models;
using ECommerce.Backend.Services;
using ECommerce.Shared;

namespace ECommerce.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IStorageService _storageService;
        private readonly ILogger _logger;
        private static readonly ActivitySource DemoSource = new ActivitySource("OTel.Demo");

        public ProductsController(ApplicationDbContext context, IStorageService storageService, ILogger<ProductsController> logger)
        {
            _context = context;
            _storageService = storageService;
            _logger = logger;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductVm>> GetProduct(int id)
        {
            var product = await _context.Products.Include(p => p.Ratings).FirstOrDefaultAsync(x => x.ProductId == id);
            //var product02 = await _context.Products.FindAsync(id);
            
            int _RatingCount = 0;
            float _RatingValue = 0;
            if (product == null)
            {
                return NotFound();
            }
            if (product.Ratings != null)
            {
                _RatingCount = product.Ratings.Count();
                if (_RatingCount > 0)
                    _RatingValue = product.Ratings.Average(r => r.RatingValue);
            }

            var productVm = new ProductVm
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
                Images = _storageService.GetFileUrl(product.Images),
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                BrandId = product.BrandId,
                RatingValue = _RatingValue,
                RatingCount = _RatingCount
            };

            //productVm.Images = _storageService.GetFileUrl(product.Images);
            _logger.LogInformation("get product");

            return productVm;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductVm>>> GetProducts()
        {
            var products = await _context.Products.Select(x =>
                new
                {
                    x.ProductId,
                    x.ProductName,
                    x.CategoryId,
                    x.Description,
                    x.Price,
                    x.Images,
                    x.CreatedDate,
                    x.UpdatedDate,
                    x.BrandId,

                }).ToListAsync();

            var productVms = products.Select(x =>
                new ProductVm
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    Description = x.Description,
                    Price = x.Price,
                    Images = _storageService.GetFileUrl(x.Images),
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    BrandId = x.BrandId,

                }).ToList();

            _logger.LogInformation("get products");
            using (var activity = DemoSource.StartActivity("This is sample activity"))
            {
                _logger.LogInformation("Hello, World!aaaaaaaaaaa");
            }

            return productVms;
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromForm] ProductCreateRequest productCreateRequest)
        {
            var product = new Product
            {
                ProductName = productCreateRequest.ProductName,
                CategoryId = productCreateRequest.CategoryId,
                Description = productCreateRequest.Description,
                Price = productCreateRequest.Price,
                CreatedDate = productCreateRequest.CreatedDate,
                UpdatedDate = productCreateRequest.CreatedDate,
                BrandId = productCreateRequest.BrandId,
            };

            if (productCreateRequest.Images != null)
            {
                product.Images = await SaveFile(productCreateRequest.Images);
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, null);
        }

        private Task<string> SaveFile(string images)
        {
            throw new NotImplementedException();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductCreateRequest productCreateRequest)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            product.ProductName = productCreateRequest.ProductName;
            product.CategoryId = productCreateRequest.CategoryId;
            product.Description = productCreateRequest.Description;
            product.Price = productCreateRequest.Price;
            product.CreatedDate = productCreateRequest.CreatedDate;
            product.UpdatedDate = productCreateRequest.CreatedDate;
            product.BrandId = productCreateRequest.BrandId;


            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("GetByCategory/{idCate}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductVm>>> GetProductByCategory(int idCate)
        {
            var productList = await _context.Products
                .Where(p => p.CategoryId == idCate)
                .ToListAsync();

            List<ProductVm> productVmList = new List<ProductVm>();

            foreach (var x in productList)
            {
                ProductVm get = new ProductVm();
                get.ProductId = x.ProductId;
                get.ProductName = x.ProductName;
                get.Description = x.Description;
                get.Price = x.Price;
                get.CreatedDate = x.CreatedDate;
                get.UpdatedDate = x.UpdatedDate;
                get.BrandId = x.BrandId;
                get.Images = _storageService.GetFileUrl(x.Images);
                //for (int i = 0; i < x.ImageFiles.Count; i++)
                //{
                //    get.ImageLocation.Add(x.ImageFiles.ElementAt(i).ImageLocation);
                //}
                productVmList.Add(get);
            }
            return productVmList;
        }
    }
}
