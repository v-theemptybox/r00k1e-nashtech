using ECommerce.Backend.Data;
using ECommerce.Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductVm>>> GetProducts()
        {
            return await _context.Products
                .Select(x => new ProductVm { 
                    ProductId = x.ProductId, 
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    Description = x.Description,
                    Price = x.Price,
                    Images = x.Images,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    BrandId = x.BrandId,
                    UnitsInStock = x.UnitsInStock,
                    UnitsOnOrder = x.UnitsOnOrder

                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductVm>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            var productVm = new ProductVm
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
                Images = product.Images,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                BrandId = product.BrandId,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder
            };

            return productVm;
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
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProductVm>> PostProduct(ProductCreateRequest productCreateRequest)
        {
            var product = new Product
            {
                ProductName = productCreateRequest.ProductName,
                CategoryId = productCreateRequest.CategoryId,
                Description = productCreateRequest.Description,
                Price = productCreateRequest.Price,
                Images = productCreateRequest.Images,
                CreatedDate = productCreateRequest.CreatedDate,
                UpdatedDate = productCreateRequest.UpdatedDate,
                BrandId = productCreateRequest.BrandId,
                UnitsInStock = productCreateRequest.UnitsInStock,
                UnitsOnOrder = productCreateRequest.UnitsOnOrder

            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, new ProductVm { 
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
                Images = product.Images,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                BrandId = product.BrandId,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder
            });
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
    }
}
