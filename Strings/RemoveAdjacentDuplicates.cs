namespace Strings
{
    public class RemoveAdjacentDuplicates : IExecute
    {
        /// <summary>
        /// Remove Adjacent Duplicates from a string.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static string Remove(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0 && stack.Peek() == s[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            char[] ch = new char[stack.Count];

            // Reverse the Stack Content into String.
            for (int j = stack.Count; j > 0; --j)
            {
                ch[j - 1] = stack.Pop();
            }

            return new string(ch);
        }

        /// <summary>
        /// Remove Adjacent Duplicates from a string.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static string RemoveOptimized(string s)
        {
            char[] stack = new char[s.Length];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                if (index > 0 && stack[index - 1] == currentChar)
                {
                    index--;
                }
                else
                {
                    stack[index] = currentChar;
                    index += 1;
                }
            }

            return new string(stack, 0, index);
        }

        public void Execute()
        {
            Console.WriteLine("#################LeetCode#####################");
            Console.WriteLine("1047. Remove All Adjacent Duplicates In String");
            Console.WriteLine("Difficulty Level - EASY");

            Console.WriteLine(Remove("abbaca"));
            Console.WriteLine(Remove("azxxzy"));
            Console.WriteLine("##########################################");
            Console.WriteLine(RemoveOptimized("abbaca"));
            Console.WriteLine(RemoveOptimized("azxxzy"));
        }
    }
}
