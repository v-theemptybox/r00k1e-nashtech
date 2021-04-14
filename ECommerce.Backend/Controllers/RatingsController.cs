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
    public class RatingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RatingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<RatingVm>>> GetRatings()
        {
            return await _context.Ratings
                .Select(x => new RatingVm { 
                    RatingId = x.RatingId, 
                    RatingValue = x.RatingValue,
                    RatingBody = x.RatingBody,
                    RatingTime = x.RatingTime,

                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<RatingVm>> GetRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            var ratingVm = new RatingVm
            {
                RatingId = rating.RatingId,
                RatingValue = rating.RatingValue,
                RatingBody = rating.RatingBody,
                RatingTime = rating.RatingTime
            };

            return ratingVm;
        }

        bool CheckIfExist(int PId, string UId)
        {
            var x = _context.Ratings.Where(x => x.ProductId == PId && x.UserId == UId).FirstOrDefault();
            if (x == null)
                return false;
            return true;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, RatingCreateRequest ratingCreateRequest)
        {
            
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            rating.RatingValue = ratingCreateRequest.RatingValue;
            rating.RatingBody = ratingCreateRequest.RatingBody;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<RatingVm>> PostRating(RatingCreateRequest ratingCreateRequest)
        {
            if (CheckIfExist(ratingCreateRequest.ProductId, ratingCreateRequest.UserId) == true)
            {
                var ratin = await _context.Ratings.Where(x => x.ProductId == ratingCreateRequest.ProductId && x.UserId == ratingCreateRequest.UserId).FirstOrDefaultAsync();
                if (ratin == null)
                {
                    return NotFound();
                }

                ratin.RatingValue = ratingCreateRequest.RatingValue;
                ratin.RatingBody = ratingCreateRequest.RatingBody;
                ratin.UserId = ratingCreateRequest.UserId;
                ratin.ProductId = ratin.ProductId;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            var rating = new Rating
            {
                RatingValue = ratingCreateRequest.RatingValue,
                RatingBody = ratingCreateRequest.RatingBody,
                RatingTime = DateTime.Now,
                UserId = ratingCreateRequest.UserId,
                ProductId = ratingCreateRequest.ProductId
            };

            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRating", new { id = rating.RatingId }, new RatingVm { 
                RatingId = rating.RatingId, 
                RatingValue = rating.RatingValue,
                RatingBody = rating.RatingBody,
                RatingTime = rating.RatingTime
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
