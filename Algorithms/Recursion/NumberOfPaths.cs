/********************************************************************************************
 * Number of paths.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Recursion - Easy
 * Problem    : https://practice.geeksforgeeks.org/problems/number-of-paths0926/1 
 * Solution   : https://www.youtube.com/watch?v=rBAxUTqvlQA
 *              https://www.codingninjas.com/codestudio/library/count-all-number-of-paths-of-a-given-matrix
 * 
 * Time Complexity  : O(m * n)        
 * Space complexity : O(m * n)  
 ********************************************************************************************/

namespace Algorithms.Recursion
{
    public class NumberOfPaths : IExecute
    {
        /// <summary>
        /// Recursive Dynamic Programming solution
        /// Time Complexity  : O(mn)      
        /// Space complexity : O(mn)
        /// </summary>
        long Paths(int m, int n)
        {
            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1] + dp[i - 1, j];
                    }
                }
            }
            return dp[m - 1, n - 1];
        }

        /// <summary>
        /// Space Optimization of DP solution
        /// Time Complexity  : O(m * n)      
        /// Space complexity : O(n)
        /// </summary>
        long PathsUsingDPSpace(int m, int n)
        {
            int[] dp = new int[n];
            dp[0] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[j] += dp[j - 1];
                }
            }
            return dp[n - 1];
        }

        /// <summary>
        /// Using Combinatorics
        /// Total number of paths= M+N-2 C N-1 (3C2)
        /// Result = (m+n-2)! / (n-1)! (m-1)!
        /// Time Complexity  : O(m + n)      
        /// Space complexity : O(1)
        /// </summary>
        long PathUsingCombinatorics(int m, int n)
        {
            int result = 1;
            for (int i = n; i < m + n - 1; i++)
            {
                result *= i;
                result /= (i - n + 1);
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Number of Paths : " + Paths(3, 3));
            Console.WriteLine("Number of Paths : " + PathsUsingDPSpace(3, 7));
            Console.WriteLine("Number of Paths : " + PathUsingCombinatorics(3, 2));
        }
    }
}
