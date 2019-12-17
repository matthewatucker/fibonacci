namespace Fibonacci.Models
{
    public class FibonacciNumber
    {
        public string Id { get; set; }
        public int Value { get; set; }
        public int Previous { get; set; }
        public int Next { get; set; }
    }
}
