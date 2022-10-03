/* <summary>
/// Geeks for Geeks - Must Do
/// Array - Medium
/// Problem - https://practice.geeksforgeeks.org/problems/minimum-platforms/0
/// Greedy Algorithm
/// 1. Sort Arrivals and Deparutes Timing*/

namespace ChocolateDistribution
{
    public class BruteForce
    {
        /// <summary>
        /// Geeks for Geeks - Must Do
        /// Array - Easy
        /// Problem - https://practice.geeksforgeeks.org/problems/chocolate-distribution-problem/0
        /// Solution - https://www.youtube.com/watch?v=50nn3bA1BT4
        /// 1. Sort the Array
        /// 2. Traverse the array
        /// 3. Calculate the Min and Max Window.
        /// Time Complexity: O(nlogn)
        /// Space complexity: O(1)
        /// </summary>
        public static int FindMinDiff(int[] choclist, int n, int m)
        {
            Array.Sort(choclist);
            int minDiff = int.MaxValue;

            for (int i = 0; i <= n - m; i++)
            {
                int minWindow = choclist[i];
                int maxWindow = choclist[i + m - 1];

                int currentDiff = maxWindow - minWindow;

                if (minDiff > currentDiff)
                {
                    minDiff = currentDiff;
                }

            }

            return minDiff;
        }
    }
}
