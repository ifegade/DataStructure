using System;
namespace data
{
    //Sliding window approach
    public class Educative_SumOfSubArray
    {
        public Educative_SumOfSubArray()
        {
            Console.WriteLine(string.Join(" ", findAverages(5, new int[]{
                1,3,2,6,-1,4,1,8,2
            })));
        }

        public double[] findAverages(int K, int[] arr)
        {
            double[] result = new double[arr.Length - K + 1];

            double windowSum = 0;

            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];

                if (windowEnd >= K - 1)
                {
                    result[windowStart] = windowSum / K;

                    windowSum -= arr[windowStart];

                    windowStart++;
                }
            }

            return result;
        }
    }
}
