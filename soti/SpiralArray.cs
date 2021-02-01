using System;
namespace data
{
    public class SpiralArray
    {
        public SpiralArray()
        {
            int input1 = 2;
            int[,] arrays = new int[input1, input1];

            int start = 1;
            int minCol = 0;
            int maxCol = input1 - 1;
            int minRol = 0;
            int maxRol = input1 - 1;

            while (minCol <= maxCol && minRol <= maxRol)
            {
                for (int i = minCol; i <= maxCol; i++)
                {
                    arrays[minRol, i] = start;
                    start++;
                }
                for (int i = minRol + 1; i <= maxRol; i++)
                {
                    arrays[i, maxCol] = start;

                    start++;
                }

                for (int i = maxCol - 1; i >= minCol; i--)
                {
                    arrays[maxRol, i] = start;

                    start++;
                }

                for (int i = maxRol - 1; i >= minRol + 1; i--)
                {
                    arrays[i, minCol] = start;

                    start++;
                }

                minCol++;

                minRol++;

                maxCol--;

                maxRol--;
            }

            int[] output = new int[input1 * input1];

            int index = 0;
            for (int i = 0; i < input1; i++)
            {
                for (int j = 0; j < input1; j++)
                {
                    output[index] = arrays[i, j];
                    index++;
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }

        }
    }
}
