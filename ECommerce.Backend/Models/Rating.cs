using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Backend.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public float RatingValue { get; set; }
        public string RatingBody { get; set; }
        public DateTime RatingTime { get; set; } 
        public Product Product { get; set; }
        public User User { get; set; }

    }
}
