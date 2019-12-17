using System.Threading.Tasks;

namespace Fibonacci.Services
{
    public interface IFibonacciService
    {
        Task<int> GetNextNumberAsync(int currentNumber);
    }
}
