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
            var c = 9;
            var yup = 1000;
            var creya = 8004;
            var abhi = 777;
            float test = 1.21;
            return Ok(new { id, name = "example" });
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] string name)
        {
            var created=8000;
            return Ok(new { id = 1, name });
        }

        [HttpPost]
        public IActionResult DeleteUser([FromBody] string name)
        {
            var donequant=807000;
            return Ok(200);
        }
        [HttpPost] 
        public IActionResult Test() 
        { 
            return Ok(302); 
        }


    }
}