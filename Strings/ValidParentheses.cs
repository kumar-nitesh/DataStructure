namespace Strings
{
    public class ValidParentheses : IExecute
    {
        /// <summary>
        /// Balanced Brackets
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static bool Valid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (stack.TryPeek(out char result) &&
                            (result == '{' && s[i] == '}' ||
                            result == '[' && s[i] == ']' ||
                            result == '(' && s[i] == ')'))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Balanced Brackets
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static bool ValidOptimized(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0 && (
                    c.Equals('}') && stack.Peek() == '{' ||
                    c.Equals(']') && stack.Peek() == '[' ||
                    c.Equals(')') && stack.Peek() == '('))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0 ? true : false;
        }

        public void Execute()
        {
            Console.WriteLine("#######LeetCode######");
            Console.WriteLine("20. Valid Parentheses");
            Console.WriteLine("Difficulty Level - EASY");

            Console.WriteLine(Valid("()"));
            Console.WriteLine(Valid("()[]{}"));
            Console.WriteLine(Valid("(]"));
            Console.WriteLine(Valid("{[]}"));
            Console.WriteLine(Valid("([)]"));
            Console.WriteLine("##################################");
            Console.WriteLine(ValidOptimized("()"));
            Console.WriteLine(ValidOptimized("()[]{}"));
            Console.WriteLine(ValidOptimized("(]"));
            Console.WriteLine(ValidOptimized("{[]}"));
            Console.WriteLine(ValidOptimized("([)]"));
        }
    }
}