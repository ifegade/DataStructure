using System;
namespace data
{
    public class RotatedSortedArray
    {
        int target = 0;
        public RotatedSortedArray()
        {
            int[] nums = new int[]
            {
                4,5,6,7,0,1,2
            };

            target = 0;

            Console.WriteLine(GetSearch(nums, target));


        }

        private int GetSearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[right])
                    left = mid + 1;
                else
                    right = mid;
            }

            int start = left;
            left = 0;
            right = nums.Length - 1;

            if (target >= nums[start] && target <= nums[right])
                left = start;
            else
                right = start;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;

            }

            return -1;
        }
    }
}
