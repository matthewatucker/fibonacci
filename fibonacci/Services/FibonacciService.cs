using System.Threading.Tasks;

using Fibonacci.Models;
using Fibonacci.Repositories;

namespace Fibonacci.Services
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
            var fibonacciNumber = await _repository.GetFibonacciNumberAsync(currentNumber);

            if (fibonacciNumber != null)
            {
                return fibonacciNumber.Next;
            }

            fibonacciNumber = await _repository.GetClosestNumberAsync(currentNumber) ?? new FibonacciNumber { Value = 1, Previous = 1, Next = 2 };

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

                await _repository.AddAsync(fn);

                fibonacciNumber = fn;
            }

            return fibonacciNumber.Value;
        }
    }
}
