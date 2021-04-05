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
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<OrderVm>>> GetOrders()
        {
            return await _context.Orders
                .Select(x => new OrderVm { 
                    OrderId = x.OrderId, 
                    UserId = x.UserId,
                    OrderDate = x.OrderDate
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<OrderVm>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            var orderVm = new OrderVm
            {
                OrderId = order.OrderId,
                UserId = order.UserId,
                OrderDate = order.OrderDate
            };

            return orderVm;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, OrderCreateRequest orderCreateRequest)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            order.OrderDate = orderCreateRequest.OrderDate;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<OrderVm>> PostOrder(OrderCreateRequest orderCreateRequest)
        {
            var order = new Order
            {
                UserId = orderCreateRequest.UserId,
                OrderDate = orderCreateRequest.OrderDate
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.OrderId }, new OrderVm { 
                OrderId = order.OrderId, 
                UserId = order.UserId,
                OrderDate = order.OrderDate
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
