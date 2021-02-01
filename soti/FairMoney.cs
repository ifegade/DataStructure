using System;
using System.Collections.Generic;
using System.Linq;

namespace data
{
    public class FairMoney
    {
        public FairMoney()
        {
            Console.WriteLine(getSequenceSum(-26758517, 22438981, -80854430));
            // Console.WriteLine(firstRepeatedWord("that                 that occurs sometimes"));
            // Console.WriteLine(goodSegment(new List<int>() { 5, 4, 2, 14 }, 1, 10));
            //Console.WriteLine(deleteProducts(new List<int>()
            //{
            // 1,2,3,4
            //}, 2));
        }
        public static int deleteProducts(List<int> ids, int m)
        {

            int size = 0;
            int count = 0;
            Dictionary<int, int> products = new Dictionary<int, int>();

            for (int i = 0; i < ids.Count; i++)
            {
                if (!products.ContainsKey(ids[i]))
                {
                    products.Add(ids[i], 1);
                    size++;
                }
                else
                    products[ids[i]] = products[ids[i]] + 1;
            }

            foreach (var product in products)
            {
                if (product.Value <= m)
                {
                    m -= product.Value;
                    count = count + 1;
                }
                else
                    return size - count;
            }

            return size - count;
        }

        public static int goodSegment(List<int> badNumbers, int lower, int upper)
        {
            badNumbers = badNumbers.OrderBy(s => s).ToList();
            int count = 0;
            int current = 0;
            int prev = lower;

            for (int i = 0; (i < badNumbers.Count && badNumbers[i] <= upper); i++)
            {
                if (badNumbers[i] >= lower)
                {

                    current = badNumbers[i] - prev;
                    if (current > count)
                        count = current;

                    prev = badNumbers[i] + 1;
                }
            }

            current = upper - prev + 1;

            if (current > count)
                count = current;
            return count;
        }

        public static string firstRepeatedWord(string sentence)
        {
            HashSet<string> data = new HashSet<string>();
            var content = sentence.Split(' ');

            for (int i = 0; i < content.Length; i++)
            {
                if (string.IsNullOrEmpty(content[i]))
                    continue;
                if (data.Contains(content[i]))
                    return content[i];

                data.Add(content[i]);
            }
            return string.Empty;
        }





        static long sum = 0;
        static long getSequenceSum(int i, int j, int k)
        {
            sum = 0;
            theSumUpper(i, j);
            theSumLower(j, k);

            //for (int o = i; o <= j; o++)
            //{
            //    sum = sum + o;
            //}

            //for (int o = j; o > k; o--)

            //{
            //    sum = sum + (o - 1);
            //}

            return sum;

        }
        public static long MOD = 1000000007;
        public static long modInv(long x)
        {
            long n = MOD - 2;
            long result = 1;
            while (n > 0)
            {
                if ((n & 1) > 0)
                    result = result * x % MOD;
                x = x * x % MOD;
                n = n / 2;
            }

            return result;
        }
        public static long getSum(long n, long k)
        {
            long ans = 1;

            for (long i = n + 1; i > n - k; i--)
                ans = ans * i % MOD;
            ans = ans * modInv(k + 1) % MOD;

            return ans;
        }

        static void theSumUpper(int current, int baseNumber)
        {
            if (current == baseNumber)
                return;
            sum = sum + current;
            theSumUpper(current + 1, baseNumber);
        }
        static void theSumLower(int current, int baseNumber)
        {
            if (current < baseNumber)
                return;

            sum = sum + current;
            theSumLower(current - 1, baseNumber);
        }
    }
}
