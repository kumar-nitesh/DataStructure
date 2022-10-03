namespace Arrays
{
    public class ChocolateDistribution : IExecute
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
        public int FindMinDiff(int[] choclist, int n, int m)
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

        public void Execute()
        {
            int[] choclist = new int[] { 3, 4, 1, 9, 56, 7, 9, 12 };
            Console.WriteLine(FindMinDiff(choclist, 8, 5));

            int[] choclist1 = new int[] { 17, 83, 59, 25, 38, 63, 25, 1, 37 };
            Console.WriteLine(FindMinDiff(choclist1, 9, 9));
        }
    }
}
