using System;
namespace data
{
    public class BinarySearch
    {
        static int target = 0;
        public BinarySearch()
        {
            int[] nums = new int[]
            {
                5
            };
            target = 5;

            Console.WriteLine(GetSearch(nums, target));

            //nums = new int[]
            //{
            //    -1,0,3,5,9,12
            //};
            nums = new int[]
            {
                -1,0,3,5,9,12
            };
            target = 9;

            Console.WriteLine(GetSearch(nums, target));
        }
        static int GetSearch(int[] num, int target)
        {

            return logData(num, 0, num.Length - 1);
        }
        //using recursion
        static int logData(int[] num, int start, int end)
        {
            if (start == end)
            {
                if (num[start] == target)
                    return start;
                return -1;
            }
            int s = start;
            int mid = (start + end) / 2;
            int e = end;

            if (target == num[mid])
                return mid;

            if (target < num[mid])
                return logData(num, s, mid);
            if (target > num[mid])
                return logData(num, mid + 1, e);
            return -1;
        }

        //using loop
        int binarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                // Prevent (left + right) overflow
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) { return mid; }
                else if (nums[mid] < target) { left = mid + 1; }
                else { right = mid - 1; }
            }

            // End Condition: left > right
            return -1;
        }



    }
}
