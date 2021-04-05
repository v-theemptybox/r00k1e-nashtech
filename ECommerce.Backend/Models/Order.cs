using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Backend.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public User User { get; set; }

    }
}
