using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Backend.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public float RatingValue { get; set; }
        public string RatingBody { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }

        public DateTime RatingTime { get; set; } 
        public Product Product { get; set; }
        public User User { get; set; }
        

    }
}
