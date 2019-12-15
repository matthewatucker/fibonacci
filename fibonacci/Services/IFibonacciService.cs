using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fibonacci.Services
{
    public interface IFibonacciService
    {
        Task<int> GetNextNumberAsync(int currentNumber);
    }
}
