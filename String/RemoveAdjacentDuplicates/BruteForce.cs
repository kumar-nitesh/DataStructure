namespace RemoveAdjacentDuplicates
{
    public static class BruteForce
    {
        /// <summary>
        /// Remove Adjacent Duplicates from a string.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static string RemoveAdjacentDuplicates(string s)
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
    }
}
