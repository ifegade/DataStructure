using System;
namespace soti
{
    public class SearchRange
    {
        public SearchRange()
        {
            int[] nums = new int[]
            {
                5,7,7,8,8,10
            };
            int target = 6;

            var output = SearchRanges(nums, target);

            Console.WriteLine(output[0] + "  >  " + output[1]);
        }

        public int[] SearchRanges(int[] nums, int target)
        {

            if (nums == null || nums.Length == 0)
                return new int[]
                  {
                        -1,-1
                  };
            else if (nums.Length == 1 && nums[0] == target)
                return new int[]
                  {
                        0,0
                  };

            int left = 0;
            int right = nums.Length - 1;

            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[left + 1] == target && nums[mid] == target)
                {
                    return new int[] { left + 1, mid + 1 };
                }
                if (nums[mid] < target)
                    left = mid;
                else
                    right = mid;

            }


            return new int[]
            {
                -1,-1
            };
        }
    }
}
