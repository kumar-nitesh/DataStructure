/********************************************************************************************
 * Minimum number of Coins.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Dynamic Programming - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/-minimum-number-of-coins4426/1 
 * Solution   : https://www.enjoyalgorithms.com/blog/minimum-coin-change
 *              https://www.youtube.com/watch?v=mVg9CfJvayM
 * 
 * Time Complexity  : O(coin size * amount)        
 * Space complexity : O(amount) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.DynamicProgramming
{
    public class MinimumCoins : IExecute
    {
        /// <summary>
        /// Combination Problem - Using Recursion
        /// </summary>
        int Memoization(int[] coins, int amount, int[] dp)
        {
            if (amount == 0)
                return 0;

            if (amount < 0)
                return -1;

            if (dp[amount - 1] != 0)
                return dp[amount - 1];

            int minCoins = int.MaxValue;

            for (int i = 0; i < coins.Length; i++)
            {
                if (amount >= coins[i])
                {
                    int currentCoins = Memoization(coins, amount - coins[i], dp);

                    if (currentCoins >= 0 && minCoins > currentCoins)
                    {
                        minCoins = currentCoins + 1;
                    }
                }
            }

            dp[amount - 1] = (minCoins == int.MaxValue) ? -1 : minCoins;

            return dp[amount - 1];
        }

        /// <summary>
        /// Using Tabulation
        /// Time Complexity  : O(n * amount)    
        /// Space complexity : O(amount)
        /// </summary>
        int Tabulation(int[] coins, int amount, int[] dp)
        {
            if (amount == 0)
                return 0;

            if (amount < 0)
                return int.MaxValue;

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i >= coins[j])
                    {
                        int currCount = dp[i - coins[j]];

                        if (currCount != int.MaxValue && dp[i] > currCount + 1)
                        {
                            dp[i] = currCount + 1;
                        }
                    }
                }
            }

            return dp[amount];
        }

        /// <summary>
        /// Doesn't work if previous two elements sum is greater than next element.
        /// </summary>
        List<int> Greedy(int[] coins, int amount)
        {
            List<int> ans = new List<int>();
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                while (amount >= coins[i])
                {
                    amount -= coins[i];
                    ans.Add(coins[i]);
                }
            }

            return ans;
        }

        public void Execute()
        {
            int[] greedyCoins = new int[10]
            {
                1,2,5,10,20,50,100,200,500,2000
            };

            int[] dpCoins = new int[]
            {
               1,2,5
            };

            int greedyAmount = 43;
            int dpAmount = 11;

            int[] dpMemoization = new int[dpAmount + 1];
            dpMemoization[0] = 0;
            Console.WriteLine("The result is : " + Memoization(dpCoins, dpAmount, dpMemoization));

            int[] dpTabular = new int[dpAmount + 1];
            Array.Fill(dpTabular, int.MaxValue);
            dpTabular[0] = 0;
            Console.WriteLine("The result is : " + Tabulation(dpCoins, dpAmount, dpTabular));

            Console.WriteLine("The result is : " + string.Join(",", Greedy(greedyCoins, greedyAmount)));
        }
    }
}
