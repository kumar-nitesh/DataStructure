namespace ValidParentheses
{
    public static class BruteForce
    {
        /// <summary>
        /// Balanced Brackets
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static bool ValidParentheses(string s)
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
    }
}