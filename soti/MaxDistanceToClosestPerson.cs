using System;
using System.Collections.Generic;

namespace soti
{
    public class MaxDistanceToClosestPerson
    {
        public MaxDistanceToClosestPerson()
        {
            int[] seats = new int[]
            {
                1,0,0,0,1,0,1
            };

            Console.WriteLine(MaxDistToClosest(seats));
        }


        public int MaxDistToClosest(int[] seats)
        {
            int N = seats.Length;
            int prev = -1, future = 0;
            int ans = 0;

            for (int i = 0; i < N; ++i)
            {
                if (seats[i] == 1)
                {
                    prev = i;
                }
                else
                {
                    while (future < N && seats[future] == 0 || future < i)
                        future++;

                    int left = prev == -1 ? N : i - prev;
                    int right = future == N ? N : future - i;
                    ans = Math.Max(ans, Math.Min(left, right));
                }
            }

            return ans;
        }
    }
}
