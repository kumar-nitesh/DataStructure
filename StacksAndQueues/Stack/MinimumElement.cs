/********************************************************************************************
 * Get minimum element from stack.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/get-minimum-element-from-stack/1 
 * Solution   : https://www.youtube.com/watch?v=Trz7JM610Uc
 * 
 * Time Complexity  : O(1)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace StacksAndQueues.Stack
{
    public class MinimumElement : IExecute
    {
        public int MinElement;
        public Stack<int> MinStack = new Stack<int>();

        /// <summary>
        /// Stack doesn't contains the Actual Values.
        /// </summary>
        public int GetMin()
        {
            return MinElement;
        }

        /// <summary>
        /// Current element is always compared with minimum element.
        /// Formula - (Value + (Value - Minimum))
        /// 1. Store a fake value
        /// 2. Store a smaller value 
        /// </summary>
        void Push(int value)
        {
            if (MinStack.Count == 0)
            {
                MinStack.Push(value);
                MinElement = value;
            }
            else if (value >= MinElement)
            {
                MinStack.Push(value);
            }
            else
            {
                MinStack.Push(value + (value - MinElement));
                MinElement = value;
            }
        }

        /// <summary>
        /// (New Min = 2 * Min - Diff)
        /// </summary>
        int Pop()
        {
            if (MinStack.Peek() >= MinElement)
            {
                return MinStack.Pop();
            }
            else
            {
                int value = MinElement;
                MinElement = 2 * MinElement - MinStack.Pop();
                return value;
            }
        }

        public void Execute()
        {
            MinimumElement minimumElement = new MinimumElement();

            minimumElement.Push(6);
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            minimumElement.Push(7);
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            minimumElement.Push(8);
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            minimumElement.Push(5);
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            minimumElement.Push(3);
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            Console.WriteLine("Pop from the Stack " + minimumElement.Pop());
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            minimumElement.Push(10);
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            Console.WriteLine("Pop from the Stack " + minimumElement.Pop());
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
            Console.WriteLine("Pop from the Stack " + minimumElement.Pop());
            Console.WriteLine("Minimum Element from Stack " + minimumElement.GetMin());
        }
    }
}
