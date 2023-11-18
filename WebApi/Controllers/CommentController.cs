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
                var comments = _context.Comments.ToList();
                return Ok(comments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneComment([FromRoute(Name = "id")] int id)
        {
            try
            {
                var comment = _context
                    .Comments
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
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneComment([FromRoute(Name = "id")] int id)
        {
            try
            {
                var entity = _context
                    .Comments
                    .Where(c => c.CommentID.Equals(id))
                    .SingleOrDefault();

                if (entity is null)
                    return NotFound(new
                    {
                        statusCode = 404,
                        message = $"Comment with id:{id} could not be found."
                    });  // 404

                _context.Comments.Remove(entity);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
