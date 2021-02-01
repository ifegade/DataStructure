using System;
using System.Collections.Generic;

namespace data
{
    public class CodilityMaximumPossibleProfit
    {
        public CodilityMaximumPossibleProfit()
        {
            Console.WriteLine(solution(new int[]
            {
                23171,
                21011,
                21123,
                21366,
                21013,
                21367
            }));
        }

        public int solution(int[] A)
        {
            if (A.Length == 1 || A.Length == 0)
                return 0;
            int max = 0;

            int min = A[0];
            int currentMax = 0;
            for (int i = 1; i < A.Length; i++)
            {
                currentMax = Math.Max(0, A[i] - min);
                min = Math.Min(min, A[i]);
                max = Math.Max(currentMax, max);

            }
            return max;
        }
    }
}
