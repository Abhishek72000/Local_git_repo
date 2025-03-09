using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class BhushController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult EvenAndOddByfive([FromQuery] int id)
        {

           if (id % 5 == 0)
        {
            Console.WriteLine($"{number} is Even.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }
        }
        [HttpPost]
        public IActionResult CreateUser([FromBody] string name)
        {
            var created=8000;
            return Ok(new { id = 1, name });
        }

    }
}