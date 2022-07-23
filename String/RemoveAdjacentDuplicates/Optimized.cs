namespace RemoveAdjacentDuplicates
{
    public static class Optimized
    {
        /// <summary>
        /// Remove Adjacent Duplicates from a string.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static string RemoveAdjacentDuplicates(string s)
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
    }
}
