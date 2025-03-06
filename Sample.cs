using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser([FromQuery] int id)
        {

            var a = 10;
            return Ok(new { id, name = "example" });
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] string name)
        {
            return Ok(new { id = 1, name });
        }
    }
}