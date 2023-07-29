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
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("808. Soup Servings");
            Console.WriteLine("Difficulty Level - MEDIUM\n");

            Console.WriteLine("Using Dynamic Programming\n");

            Console.WriteLine("The Probability is " + CalculateProbability(50));
        }

        public double CalculateProbability(int n)
        {
            if (n > 5000)
            {
                return 1.0;
            }

            var memo = new Dictionary<(int, int), double>();
            double totalProbability = GetProbability(n, n, memo);
            return totalProbability;
        }

        private double GetProbability(int remainingSoupA, int remainingSoupB, Dictionary<(int, int), double> memo)
        {
            if (remainingSoupA <= 0 && remainingSoupB <= 0)
                return 0.5;

            if (remainingSoupA <= 0)
                return 1.0;

            if (remainingSoupB <= 0)
                return 0.0;

            if (memo.TryGetValue((remainingSoupA, remainingSoupB), out double cachedProbability))
                return cachedProbability;

            double probability = 0.25 * (
                GetProbability(remainingSoupA - 100, remainingSoupB, memo) +
                GetProbability(remainingSoupA - 75, remainingSoupB - 25, memo) +
                GetProbability(remainingSoupA - 50, remainingSoupB - 50, memo) +
                GetProbability(remainingSoupA - 25, remainingSoupB - 75, memo)
            );

            memo[(remainingSoupA, remainingSoupB)] = probability;
            return probability;
        }
    }
}
