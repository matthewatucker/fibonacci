using System.Threading.Tasks;

using fibonacci.Models;

namespace fibonacci.Repositories
{
    public interface IFibonacciRepository
    {
        Task<FibonacciNumber> GetNextNumber(int currentNumber);
        Task<FibonacciNumber> GetClosestNumber(int currentNumber)
    }
}
