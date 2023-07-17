/********************************************************************************************
 * Next Greater Element.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/circular-tour-1587115620/1 
 * Solution   : https://www.youtube.com/watch?v=_gJ3to4RyeQ
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Queues
{
    public class CircularPoint : IExecute
    {
        /// <summary>
        /// Function to find starting point where the truck can start to get through
        /// the complete circle without exhausting its petrol in between.
        /// </summary>
        int Tour(int[] petrol, int[] distance)
        {
            int deficit = 0;
            int balance = 0;
            int start = 0;

            for (int i = 0; i < petrol.Length; i++)
            {
                balance = petrol[i] - distance[i];

                if (balance < 0)
                {
                    deficit += balance;
                    start = i + 1;
                    balance = 0;
                }
            }

            if (balance + deficit >= 0)
            {
                return start;
            }
            else
            {
                return -1;
            }
        }

        public void Execute()
        {
            int[] petrol = new int[] { 4, 6, 7, 4 };
            int[] distance = new int[] { 6, 5, 3, 5 };
            Console.WriteLine("Circular Point is : {0}", Tour(petrol, distance));
        }
    }
}
