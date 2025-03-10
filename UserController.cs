using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class UserController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            
            
            return Ok(user);
        }

    }
    


        [HttpGet("getauthor/{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);

            if (author == null)
            {
                return NotFound(new { Message = "Author not found." });
            }

            return Ok(author);
        }
}