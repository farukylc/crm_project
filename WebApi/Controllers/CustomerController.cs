using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly RepositoryContext _context;
        public CustomerController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            try
            {
                var books = _context.Customers.ToList();
                return Ok(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneCustomer([FromRoute(Name = "id")] int id)
        {
            try
            {
                var customer = _context
                .Customers
                .Where(b => b.CustomerID.Equals(id))
                .SingleOrDefault();

                if (customer is null)
                    return NotFound(); //404

                return Ok(customer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        [HttpPost]
        public IActionResult CreateOneCustomer([FromBody] Customer customer)
        {
            try
            {
                if (customer is null)
                    return BadRequest(); // 400 

                _context.Customers.Add(customer);
                _context.SaveChanges();

                return StatusCode(201, customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBook([FromRoute(Name = "id")] int id)
        {
            try
            {
                var entity = _context
                 .Customers
                 .Where(b => b.CustomerID.Equals(id))
                 .SingleOrDefault();
                 

                if (entity is null)
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Customer with id:{id} could not found."
                    });  // 404

                _context.Customers.Remove(entity);
                _context.SaveChanges();
                
                return NoContent();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        
    }
}
