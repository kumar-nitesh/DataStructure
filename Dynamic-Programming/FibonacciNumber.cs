/********************************************************************************************
 * Fibonacci Number
 * 
 * Source     : Leet Code - 509
 * Difficulty : Dynamic Programming - Easy
 * Problem    : https://leetcode.com/problems/fibonacci-number/
 * Solution   : https://www.youtube.com/watch?v=PGsgv6nXhLw
 ********************************************************************************************/

namespace DynamicProgramming
{
    public class FibonacciNumber : IExecute
    {
        /// <summary>
        /// Recursion
        /// </summary>
        /// Time Complexity: O(2ⁿ)
        /// Space complexity: O(1)
        int Recursion(int n)
        {
            if (n <= 1)
                return n;

            int fibN1 = Recursion(n - 1);
            int fibN2 = Recursion(n - 2);
            int fibN = fibN1 + fibN2;

            return fibN;
        }

        /// <summary>
        /// Memoization(Top Down) Approach
        /// T(n) = T(n-1) + T(n-2).
        /// The function of F(n-2) is 1 because F(n-2) is in the cache when we calculate F(n - 1).
        /// T(n) = T(n-1) + 1 = T(n-2) + 2 = ... = T(n-n) + n
        /// T(n) = O(n + 1) = O(n)
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        int Memoized(int n)
        {
            int[] questionbank = new int[n + 1];
            if (n <= 1)
                return n;

            if (questionbank[n] != 0)
                return questionbank[n];

            int fibN1 = Memoized(n - 1);
            int fibN2 = Memoized(n - 2);
            int fibN = fibN1 + fibN2;

            questionbank[n] = fibN;

            return fibN;
        }

        /// <summary>
        /// Tabulation(Bottom Up) Approach
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        int Tabulation(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        /// <summary>
        /// Iterative Method - Fibonacci way
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        int SpaceOptimized(int n)
        {
            int fibN1 = 0;
            int fibN2 = 1;
            int fibN = fibN1 + fibN2;

            if (n == 0) return 0;
            for (int i = 1; i < n; i++)
            {
                fibN = fibN1 + fibN2;

                // Shift logic
                fibN1 = fibN2;
                fibN2 = fibN;
            }

            return fibN;
        }

        public void Execute()
        {
            Console.WriteLine("#######LeetCode######");
            Console.WriteLine("509. Fibonacci Number");
            Console.WriteLine("Difficulty Level - EASY");

            Console.WriteLine(Recursion(10));
            Console.WriteLine(Memoized(10));
            Console.WriteLine(Tabulation(10));
            Console.WriteLine(SpaceOptimized(10));

            Console.WriteLine(Recursion(5));
            Console.WriteLine(Memoized(5));
            Console.WriteLine(Tabulation(5));
            Console.WriteLine(SpaceOptimized(5));

            Console.WriteLine(Recursion(6));
            Console.WriteLine(Memoized(6));
            Console.WriteLine(Tabulation(6));
            Console.WriteLine(SpaceOptimized(6));
        }
    }
}
