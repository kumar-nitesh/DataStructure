namespace DataStructures.Algorithms.Arrays
{
    public class MinimumPlatform : IExecute
    {
        /// <summary>
        /// Geeks for Geeks - Must Do
        /// Array - Medium
        /// Problem - https://practice.geeksforgeeks.org/problems/minimum-platforms/0
        /// Solution - https://www.youtube.com/watch?v=Ls_AYoz1IX0
        /// Greedy Algorithm (Find Overlap)
        /// 1. Sort Arrivals and Deparutes Timing
        /// 2. Iterate and check if Arrival then increment the counter 
        /// 3. If Departure then decrement the counter
        /// Time Complexity: O(nlogn)
        /// Space complexity: O(1)
        /// </summary>
        public static int MinPlatform(int[] arr, int[] dep, int n)
        {
            Array.Sort(arr);
            Array.Sort(dep);

            int arrivalCounter = 0;
            int departureCounter = 0;

            int minPlatform = 0;
            int count = 0; ;

            while (arrivalCounter < n)
            {
                if (arr[arrivalCounter] <= dep[departureCounter])
                {
                    count++;
                    minPlatform = Math.Max(minPlatform, count);
                    arrivalCounter++;
                }
                else if (arr[arrivalCounter] > dep[departureCounter])
                {
                    count--;
                    departureCounter++;
                }
            }

            return minPlatform;
        }

        public void Execute()
        {
            int[] arr = new int[] { 0900, 0940, 0950, 1100, 1500, 1800 };
            int[] dep = new int[] { 0910, 1200, 1120, 1130, 1900, 2000 };

            Console.WriteLine(MinPlatform(arr, dep, 6));
        }
    }
}
