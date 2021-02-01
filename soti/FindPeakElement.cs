using System;
namespace data
{
    public class FindPeakElement
    {
        public FindPeakElement()
        {
            int[] nums = new int[]
            {
                1,2,3,1
               // 1,2,1,3,5,6,4
            };


            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[mid + 1])
                    left = mid + 1;
                else
                    right = mid;
            }

            Console.WriteLine(left);


        }

        int GetPeak(int[] nums, int left, int right)
        {
            if (left == right)// || right - left <= 1)
            {
                return -1;
            }
            int mid = left + (right - left) / 2;

            int adjacentLeft = mid - 1;
            int adjacentRight = mid + 1;

            if (adjacentLeft == -1)
                adjacentLeft = nums.Length - 1;

            if (nums[mid] > nums[adjacentRight])
            {
                left = mid + 1;
            }
            else
                right = mid;

            return left;
        }
    }
}
