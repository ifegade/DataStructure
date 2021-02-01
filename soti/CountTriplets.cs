using System;
using System.Collections.Generic;

namespace data
{
    public class CountTriplets
    {
        public CountTriplets()
        {
            int r = 3;
            int[] arr = new int[]
            {
                1,3,9,9,27,81
            };

            //HashSet<int> data = new HashSet<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    data.Add(arr[i]);
            //}

            //int first = 0;
            //int second = 0;
            //int third = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                Console.WriteLine(arr[i]);
                for (int j = i; j < arr.Length; j++)
                {

                    Console.Write(arr[j]);
                    count++;
                    if (count == 3)
                        break;
                }
                Console.WriteLine();

            }

        }
    }
}
