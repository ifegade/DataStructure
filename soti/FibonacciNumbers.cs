using System;
namespace soti
{
    public class FibonacciNumbers
    {
        public FibonacciNumbers()
        {
            Console.WriteLine(Fib(4));
            //lol
        }
        public int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n - 1) + (Fib(n - 2));
        }
    }
}
