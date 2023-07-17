/********************************************************************************************
 * Longest Common Subsequence
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Dynamic Programming - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/longest-common-subsequence-1587115620/1
 * Solution   : https://www.youtube.com/watch?v=PGsgv6nXhLw
 * Time Complexity  : O(m * n)        
 * Space Complexity : O(m * n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.DynamicProgramming
{
    public class LongestCommonSubsequence : IExecute
    {
        int Tabulation(string s1, string s2)
        {
            int[,] dpTable = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dpTable[i, j] = 1 + dpTable[i - 1, j - 1];
                    }
                    else
                    {
                        dpTable[i, j] = Math.Max(dpTable[i - 1, j], dpTable[i, j - 1]);
                    }
                }
            }

            return dpTable[s1.Length, s2.Length];
        }

        public void Execute()
        {
            Console.WriteLine("The longest commond subsequence is : " + Tabulation("abcde", "abc"));
        }
    }
}
