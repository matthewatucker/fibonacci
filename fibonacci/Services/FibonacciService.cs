using System.Threading.Tasks;

using fibonacci.Models;
using fibonacci.Repositories;

namespace fibonacci.Services
{
    public class FibonacciService : IFibonacciService
    {
        private readonly IFibonacciRepository _repository;

        public FibonacciService(IFibonacciRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> GetNextNumberAsync(int currentNumber)
        {
            var fibonacciNumber = await _repository.GetFibonacciNumber(currentNumber);

            if (fibonacciNumber != null)
            {
                return fibonacciNumber.Next;
            }

            fibonacciNumber = await _repository.GetClosestNumber(currentNumber) ?? new FibonacciNumber { Value = 1, Previous = 1, Next = 2 };

            while (fibonacciNumber.Value <= currentNumber)
            {
                var newValue = fibonacciNumber.Next;
                var newPrevious = fibonacciNumber.Value;
                var newNext = fibonacciNumber.Next + fibonacciNumber.Value;

                var fn = new FibonacciNumber
                {
                    Value = newValue,
                    Next = newNext,
                    Previous = newPrevious
                };

                await _repository.Add(fn);

                fibonacciNumber = fn;
            }

            return fibonacciNumber.Value;
        }
    }
}
