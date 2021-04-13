using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared
{
    public class RatingCreateRequest
    {
        public float RatingValue { get; set; }
        public string RatingBody { get; set; }
        public DateTime RatingTime { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
    }
}
