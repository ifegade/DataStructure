using System;
using System.Collections.Generic;
using System.Text;

namespace data
{
//    Given an array of characters where each character represents a fruit tree, you are given two baskets, and your goal is to put maximum number of fruits in each basket.The only restriction is that each basket can have only one type of fruit.

//You can start with any tree, but you can’t skip a tree once you have started. You will pick one fruit from each tree until you cannot, i.e., you will stop when you have to pick from a third fruit type.

//Write a function to return the maximum number of fruits in both the baskets.

//    Input: Fruit=['A', 'B', 'C', 'A', 'C']
//Output: 3
//Explanation: We can put 2 'C' in one basket and one 'A' in the other from the subarray['C', 'A', 'C']


//        Input: Fruit=['A', 'B', 'C', 'B', 'B', 'C']
//    Output: 5
//Explanation: We can put 3 'B' in one basket and two 'C' in the other basket.
//This can be done if we start with the second letter: ['B', 'C', 'B', 'B', 'C']
    public class Educative_Fruits_Into_Baskets
    {
        public Educative_Fruits_Into_Baskets()
        {
            Console.WriteLine(findLength(new char[]{
                'A', 'B', 'C', 'A', 'C'
            }));
            Console.WriteLine(findLength(new char[]{
                'A', 'B', 'C', 'B', 'B', 'C'
            }));
        }
        public  int findLength(char[] arr)
        {
            int max = 0;
            int size = 2;

            Dictionary<char, int> data = new Dictionary<char, int>();

            int startWindow = 0;

            for(int endWindow = 0; endWindow < arr.Length; endWindow++)
            {
                char current = arr[endWindow];

                if (data.ContainsKey(current))
                {
                    data[current] = data[current] + 1;
                }
                else
                    data.Add(current, 1);

                while(data.Count > size)
                {
                    if (data.ContainsKey(arr[startWindow]))
                        data[arr[startWindow]] = data[arr[startWindow]] - 1;
                    else
                        data.Add(arr[startWindow], 1);

                    if (data[arr[startWindow]] == 0)
                        data.Remove(arr[startWindow]);
                    startWindow++;
                }
                max = Math.Max(max, endWindow - startWindow + 1);
            }

            // TODO: Write your code here
            return max;
        }
    }
}
