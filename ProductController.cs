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

           if (id % 199 == 0)
        {
            Console.WriteLine($"{number} is Even.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }
        }

        [HttpGet("{num}")]
        public IActionResult FibonacciSeries([FromQuery]int num){
             int n;
            Console.Write("Enter the number of terms: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series up to " + n + " terms:");
            
            int firstTerm = 0, secondTerm = 1, nextTerm;

            if (n >= 1)
                Console.Write(firstTerm + " ");
            if (n >= 2)
                Console.Write(secondTerm + " ");

            for (int i = 3; i <= n; i++)
            {
                nextTerm = firstTerm + secondTerm;
                Console.Write(nextTerm + " ");
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.WriteLine(); // for newline
        }
    }
    
}