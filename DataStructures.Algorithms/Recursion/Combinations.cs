/********************************************************************************************
 * Combinations
 * 
 * Source     : LeetCode
 * Difficulty : Medium
 * Problem    : https://leetcode.com/problems/combinations/
 * Solution   : https://www.youtube.com/watch?v=7IQHYbmuoVU
 * 
 * Time Complexity  : O(2^n)        
 * Space complexity : O(k) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Recursion
{
    public class Combinations : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("77. Combinations");
            Console.WriteLine("Difficulty Level - MEDIUM");

            Console.WriteLine("Using BackTracking");
            var result = Find(4, 2);

            foreach (IList<int> row in result)
            {
                foreach (int num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }

        public IList<IList<int>> Find(int n, int k)
        {
            var result = new List<IList<int>>();
            Backtrack(n, k, 1, new List<int>(), result);
            return result;
        }

        private void Backtrack(int n, int k, int start, List<int> combination, List<IList<int>> result)
        {
            if (combination.Count == k)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                combination.Add(i);
                Backtrack(n, k, i + 1, combination, result);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
