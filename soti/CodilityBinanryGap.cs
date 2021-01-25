using System;
using System.Collections.Generic;

namespace soti
{
    public class CodilityBinanryGap
    {
        public CodilityBinanryGap()
        {
            Console.WriteLine(solution(15));
        }


        public int solution(int N)
        {
            int lenght = 0;
            string baseString = Convert.ToString(N, 2);

            if (baseString.Length > 0)
            {
                int count = 0;
                HashSet<int> data = new HashSet<int>();
                for (int i = 0; i < baseString.Length; i++)
                {
                    if (baseString[i] == '1')
                    {
                        if (data.Contains(baseString[i]))
                        {
                            lenght = Math.Max(lenght, count);
                            count = 0;

                        }
                        else
                            data.Add(baseString[i]);
                    }
                    else
                    {
                        count++;
                    }

                }
            }

            return lenght;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }
}
