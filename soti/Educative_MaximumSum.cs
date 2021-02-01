using System;
namespace data
{

    //Maximum Sum Subarray of Size K (easy)
    public class Educative_MaximumSum
    {
        public Educative_MaximumSum()
        {
            Console.WriteLine(findMaxSumSubArray(3, new int[]
            {
                2, 1, 5, 1, 3, 2
            }));
        }


        public int findMaxSumSubArray(int k, int[] arr)
        {
            int max = -1;

            int windowStart = 0;
            int windowSum = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];

                if (windowEnd >= k - 1)
                {
                    max = Math.Max(windowSum, max);

                    windowSum -= arr[windowStart];

                    windowStart++;
                }
            }

            return max;
        }
    }
}
