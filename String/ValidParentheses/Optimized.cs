namespace ValidParentheses
{
    public static class Optimized
    {
        /// <summary>
        /// Balanced Brackets
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static bool ValidParentheses(string s)
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
    }
}
