﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared
{
    public class OrderCreateRequest
    {
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
