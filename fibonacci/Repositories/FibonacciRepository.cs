using System.Linq;
using System.Threading.Tasks;

using fibonacci.Context;
using fibonacci.Models;

namespace fibonacci.Repositories
{
    public class FibonacciRepository : IFibonacciRepository
    {
        private readonly FibonacciDbContext _context;

        public FibonacciRepository(FibonacciDbContext context)
        {
            _context = context;
        }

        public async Task<FibonacciNumber> GetClosestNumber(int currentNumber)
        {
            var closestNumber = await Task.Run(() =>
            {
                return _context.FibonacciNumbers.OrderByDescending(fn => fn.Value).FirstOrDefault(fn => fn.Value < currentNumber);
            });

            return closestNumber;
        }

        public async Task<FibonacciNumber> GetNextNumber(int currentNumber)
        {
            var nextNumber = await _context.FibonacciNumbers.FindAsync(currentNumber);

            return nextNumber;
        }
    }
}
