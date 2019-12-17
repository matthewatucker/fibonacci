using System;
using System.Linq;
using System.Threading.Tasks;

using Fibonacci.Context;
using Fibonacci.Models;

using Microsoft.EntityFrameworkCore;

namespace Fibonacci.Repositories
{
    public class FibonacciRepository : IFibonacciRepository
    {
        private readonly FibonacciDbContext _context;

        public FibonacciRepository(FibonacciDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(FibonacciNumber fibonacciNumber)
        {
            try
            {
                fibonacciNumber.Id = Guid.NewGuid().ToString().Replace("-", string.Empty);

                _context.FibonacciNumbers.Add(fibonacciNumber);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                //If we get a db exception, it is most likely a duplicate entry, so its safe to ignore.
                return;
            }
        }

        public async Task<FibonacciNumber> GetClosestNumberAsync(int currentNumber)
        {
            var closestNumber = await Task.Run(() =>
            {
                return _context.FibonacciNumbers.OrderByDescending(fn => fn.Value).FirstOrDefault(fn => fn.Value <= currentNumber);
            });

            return closestNumber;
        }

        public async Task<FibonacciNumber> GetFibonacciNumberAsync(int currentNumber)
        {
            var nextNumber = await _context.FibonacciNumbers.SingleOrDefaultAsync(fn => fn.Value == currentNumber);

            return nextNumber;
        }
    }
}
