using System.Threading.Tasks;

using Fibonacci.Services;

using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacciService _service;

        public FibonacciController(IFibonacciService service)
        {
            _service = service;
        }

        [HttpGet("next/{currentNumber}")]
        public async Task<IActionResult> NextFibonacciNumber(int currentNumber)
        {
            var nextNumber = await _service.GetNextNumberAsync(currentNumber);

            return Ok(nextNumber);
        }
    }
}