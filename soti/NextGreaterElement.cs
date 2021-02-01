using System;
using System.Collections.Generic;

namespace data
{
    public class NextGreaterElement
    {
        public NextGreaterElement()
        {
            Console.WriteLine(string.Join(" ", NextGreaterElements(
                new int[]{
                    4,1,2
                 },
                new int[]{
                    1,3,4,2
                })));
        }


        public static int[] NextGreaterElements(int[] nums1, int[] nums2)
        {
            var outputArr = new int[nums1.Length];
            var calcDict = new Dictionary<int, int>();
            var myStack = new Stack<int>();
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                int current = nums2[i];
                if (myStack.Count > 0)
                {
                    int peek = myStack.Peek();
                    while (myStack.Count > 0 && current > peek)
                    {
                        myStack.Pop();
                    }
                }
                calcDict.Add(current, myStack.Count > 0 ? myStack.Peek() : -1);
                myStack.Push(current);
            }
            int j = 0;
            foreach (int num in nums1)
            {
                outputArr[j] = calcDict[num];
                j++;
            }
            return outputArr;
        }
    }
}
