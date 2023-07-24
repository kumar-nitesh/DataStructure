/********************************************************************************************
 * Pow(x, n)
 * 
 * Source     : LeetCode
 * Difficulty : Medium
 * Problem    : https://leetcode.com/problems/powx-n/
 * Solution   : https://www.youtube.com/watch?v=_gJ3to4RyeQ
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Recursion
{
    public class Pow : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("50. Pow(x, n)");
            Console.WriteLine("Difficulty Level - MEDIUM");

            Console.WriteLine("Using Linear Exponentiation");

            Console.WriteLine(LinearExponentiation(2.00000, 10));
            Console.WriteLine(LinearExponentiation(2.10000, 3));
            Console.WriteLine(LinearExponentiation(2.00000, -2));

            Console.WriteLine("Using Binary Exponentiation");

            Console.WriteLine(BinaryExponentiation(2.00000, 10));
            Console.WriteLine(BinaryExponentiation(2.10000, 3));
            Console.WriteLine(BinaryExponentiation(2.00000, -2));
        }

        /// <summary>
        /// Linear Exponentiation
        /// Time complexity : O(log⁡n)
        /// Space complexity: O(logn)
        /// </summary>
        public double LinearExponentiation(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 1 / LinearExponentiation(x, -n);
            }

            return x * LinearExponentiation(x, n - 1);
        }

        /// <summary>
        /// Binary Exponentiation
        /// Time complexity : O(log⁡n)
        /// Space complexity: O(1)
        /// </summary>
        public double BinaryExponentiation(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 1 / BinaryExponentiation(x, -n);
            }

            if (n % 2 == 1)
            {
                return x * BinaryExponentiation(x * x, (n - 1) / 2);
            }
            else
            {
                BinaryExponentiation(x * x, (n - 1) / 2);
            }

            return x * BinaryExponentiation(x, n - 1);
        }
    }
}
