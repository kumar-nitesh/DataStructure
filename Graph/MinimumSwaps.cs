/********************************************************************************************
 * Minimum Swaps to Sort
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/minimum-swaps/1
 * Solution   : https://www.geeksforgeeks.org/minimum-number-swaps-required-sort-array/
 * Time Complexity  : O(n log n)        
 * Space Complexity : O(n) 
 ********************************************************************************************/

namespace Graph
{
    public class MinimumSwaps : IExecute
    {

        private static int MinSwapsToSort(int[] arr, int n)
        {
            int minSwaps = 0;
            int[] copyArray = new int[n];
            arr.CopyTo(copyArray, 0);

            Array.Sort(copyArray);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                dict.Add(arr[i], i);
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != copyArray[i])
                {
                    minSwaps++;
                    int temp = arr[i];

                    Swap(arr, i, dict[copyArray[i]]);

                    // Update the indexes in the dictionary accordingly
                    dict[temp] = dict[copyArray[i]];
                    dict[copyArray[i]] = i;

                }
            }

            return minSwaps;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void Execute()
        {
            int[] arr = { 1, 5, 4, 3, 2 };
            Console.WriteLine(MinSwapsToSort(arr, arr.Length));
        }
    }
}
