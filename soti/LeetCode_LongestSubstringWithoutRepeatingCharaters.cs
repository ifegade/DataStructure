using System;
using System.Collections.Generic;

namespace data
{

    //url :

    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class LeetCode_LongestSubstringWithoutRepeatingCharaters
    {
        public LeetCode_LongestSubstringWithoutRepeatingCharaters()
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(LengthOfLongestSubstring(""));
        }

        public int LengthOfLongestSubstring(string s)
        {

            int max = 0;

            int windowStart = 0;
            Dictionary<Char, int> data = new Dictionary<char, int>();
            for (int windowsEnd = 0; windowsEnd < s.Length; windowsEnd++)
            {
                Char current = s[windowsEnd];

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
