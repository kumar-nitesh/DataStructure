namespace Strings
{
    public class Permutation : IExecute
    {
        /// <summary>
        /// Backtracking - Print all Permutations.
        /// </summary>
        /// Time Complexity: O(n * n!)
        /// Space complexity: O(startingIndex - endingIndex)
        public static void Print(string ques, string ans)
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

                Print(restOfQues, ans + currentChar);
            }
        }

        public void Execute()
        {
            Console.WriteLine("########LeetCode##########");
            Console.WriteLine("567. Permutation in String");
            Console.WriteLine("Difficulty Level - MEDIUM");

            Console.WriteLine("##########################################");
            Print("abcd", String.Empty);
            //Console.WriteLine(CheckInclusion("ab", "eidboaoo"));

            Console.WriteLine("##########################################");
        }
    }
}
