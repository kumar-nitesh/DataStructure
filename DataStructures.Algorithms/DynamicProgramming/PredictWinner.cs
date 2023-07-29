/********************************************************************************************
 * Predict the Winner.
 * 
 * Source     : Leet Code
 * Difficulty : Dynamic Programming - Medium
 * Problem    : 
 * 
 * Time Complexity  : O(n * n)        
 * Space complexity : O(n * n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.DynamicProgramming
{
    internal class PredictWinner : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("486. Predict the Winner");
            Console.WriteLine("Difficulty Level - MEDIUM\n");

            Console.WriteLine("Using Dynamic Programming\n");

            int[] arr = new int[] { 1, 5, 2 };
            Console.WriteLine("The Winner is " + IsWinner(arr));
        }

        public bool IsWinner(int[] nums)
        {
            int n = nums.Length;
            int[,] dp = new int[n, n];

            for (int i = n - 1; i >= 0; --i)
            {
                for (int j = i; j < n; ++j)
                {
                    if (i == j)
                    {
                        dp[i, j] = nums[i];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
                    }
                }
            }

            return dp[0, n - 1] >= 0;
        }
    }
}
