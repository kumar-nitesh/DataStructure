/********************************************************************************************
 * Longest Common Substring
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Dynamic Programming - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/longest-common-substring1452/1
 * Solution   : https://youtu.be/NvmJBCn4eQI?list=TLGGPqT7YwVY6w0xNDExMjAyMg
 *              https://www.techiedelight.com/longest-common-substring-problem/
 *              https://www.techiedelight.com/longest-common-substring-problem/
 *              https://en.wikibooks.org/wiki/Algorithm_Implementation/Strings/Longest_common_substring
 * Time Complexity  : O(m * n)        
 * Space Complexity : O(m * n) 
 ********************************************************************************************/

namespace DynamicProgramming
{
    public class LongestCommonSubstring : IExecute
    {
        /// <summary>
        /// Tabulation Approach(Bottom up)
        /// Find longest common suffix for all pairs of prefixes
        /// </summary>
        int Tabulation(string s1, string s2)
        {
            int[,] dpTable = new int[s1.Length, s2.Length];

            int max = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        dpTable[i, j] = i == 0 || j == 0 ? 1 : dpTable[i - 1, j - 1] + 1;

                        if (dpTable[i, j] > max)
                        {
                            max = dpTable[i, j];
                        }
                    }
                    else
                    {
                        dpTable[i, j] = 0;
                    }
                }
            }

            return max;
        }


        public void Execute()
        {
            Console.WriteLine("The longest commond substring is : " + Tabulation("ABCDGH", "ACDGHR"));
        }
    }
}
