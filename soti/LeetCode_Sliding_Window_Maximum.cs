using System;
namespace data
{
    public class LeetCode_Sliding_Window_Maximum
    {
        public LeetCode_Sliding_Window_Maximum()
        {
            Console.WriteLine(string.Join(" ", MaxSlidingWindow(new int[]
            {
              1,3,-1,-3,5,3,6,7
            }, 3)));

            Console.WriteLine(string.Join(" ", MaxSlidingWindow(new int[]
          {
             1,-1
          }, 1)));


            Console.WriteLine(string.Join(" ", MaxSlidingWindow(new int[]
         {
           7,2,4
         }, 2)));
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] content = new int[nums.Length - k + 1];

            int windowStart = 0;
            int max = int.MinValue;
            for (int windowsEnd = 0; windowsEnd < nums.Length; windowsEnd++)
            {
                if (windowsEnd > 0 && nums[windowsEnd] > nums[windowsEnd - 1])
                    max = int.MinValue;

                max = Math.Max(max, nums[windowsEnd]);

                if (windowsEnd >= k - 1)
                {
                    if (k < 2)
                        max = nums[windowsEnd];
                    content[windowStart] = max;
                    windowStart++;
                }
            }
            return content;
        }
    }
}
