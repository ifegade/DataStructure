using System;
using System.Collections.Generic;

namespace data
{
    public class VowelSubstring
    {
        public VowelSubstring()
        {
            string S = "caberqiitefg";
            int k = 5;
            string voewel = "aeiou";

            HashSet<char> vow = new HashSet<char>();
            for (int i = 0; i < voewel.Length; i++)
            {
                vow.Add(voewel[i]);
            }
            int currentMax = 0;
            string currentVowel = string.Empty;
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                count = 0;
                if (S.Length < (i + k))
                    break;
                var current = S.Substring(i, k);

                Console.WriteLine(current);

                for (int j = 0; j < current.Length; j++)
                {
                    if (vow.Contains(current[j]))
                        count++;
                }

                if (count >= currentMax)
                {
                    currentMax = count;
                    currentVowel = current;
                }

            }
            Console.WriteLine("Answer ");
            Console.WriteLine(currentVowel);
        }
    }
}
