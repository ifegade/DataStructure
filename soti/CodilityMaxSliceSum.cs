using System;
namespace data
{
    public class CodilityMaxSliceSum
    {
        public CodilityMaxSliceSum()
        {
            Console.WriteLine(solution(new int[]
            {
                3,2,-6,4,0
            }));
        }


        public int solution(int[] A)
        {
            int max = A[0];
            int temMax = A[0];
            int sum = 0;

            for (int i = 1; i < A.Length; i++)
            {

                sum = temMax + A[i];

                temMax = Math.Max(A[i], sum);

                max = Math.Max(temMax, max);
            }
            return max;
            // write your code in Java SE 8
        }
    }
}
