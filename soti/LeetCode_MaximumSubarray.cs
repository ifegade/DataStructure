using System;
namespace data
{
    public class LeetCode_MaximumSubarray
    {
        public LeetCode_MaximumSubarray()
        {
            Console.WriteLine(MaxSubArray(new int[]
            {
                -2,1,-3,4,-1,2,1,-5,4
            }));
        }

        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];

            int sum = 0;
            int windowStart = 0;




            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                sum += nums[windowEnd];

                if (windowEnd >= 4 - 1)
                {
                    max = Math.Max(sum, max);

                    sum -= nums[windowStart];

                    windowStart++;

                }
            }


            return max;
        }
    }
}
