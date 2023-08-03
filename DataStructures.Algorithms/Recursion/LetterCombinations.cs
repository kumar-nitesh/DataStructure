/********************************************************************************************
 * Combinations
 * 
 * Source     : LeetCode
 * Difficulty : Medium
 * Problem    : https://leetcode.com/problems/letter-combinations-of-a-phone-number/
 * Solution   : https://www.youtube.com/watch?v=7IQHYbmuoVU
 * 
 * Time Complexity  : O(4^n)        
 * Space complexity : O(n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Recursion
{
    internal class LetterCombinations : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("17. Letter Combinations of a Phone Number");
            Console.WriteLine("Difficulty Level - MEDIUM");

            Console.WriteLine("Using BackTracking");
            var result = Find("23");

            Print(result);
        }

        private IList<string> Find(string digits)
        {
            string[] phoneMap = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            List<string> result = new List<string>();
            BackTrack("", digits, phoneMap, result);
            return result;
        }

        private void BackTrack(string combination, string nextDigit, string[] phoneMap, List<string> result)
        {
            if (nextDigit.Length == 0)
            {
                result.Add(combination);
                return;
            }

            string letters = phoneMap[nextDigit[0] - '2'];

            foreach (char letter in letters)
            {
                BackTrack(combination + letter, nextDigit.Substring(1), phoneMap, result);
            }
        }

        private void Print(IList<string> result)
        {
            Console.WriteLine("[");
            foreach (var item in result)
            {
                Console.WriteLine($"\t[{string.Join(',', item)}]");
            }
            Console.WriteLine("]");
        }
    }
}
