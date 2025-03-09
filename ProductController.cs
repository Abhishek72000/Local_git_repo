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

           if (id % 204 == 0)
        {
            Console.WriteLine($"{number} is EVEN.");
        }
        
        }
        
        [HttpGet("{id}")]
        public IActionResult getUser([FromQuery] int id)
        {

           if (id % 2 == 0)
        {
            Console.WriteLine($"{number} is EVEN.");
        }
        
        }
        [HttpGet("{id}")]
        public IActionResult getAuthor([FromQuery] int id)
        {

           if (id % 2 == 0)
        {
            Console.WriteLine($"{number} is odd.");
        }
        
        }

        
    }
    
}