using System;
using System.Linq;
using System.Threading.Tasks;

using fibonacci.Context;
using fibonacci.Models;

using Microsoft.EntityFrameworkCore;

namespace fibonacci.Repositories
{
    public class FibonacciRepository : IFibonacciRepository
    {
        private readonly FibonacciDbContext _context;

        public FibonacciRepository(FibonacciDbContext context)
        {
            _context = context;
        }

        public async Task Add(FibonacciNumber fibonacciNumber)
        {
            try
            {
                fibonacciNumber.Id = Guid.NewGuid().ToString().Replace("-", string.Empty);

                _context.FibonacciNumbers.Add(fibonacciNumber);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return;
            }
        }

        public async Task<FibonacciNumber> GetClosestNumber(int currentNumber)
        {
            var closestNumber = await Task.Run(() =>
            {
                return _context.FibonacciNumbers.OrderByDescending(fn => fn.Value).FirstOrDefault(fn => fn.Value <= currentNumber);
            });

            return closestNumber;
        }

        public async Task<FibonacciNumber> GetFibonacciNumber(int currentNumber)
        {
            var nextNumber = await _context.FibonacciNumbers.SingleOrDefaultAsync(fn => fn.Value == currentNumber);

            return nextNumber;
        }
    }
}
