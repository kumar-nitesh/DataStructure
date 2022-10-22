/********************************************************************************************
 * First non-repeating character in a stream.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/first-non-repeating-character-in-a-stream/0
 * Solution   : 
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

using System.Text;

namespace StacksAndQueues.Queue
{
    public class StreamingAlgorithm : IExecute
    {
        public string FirstNonRepeating(string stream)
        {
            StringBuilder result = new StringBuilder();
            Queue<char> queue = new Queue<char>();
            Dictionary<char, int> mapping = new Dictionary<char, int>();

            for (int i = 0; i < stream.Length; i++)
            {
                char ch = stream[i];

                if (mapping.ContainsKey(ch))
                {
                    mapping[ch]++;
                }
                else
                {
                    mapping.Add(ch, 1);
                }

                queue.Enqueue(ch);

                while (queue.Count > 0 && mapping[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }

                if (queue.Count > 0)
                {
                    result.Append(queue.Peek());
                }
                else
                {
                    result.Append('#');
                }
            }

            return result.ToString();
        }

        public void Execute()
        {
            string inputString = "abcabc";
            Console.WriteLine("{0}", FirstNonRepeating(inputString));
        }
    }
}
