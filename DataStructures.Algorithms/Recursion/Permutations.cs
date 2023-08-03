/********************************************************************************************
 * Permutations
 * 
 * Source     : LeetCode
 * Difficulty : Medium
 * Problem    : https://leetcode.com/problems/permutations/
 * Solution   : https://chadgolden.com/blog/finding-all-the-permutations-of-an-array-in-c-sharp
 * 
 * Time Complexity  : O(n!)        
 * Space complexity : O(n!) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Recursion
{
    public class Permutations : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("46. Permutations");
            Console.WriteLine("Difficulty Level - MEDIUM");

            Console.WriteLine("Using BackTracking");
            var result = Find(new int[] { 1, 2, 3 });

            Print(result);
        }

        public IList<IList<int>> Find(int[] nums)
        {
            var result = new List<IList<int>>();
            Backtrack(nums, 0, nums.Length - 1, result);
            return result;
        }

        private void Backtrack(int[] nums, int start, int end, List<IList<int>> result)
        {
            if (start == end)
            {
                result.Add(new List<int>(nums));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                Swap(ref nums[start], ref nums[i]);
                Backtrack(nums, start + 1, end, result);
                Swap(ref nums[start], ref nums[i]);
            }
        }

        private void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private void Print(IList<IList<int>> result)
        {
            Console.WriteLine("[");
            foreach (var list in result)
            {
                Console.WriteLine($"\t[{string.Join(',', list)}]");
            }
            Console.WriteLine("]");
        }
    }
}
