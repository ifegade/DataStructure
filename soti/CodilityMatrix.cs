using System;
namespace soti
{
    public class CodilityMatrix
    {
        public CodilityMatrix()
        {
            Console.WriteLine(solution(new int[]
            {
                1,2,5,3,1,3
            }));
        }

        public int solution(int[] A)
        {

            for (int i = 1; i < A.Length; i++)
            {
                int previos = A[i - 1];
                int current = A[i];


            }

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return 0;
        }
    }
}
