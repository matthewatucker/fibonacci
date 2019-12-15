using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace fibonacci.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public FibonacciController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("next/{currentNumber}")]
        public async Task<IActionResult> NextFibonacciNumber(int currentNumber)
        {
            var nextNumber = 1;
            return Ok(nextNumber);
        }
    }
}