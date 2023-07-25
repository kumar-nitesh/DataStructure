/********************************************************************************************
 * Move Zeroes
 * 
 * Source     : LeetCode
 * Difficulty : Easy
 * Problem    : https://leetcode.com/problems/move-zeroes/description
 * Solution   : https://www.youtube.com/watch?v=PNJoyRaIW7U
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Patterns.TwoPointers
{
    public class MoveZeroes : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("283. MoveZeroes");
            Console.WriteLine("Difficulty Level - Easy\n");

            Console.WriteLine("Using Two Pointers Technique\n");

            int[] arr = new int[] { 0, 1, 0, 3, 12 };
            UsingTwoPointersTechnique(arr);
            Console.WriteLine(String.Join(",", arr));
        }

        private void UsingTwoPointersTechnique(int[] arr)
        {
            int left = 0;
            int right = 0;

            while (right < arr.Length)
            {
                if (arr[right] == 0)
                {
                    right++;
                }
                else
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                    right++;
                    left++;
                }
            }
        }
    }
}
