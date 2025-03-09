using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ProgramController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult EvenAndOdd([FromQuery] int id)
        {

           if (id % 4 == 0)
        {
            Console.WriteLine($"{number} is Even.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }
        }

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
        
        
    }
}