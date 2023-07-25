/********************************************************************************************
 * Reverse Vowels of a String
 * 
 * Source     : LeetCode
 * Difficulty : Easy
 * Problem    : https://leetcode.com/problems/reverse-vowels-of-a-string/description/
 * Solution   : https://www.youtube.com/watch?v=Vc4nQa0e2n4
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Patterns.TwoPointers
{
    public class ReverseVowels : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("345. Reverse Vowels of a String");
            Console.WriteLine("Difficulty Level - Easy\n");

            Console.WriteLine("Using Two Pointers Technique\n");

            Console.WriteLine("The Reverse Vowels of a String is : " + UsingTwoPointersTechnique("hello"));
        }

        private string UsingTwoPointersTechnique(string inputString)
        {
            int start = 0;
            int end = inputString.Length - 1;
            char[] chars = inputString.ToCharArray();

            while (start < end)
            {
                if (!IsVowel(chars[start]))
                {
                    start++;
                }
                else if (!IsVowel(chars[end]))
                {
                    end--;
                }
                else
                {
                    char temp = chars[start];
                    chars[start] = chars[end];
                    chars[end] = temp;
                    start++;
                    end--;
                }
            }

            return new string(chars);
        }

        private bool IsVowel(char ch)
        {
            if (ch == 'a' || ch == 'A' ||
                ch == 'e' || ch == 'E' ||
                ch == 'i' || ch == 'I' ||
                ch == 'o' || ch == 'O' ||
                ch == 'u' || ch == 'U')
            {
                return true;
            }

            return false;
        }
    }
}
