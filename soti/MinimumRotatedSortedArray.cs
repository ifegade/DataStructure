using System;
namespace data
{
    public class MinimumRotatedSortedArray
    {
        public MinimumRotatedSortedArray()
        {
            int[] nums = new int[]
            {
                2, 3, 4, 5, 1
            };

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                    right = mid;
            }

            int start = left;



        }
    }
}
