using System;
using System.Threading.Tasks;

namespace fibonacci.Services
{
    public class FibonacciService : IFibonacciService
    {
        public Task<int> GetNextNumberAsync(int currentNumber)
        {
            throw new NotImplementedException();
        }
    }
}
