using System;
namespace soti
{
    public class Educative_SmallestSubarray
    {
        public Educative_SmallestSubarray()
        {
            Console.WriteLine(findMinSubArray(7, new int[]
            {
                2, 1, 5, 2, 3, 2
            }));
        }

        public int findMinSubArray(int S, int[] arr)
        {

            int sum = 0;
            int start = 0;
            int minLent = int.MaxValue;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                sum += arr[windowEnd];
                while (sum >= S)
                {
                    minLent = Math.Min(minLent, windowEnd - start + 1);
                    sum -= arr[start];
                    start++;
                }
            }

            return minLent == int.MaxValue ? 0 : minLent;
        }
    }
}
