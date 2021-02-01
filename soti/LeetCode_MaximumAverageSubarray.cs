using System;
namespace soti
{
    public class LeetCode_MaximumAverageSubarray
    {
        public LeetCode_MaximumAverageSubarray()
        {
            Console.WriteLine(FindMaxAverage(new int[]
            {
                1,12,-5,-6,50,3
            }, 4));
        }

        public double FindMaxAverage(int[] nums, int k)
        {
            double max = int.MinValue;
            double sum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {

                sum += nums[windowEnd];

                if (windowEnd >= k - 1)
                {
                    max = Math.Max(sum / k, max);

                    sum -= nums[windowStart];

                    windowStart++;
                }
            }

            return max;
        }
    }
}
