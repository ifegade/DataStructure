using System;
using System.Collections.Generic;

namespace data
{
    public class Educative_LongestSubstring
    {
        public Educative_LongestSubstring()
        {
            Console.WriteLine(findLength("araaci", 2));
        }

        public int findLength(String str, int k)
        {

            Dictionary<char, int> data = new Dictionary<char, int>();

            int windowStart = 0;
            int maxLength = 0;

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char current = str[windowEnd];

                if (data.ContainsKey(current))
                    data[current] = data[current] + 1;
                else
                    data.Add(current, 1);

                while (data.Count > k)
                {
                    char leftChar = str[windowStart];
                    data[leftChar]--;
                    if (data[leftChar] == 0)
                        data.Remove(leftChar);
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;



        }
    }
}
