using System;
using System.Collections.Generic;

namespace soti
{
    public class CodilityRickDrink
    {
        public CodilityRickDrink()
        {
            Console.WriteLine(solution(new int[]
            {
                10,2,1,1
            }, new int[]{
            10,3,2,2}));

            // Console.WriteLine(solution(new int[]
            // {
            //     2,3
            // }, new int[]{
            //3,4}));
        }

        public int solution(int[] juice, int[] capacity)
        {
            int count = 0;
            for (int i = 0; i < capacity.Length; i++)
            {
                int getCapcity = 0;
                for (int j = i; j < juice.Length; j++)
                {
                    if (capacity[i] >= juice[i])
                    {
                        capacity[i] = capacity[i] - juice[i];
                        getCapcity++;
                    }
                }
                count = Math.Max(count, getCapcity);
            }

            return count;
        }
    }
}
