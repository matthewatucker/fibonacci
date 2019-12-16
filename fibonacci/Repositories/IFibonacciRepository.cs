using System.Threading.Tasks;

using fibonacci.Models;

namespace fibonacci.Repositories
{
    public interface IFibonacciRepository
    {
        Task<FibonacciNumber> GetFibonacciNumber(int currentNumber);
        Task<FibonacciNumber> GetClosestNumber(int currentNumber);
        Task Add(FibonacciNumber fibonacciNumber);
    }
}
