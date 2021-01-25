using System;
using System.Collections.Generic;

namespace soti
{
    public class LeftRotate
    {
        public static List<int> GetLeftRotate(int d, List<int> arr)
        {
            int count = 0;
            while (count < d)
            {
                int temp = 0;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                count++;
            }
            return arr;
        }


    }
}
