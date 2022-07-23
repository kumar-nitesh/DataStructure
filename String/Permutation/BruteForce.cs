namespace Permutation
{
    public static class BruteForce
    {
        /// <summary>
        /// Backtracking - Print all Permutations.
        /// </summary>
        /// Time Complexity: O(n * n!)
        /// Space complexity: O(startingIndex - endingIndex)
        public static void Permutations(string ques, string ans)
        {
            if (ques.Length == 0)
            {
                Console.WriteLine(ans);
                return;
            }

            for (int i = 0; i < ques.Length; i++)
            {
                char currentChar = ques[i];

                string leftPartQues = ques.Substring(0, i);
                string rightPartQues = ques.Substring(i + 1);
                string restOfQues = leftPartQues + rightPartQues;

                Permutations(restOfQues, ans + currentChar);
            }
        }

    }
}
