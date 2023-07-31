/********************************************************************************************
 * Minimum ASCII Delete Sum for Two Strings
 * 
 * Source     : Leet Code
 * Difficulty : Dynamic Programming - Medium
 * 
 * Time Complexity  : O(s1Len * s2Len)        
 * Space complexity : O(s2Len) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.DynamicProgramming
{
    internal class MinDeleteSum : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("712. Minimum ASCII Delete Sum for Two Strings");
            Console.WriteLine("Difficulty Level - MEDIUM\n");

            Console.WriteLine("Using Dynamic Programming\n");

            Console.WriteLine("The Minimum delete sum is : " + Find("sea", "eat"));
        }

        public int Find(string s1, string s2)
        {
            int s1Len = s1.Length;
            int s2Len = s2.Length;
            int[,] computeCost = new int[s1Len + 1, s2Len + 1];

            for (int i = 1; i <= s1Len; i++)
            {
                computeCost[i, 0] = computeCost[i - 1, 0] + s1[i - 1];
            }

            for (int j = 1; j <= s2Len; j++)
            {
                computeCost[0, j] = computeCost[0, j - 1] + s2[j - 1];
            }

            for (int i = 1; i <= s1Len; i++)
            {
                for (int j = 1; j <= s2Len; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        computeCost[i, j] = computeCost[i - 1, j - 1];
                    }
                    else
                    {
                        computeCost[i, j] = Math.Min(
                                            computeCost[i - 1, j] + s1[i - 1],
                                            computeCost[i, j - 1] + s2[j - 1]);
                    }
                }
            }

            return computeCost[s1Len, s2Len];
        }
    }
}
