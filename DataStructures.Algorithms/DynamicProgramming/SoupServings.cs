/********************************************************************************************
 * Soup Servings
 * 
 * Source     : Leet Code
 * Difficulty : Dynamic Programming - Medium
 * Problem    : https://leetcode.com/problems/soup-servings/description/ 
 * Solution   : 
 * 
 * Time Complexity  : O(n * n)        
 * Space complexity : O(n * n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.DynamicProgramming
{
    internal class SoupServings : IExecute
    {
        Dictionary<Tuple<int, int>, double> memoization = new Dictionary<Tuple<int, int>, double>();

        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("808. Soup Servings");
            Console.WriteLine("Difficulty Level - MEDIUM\n");

            Console.WriteLine("Using Dynamic Programming\n");

            Console.WriteLine("The Probability is " + FindProbability(50));
        }

        public double FindProbability(int num)
        {
            if (num > 4451)
            {
                return 1.0;
            }

            num = (num + 24) / 25;

            return dp(num, num);
        }

        private double dp(int a, int b)
        {
            if (a <= 0 && b <= 0)
            {
                return 0.5;
            }

            if (a <= 0)
            {
                return 1.0;
            }

            if (b <= 0)
            {
                return 0.0;
            }

            var key = Tuple.Create(a, b);

            if (memoization.ContainsKey(key))
            {
                return memoization[key];
            }

            memoization[key] = 0.25 * (dp(a - 4, b) + dp(a - 3, b - 1) + dp(a - 2, b - 2) + dp(a - 1, b - 3));
            return memoization[key];
        }
    }
}
