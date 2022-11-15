/********************************************************************************************
 * Maximum Sum Increasing Subsequence
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Dynamic Programming - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/maximum-sum-increasing-subsequence4749/1
 * Solution   : https://www.tutorialcup.com/interview/array/maximum-sum-increasing-subsequence.htm
 * Time Complexity  : O(n * n)        
 * Space Complexity : O(n) 
 ********************************************************************************************/

namespace DynamicProgramming
{
    public class MaximumSumIncreasingSubsequence : IExecute
    {
        int Tabulation(int[] arr)
        {
            int sum = 0;
            int[] dp = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                dp[i] = arr[i];
            }

            for (int i = 0; i < dp.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && arr[i] > dp[i] - dp[j])
                    {
                        dp[i] = arr[i] + dp[j];
                    }
                }

                sum = Math.Max(dp[i], sum);
                // Alternate to Math Max function
                // for (int m = 0; m < n; m++)
                // if (dp[m] > max)
                // max = dp[m];
            }

            return sum;
        }


        public void Execute()
        {
            int[] arr = new int[] { 2, 5, 8, 3, 4, 6 };
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 101, 2, 3, 100 };
            Console.WriteLine("The Maximum Sum of Increasing Subsequence is : " + Tabulation(arr));
            Console.WriteLine("The Maximum Sum of Increasing Subsequence is : " + Tabulation(arr1));
            Console.WriteLine("The Maximum Sum of Increasing Subsequence is : " + Tabulation(arr2));
        }
    }
}
