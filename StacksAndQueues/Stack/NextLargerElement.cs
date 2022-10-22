/********************************************************************************************
 * Next Greater Element.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/next-larger-element-1587115620/1 * 
 * Solution   : https://iq.opengenus.org/flattening-a-linked-list/
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(n) 
 ********************************************************************************************/

namespace StacksAndQueues.Stack
{
    public class NextLargerElement : IExecute
    {
        /// <summary>
        /// Algorithm : (Pop) Ans (Push) [ - A + ] 
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static long[] NextLargerNumber(long[] arr)
        {
            long size = arr.Length;
            long[] result = new long[size];

            Stack<long> stack = new Stack<long>();
            stack.Push(arr[size - 1]);
            result[size - 1] = -1;

            for (long i = arr.Length - 2; i >= 0; i--)
            {
                if (stack.Count > 0 && arr[i] >= stack.Peek())
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = stack.Peek();
                }

                stack.Push(arr[i]);
            }

            return result;
        }

        public void Execute()
        {
            long[] arr = new long[] { 1, 3, 2, 4 };
            Console.WriteLine("[{0}]", string.Join(", ", NextLargerNumber(arr)));
        }
    }
}
