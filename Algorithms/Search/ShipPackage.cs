﻿namespace Algorithms.Search
{
    public class ShipPackage : IExecute
    {
        /// <summary>
        /// Greedy Technique and Binary Search Approach
        /// </summary>
        /// Time Complexity: O(n) * O(log(max-min))
        /// Auxiliary Space: O(1)
        public static int ShipWithinDays(int[] weights, int days)
        {
            int minimumWeight = weights[0];
            int maximumWeight = 0;
            int currentGuess = 0;
            int bestGuess = -1;

            for (int i = 0; i < weights.Length; i++)
            {
                if (weights[i] > minimumWeight)
                {
                    minimumWeight = weights[i];
                }

                maximumWeight += weights[i];
            }

            while (minimumWeight <= maximumWeight)
            {
                currentGuess = (maximumWeight + minimumWeight) / 2; // mid
                int noOfDays = TotalDaysToShip(weights, currentGuess);

                if (noOfDays <= days)
                {
                    bestGuess = currentGuess;
                    maximumWeight = currentGuess - 1;
                }
                else
                {
                    minimumWeight = currentGuess + 1;
                }
            }

            return bestGuess;
        }

        private static int TotalDaysToShip(int[] weights, int capacity)
        {
            int days = 1;
            int currentShip = 0;
            foreach (int weight in weights)
            {
                if (currentShip + weight > capacity)
                {
                    currentShip = 0;
                    days++;
                }
                currentShip += weight;
            }
            return days;
        }

        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("1011.  Capacity To Ship Packages Within D Days");
            Console.WriteLine("Difficulty Level - MEDIUM");

            int[] sample1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(ShipWithinDays(sample1, 5));

            int[] sample2 = new int[] { 3, 2, 2, 4, 1, 4 };
            Console.WriteLine(ShipWithinDays(sample2, 3));

            int[] sample3 = new int[] { 1, 2, 3, 1, 1 };
            Console.WriteLine(ShipWithinDays(sample3, 4));

        }
    }
}
