namespace NewYearChaos
{
    public static class BruteForce
    {
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static string MinimumBribes(int[] queue)
        {
            int bribes = 0;
            string result = string.Empty;
            for (int i = 0; i < queue.Length; i++)
            {
                if (queue[i] - (i + 1) > 2)
                {
                    result = "Too Chaotic";
                    break;
                }

                for (int j = 0; j < i; j++)
                {
                    if (queue[j] > queue[i])
                    {
                        bribes++;
                    }
                }

                result = bribes.ToString();
            }

            return result;
        }
    }
}
