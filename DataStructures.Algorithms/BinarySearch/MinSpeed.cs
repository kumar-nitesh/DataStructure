/********************************************************************************************
 * Minimum Speed to Arrive on Time
 * 
 * Source     : LeetCode
 * Difficulty : Medium
 * Problem    : https://leetcode.com/problems/peak-index-in-a-mountain-array/description/
 * Solution   : https://www.youtube.com/watch?v=zD2Jg3alZV8&t=2095s
 * 
 * Time Complexity  : O(n log k)  -> n is number of rides, k is 10^7 operations.      
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.BinarySearch
{
    public class MinSpeed : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("1870. Minimum Speed to Arrive on Time\n");
            Console.WriteLine("Difficulty Level - MEDIUM\n");

            Console.WriteLine("Using Binary Search\n");
            int[] distance = new int[] { 1, 3, 2 };
            float hour = 1.9F;

            Console.WriteLine("The Peak index is : " + MinSpeedOnTime(distance, hour));
        }

        public int MinSpeedOnTime(int[] distance, double hour)
        {
            int left = 1;
            int right = 10000000;
            int minSpeed = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // Move to the left half.
                if (TimeRequired(distance, mid) <= hour)
                {
                    minSpeed = mid;
                    right = mid - 1;
                }
                else
                {
                    // Move to the right half.
                    left = mid + 1;
                }
            }
            return minSpeed;
        }

        private double TimeRequired(int[] distance, int speed)
        {
            double time = 0.0;
            for (int i = 0; i < distance.Length; i++)
            {
                double rideTime = (double)distance[i] / (double)speed;

                if (i != distance.Length - 1)
                {
                    rideTime = Math.Ceiling(rideTime);
                }

                time += rideTime;
            }

            return time;
        }

    }
}
