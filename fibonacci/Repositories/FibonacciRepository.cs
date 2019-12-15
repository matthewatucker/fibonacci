using System;
using System.Threading.Tasks;

namespace fibonacci.Repositories
{
    public class FibonacciRepository : IFibonacciRepository
    {
        public Task<int> GetNextNumber(int currentNumber)
        {
            throw new NotImplementedException();
        }
    }
}
