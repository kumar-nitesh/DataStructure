/********************************************************************************************
 * Josephus problem.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Recursion - Easy
 * Problem    : https://practice.geeksforgeeks.org/problems/josephus-problem/1
 * Solution   : https://www.youtube.com/watch?v=dzYq5VEMZIg
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace Algorithms.Recursion
{
    public class JosephusProblem : IExecute
    {
        /// <summary>
        /// n starts with zero.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Josephus(int n, int k)
        {
            if (n == 1)
            {
                return 0;
            }

            int x = Josephus(n - 1, k);
            int y = (x + k) % n;

            return y;
        }

        /// <summary>
        /// n starts with 1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int JosephusV2(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }

            int x = JosephusV2(n - 1, k);
            int y = (x + 1) % n + 1;

            return y;
        }

        public int JosephusIterative(int n, int k)
        {
            int pos = 1;
            for (int i = 2; i <= n; i++)
            {
                pos = (pos + k - 1) % i + 1;
            }

            return pos;
        }

        public void Execute()
        {
            Console.WriteLine("The result is : " + Josephus(3, 2));
            Console.WriteLine("The result is : " + JosephusV2(3, 2));
            Console.WriteLine("The result is : " + JosephusIterative(5, 2));
        }
    }
}
