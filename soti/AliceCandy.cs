using System;
using System.Collections.Generic;

namespace soti
{
    public class AliceCandy
    {
        public AliceCandy()
        {
            int[] candtyTpe = new int[]
            {
               1,1,2,2,3,3
            };
            Console.WriteLine(DistributeCandies(candtyTpe));
        }
        public int DistributeCandies(int[] candyType)
        {

            int max = candyType.Length / 2;

            HashSet<int> different = new HashSet<int>();

            for (int i = 0; i < candyType.Length; i++)
            {
                if (different.Count >= max)
                    break;

                if (!different.Contains(candyType[i]))
                    different.Add(candyType[i]);
            }

            return different.Count;
        }
    }


}
