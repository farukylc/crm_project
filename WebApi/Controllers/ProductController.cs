using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _context.Products.ToList();
                return Ok(products);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneProduct([FromRoute(Name = "id")] int id)
        {
            try
            {
                var product = _context
                    .Products
                    .Where(p => p.ProductID.Equals(id))
                    .SingleOrDefault();

                if (product is null)
                    return NotFound(); // 404

                return Ok(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateOneProduct([FromBody] Product product)
        {
            try
            {
                if (product is null)
                    return BadRequest(); // 400

                _context.Products.Add(product);
                _context.SaveChanges();

                return StatusCode(201, product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneProduct([FromRoute(Name = "id")] int id)
        {
            try
            {
                var entity = _context
                    .Products
                    .Where(p => p.ProductID.Equals(id))
                    .SingleOrDefault();

                if (entity is null)
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Product with id:{id} could not be found."
                    }); // 404

                _context.Products.Remove(entity);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        [HttpPut("{id:int}")]
        public IActionResult UpdateOneProduct([FromRoute(Name = "id")] int id, [FromBody] Product updatedProduct)
        {
            try
            {
                if (updatedProduct is null || id != updatedProduct.ProductID)
                {
                    return BadRequest(new
                    {
                        statusCode = 400,
                        message = "Invalid request. Product ID in the route and request body must match."
                    });
                }

                var existingProduct = _context
                    .Products
                    .Where(p => p.ProductID.Equals(id))
                    .SingleOrDefault();

                if (existingProduct is null)
                {
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Product with id:{id} could not be found."
                    });
                }

                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.imgUrl = updatedProduct.imgUrl;
                existingProduct.SalesAmount = updatedProduct.SalesAmount;
                existingProduct.Stars = existingProduct.Stars;
                _context.SaveChanges();

                return Ok(existingProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
