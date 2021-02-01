using System;
using System.Collections.Generic;

namespace data
{
    //Given a string, find the length of the longest substring, which has no repeating characters.

    //Input: String="aabccbb"
    //Output: 3
    //Explanation: The longest substring without any repeating characters is "abc".
    public class NoRepeatingSubstring
    {
        public NoRepeatingSubstring()
        {
            Console.WriteLine(findLength("aabcbb"));
        }

        public int findLength(String str)
        {
            int max = 0;

            Dictionary<char, int> data = new Dictionary<char, int>();
            int windowStart = 0;

            for (int windowsEnd = 0; windowsEnd < str.Length; windowsEnd++)
            {
                Char current = str[windowsEnd];

                if (data.ContainsKey(current))
                {
                    windowStart = Math.Max(windowStart, data[current] + 1);
                }

                data[current] = windowsEnd;

                max = Math.Max(max, windowsEnd - windowStart + 1);
            }

            return max;
        }
    }
}
