/********************************************************************************************
 * Special Keyboard.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Recursion - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/special-keyboard3018/1 
 * Solution   : https://www.youtube.com/watch?v=c_y7H7qZJRU
 *              https://www.ideserve.co.in/learn/print-maximum-number-of-a-using-four-keys-of-special-keyboard
 * 
 * Time Complexity  : O(n*n)        
 * Space complexity : O(n) 
 ********************************************************************************************/

namespace Algorithms.Recursion
{
    public class SpecialKeyboard : IExecute
    {
        /// <summary>
        /// Using Recursion
        /// </summary>
        int OptimalKeys(int n)
        {
            if (n < 7)
                return n;

            int b, max = 0;

            for (b = n - 3; b > 0; b--)
            {
                int curr = (n - b - 1) * OptimalKeys(b);

                if (curr > max)
                {
                    max = curr;
                }
            }
            return max;
        }

        /// <summary>
        /// Using Dynamic Programming
        /// </summary>
        int OptimalKeysUsingDP(int n)
        {
            if (n < 7)
                return n;

            int[] dp = new int[n + 1];
            for (int i = 1; i <= 6; i++)
            {
                dp[i] = i;
            }

            for (int i = 7; i <= n; i++)
            {
                for (int j = i - 3; j >= 1; j--)
                {
                    int curr = dp[j] * (i - j - 1);

                    if (curr > dp[i])
                    {
                        dp[i] = curr;
                    }
                }
            }

            return dp[n];
        }

        public void Execute()
        {
            Console.WriteLine("The result is : " + OptimalKeys(9));
            Console.WriteLine("The result is : " + OptimalKeysUsingDP(9));
        }
    }
}
