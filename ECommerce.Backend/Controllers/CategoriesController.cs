using ECommerce.Backend.Data;
using ECommerce.Backend.Models;
using ECommerce.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CategoryVm>>> GetCategorys()
        {
            return await _context.Categories
                .Select(x => new CategoryVm { 
                    CategoryId = x.CategoryId, 
                    CategoryName = x.CategoryName,
                    Description = x.Description
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryVm>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id must bigger than 0");
            }

            var categoryVm = new CategoryVm
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            };

            return categoryVm;
        }

        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> PutCategory(int id, CategoryCreateRequest categoryCreateRequest)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            category.CategoryName = categoryCreateRequest.CategoryName;
            category.Description = categoryCreateRequest.Description;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryVm>> PostCategory(CategoryCreateRequest categoryCreateRequest)
        {
            var category = new Category
            {
                CategoryName = categoryCreateRequest.CategoryName,
                Description = categoryCreateRequest.Description

            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, new CategoryVm {
                CategoryId = category.CategoryId, 
                CategoryName = category.CategoryName,
                Description = category.Description
            });
        }

        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            var categories = await _context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            else if (categories.Products.Count > 0)
            {
                return NoContent();
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
