using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ProductController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult getProduct([FromQuery] int id)
        {

           if (id % 200 == 0)
        {
            Console.WriteLine($"{number} is EVEN.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }
        }

        
    }
    
}