/********************************************************************************************
 * Is Subsequence
 * 
 * Source     : LeetCode
 * Difficulty : Easy
 * Problem    : https://leetcode.com/problems/is-subsequence/description
 * Solution   : https://www.youtube.com/watch?v=PwQnydsKk_I
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Patterns.TwoPointers
{
    public class IsSubsequence : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("392. Is Subsequence");
            Console.WriteLine("Difficulty Level - Easy\n");

            Console.WriteLine("Using Two Pointers Technique\n");

            string s = "abc";
            string t = "ahbgdc";

            Console.WriteLine("Is Subsequence : " + UsingTwoPointersTechnique(s, t));
        }

        private bool UsingTwoPointersTechnique(string s, string t)
        {
            int sLen = s.Length;
            int tLen = t.Length;
            int sPointer = 0;

            for (int tPointer = 0; tPointer < tLen && sPointer < sLen; tPointer++)
            {
                if (s[sPointer] == t[tPointer])
                {
                    sPointer++;
                }
            }

            return (sPointer == sLen);
        }
    }
}
