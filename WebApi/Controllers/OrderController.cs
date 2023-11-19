using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public OrderController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _context.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.Product)
                    .ToList();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}", Name = "GetOneOrder")]
        public IActionResult GetOneOrder([FromRoute(Name = "id")] int id)
        {
            try
            {
                var order = _context.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.Product)
                    .Where(o => o.OrderID.Equals(id))
                    .SingleOrDefault();

                if (order is null)
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Order with id:{id} could not be found."
                    });  // 404

                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("customer/{customer_id:int}", Name = "GetCustomerOrders")]
        public IActionResult GetCustomerOrders([FromRoute(Name = "customer_id")] int customer_id)
        {
            try
            {
                var orders = _context.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.Product)
                    .Where(o => o.CustomerID.Equals(customer_id))
                    .ToList();

                if (orders.Count == 0)
                {
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Orders for customer with id:{customer_id} could not be found."
                    });  // 404
                }

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Additional endpoints for handling orders can be added as needed.
    }
}
