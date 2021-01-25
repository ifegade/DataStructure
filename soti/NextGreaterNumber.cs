using System;
namespace soti
{
    public class NextGreaterNumber
    {
        public NextGreaterNumber()
        {
            int n = 101;
            var back = SeperateNumber(n);
            Console.WriteLine(back);
            if (n < back)
                Console.WriteLine(back);
            else
                Console.WriteLine(-1);
        }
        int reverse = 0;

        private int SeperateNumber(int N)
        {
            if (N == 0)
                return reverse;

            reverse = reverse * 10 + (N % 10);

            return SeperateNumber(N / 10);
        }
    }
}
