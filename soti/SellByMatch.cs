using System;
using System.Collections.Generic;

namespace data
{
    public class SellByMatch
    {
        public SellByMatch()
        {
            int[] array = new int[]
                       {
                1,2,1,2,1,3,2
                       };
            HashSet<int> data = new HashSet<int>();



            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (data.Contains(array[i]))
                {
                    data.Remove(array[i]);
                    count++;
                }
                else
                    data.Add(array[i]);
            }

            Console.WriteLine(data.Count);
        }
    }
}
