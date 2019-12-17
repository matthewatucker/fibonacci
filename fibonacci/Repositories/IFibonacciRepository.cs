using System.Threading.Tasks;

using Fibonacci.Models;

namespace Fibonacci.Repositories
{
    public interface IFibonacciRepository
    {
        Task<FibonacciNumber> GetFibonacciNumberAsync(int currentNumber);
        Task<FibonacciNumber> GetClosestNumberAsync(int currentNumber);
        Task AddAsync(FibonacciNumber fibonacciNumber);
    }
}
