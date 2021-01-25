using System;
namespace soti
{
    public class SquareRoot
    {
        public SquareRoot()
        {
            int[] number = new int[]{
                1, 2, 4, 5, 6 };
            int x = 8;
            Console.WriteLine(getSquareRoot(x));
        }

        public static int getSquareRoot(int x)
        {
            int square = 1;
            int i = 1;
            while (square <= x)
            {
                i++;
                square = i * i;
            }

            return i - 1;
        }
    }
}
