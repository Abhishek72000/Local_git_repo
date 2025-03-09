using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class DimController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult EvenAndOddBythirteen([FromQuery] int id)
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