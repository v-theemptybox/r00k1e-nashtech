using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared
{
    public class OrderVm
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
