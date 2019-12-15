using System.Threading.Tasks;

namespace fibonacci.Repositories
{
    public interface IFibonacciRepository
    {
        Task<int> GetNextNumber(int currentNumber);
    }
}
