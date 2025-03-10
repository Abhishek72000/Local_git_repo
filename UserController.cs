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
    [HttpGet("getprogram/{id}")]
        public IActionResult GetProgram(int id)
        {
            var program = _programs.FirstOrDefault(p => p.Id == id);

            if (program == null)
            {
                return NotFound(new { Message = "Program not found." });
            }

            return Ok(program);
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