using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class UserController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            
            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            return Ok(user);
        }

    }
}