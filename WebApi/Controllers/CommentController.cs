using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public CommentController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllComments()
        {
            try
            {
                var comments = _context.Comments
                    .Include(i => i.Customer)
                    .Include(p => p.Product)
                    
                    .ToList();
                return Ok(comments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}", Name = "GetOneComment")]
        public IActionResult GetOneComment([FromRoute(Name = "id")] int id)
        {
            try
            {
                var comment = _context
                    .Comments.Include(i => i.Customer)
                    .Include(p => p.Product)
                    .Where(c => c.CommentID.Equals(id))
                    .SingleOrDefault();

                if (comment is null)
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Comment with id:{id} could not be found."
                    });  // 404

                return Ok(comment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        
        [HttpGet("user/{user_id:int}", Name = "GetUserComments")]
        public IActionResult GetUserComments([FromRoute(Name = "user_id")] int user_id)
        {
            try
            {
                var comments = _context
                    .Comments.Include(i => i.Customer)
                    .Include(p => p.Product)
                    .Where(c => c.CustomerID.Equals(user_id))
                    .ToList();

                if (comments.Count == 0)
                {
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Comments for user with id:{user_id} could not be found."
                    });  // 404
                }

                return Ok(comments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}
