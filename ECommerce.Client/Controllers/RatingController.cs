using ECommerce.Client.Services.Interfaces;
using ECommerce.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Security.Claims;

namespace ECommerce.Client.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingAPI _ratingApiClient;

        public RatingController(IRatingAPI ratingApiClient, IConfiguration configuration)
        {
            _ratingApiClient = ratingApiClient;
        }

        [HttpPost]
        public IActionResult AddRating(int ProductId, float rvalue)
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction(actionName: "SignIn", controllerName: "Account");

            RatingCreateRequest x = new RatingCreateRequest();
            x.RatingValue = rvalue;
            
            x.RatingTime = DateTime.Now;
            x.ProductId = ProductId;

            //var claimsIdentity = User.Identity as ClaimsIdentity;
            //string userId = claimsIdentity.FindFirst("sub").Value;
            x.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _ratingApiClient.PostRating(x);

            string referer = Request.Headers["Referer"].ToString();
            return Redirect(referer);

        }
    }
}
