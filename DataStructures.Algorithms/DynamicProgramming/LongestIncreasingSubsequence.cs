/********************************************************************************************
 * Longest Increasing Subsequence
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Dynamic Programming - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/longest-increasing-subsequence-1587115620/1
 * Solution   : https://www.youtube.com/watch?v=odrfUCS9sQk
 * Time Complexity  : O(n * n)        
 * Space Complexity : O(n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.DynamicProgramming
{
    public class LongestIncreasingSubsequence : IExecute
    {
        int Tabulation(int[] arr)
        {
            int overallMax = 0;
            int[] dp = new int[arr.Length];

            for (int i = 0; i < dp.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        if (dp[j] > max)
                        {
                            max = dp[j];
                        }
                    }
                }

                dp[i] = max + 1;

                if (dp[i] > overallMax)
                {
                    overallMax = dp[i];
                }
            }

            return overallMax;
        }


        public void Execute()
        {
            int[] arr = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            int[] arr1 = new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            int[] arr2 = new int[] { 1, 3, 7 };
            Console.WriteLine("The Longest Increasing Subsequence is : " + Tabulation(arr));
            Console.WriteLine("The Longest Increasing Subsequence is : " + Tabulation(arr1));
            Console.WriteLine("The Longest Increasing Subsequence is : " + Tabulation(arr2));
        }
    }
}
