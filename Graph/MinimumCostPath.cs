/********************************************************************************************
 * Minimum Cost Path
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Hard
 * Problem    : https://practice.geeksforgeeks.org/problems/minimum-cost-path3833/1
 * Solution   : https://www.techiedelight.com/find-minimum-cost-reach-last-cell-matrix-first-cell/
 * Time Complexity  : O(r * c)        
 * Space Complexity : O(r * c) 
 ********************************************************************************************/

namespace Graph
{
    public class MinimumCostPath : IExecute
    {
        private int MinCost(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] distance = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    distance[i, j] = matrix[i, j];

                    // fill the first row (there is only one way to reach any cell
                    // in the first row from its adjacent left cell)
                    if (i == 0 && j > 0)
                    {
                        distance[0, j] += distance[0, j - 1];
                    }

                    // fill the first column (there is only one way to reach any cell
                    // in the first column from its adjacent top cell)
                    else if (j == 0 && i > 0)
                    {
                        distance[i, 0] += distance[i - 1, 0];
                    }

                    // fill the rest with the matrix (there are two ways to reach any
                    // cell in the rest of the matrix, from its adjacent
                    // left cell or adjacent top cell)
                    else if (i > 0 && j > 0)
                    {
                        distance[i, j] += Math.Min(distance[i - 1, j], distance[i, j - 1]);
                    }
                }
            }

            return distance[rows - 1, cols - 1];
        }


        public void Execute()
        {
            int[,] matrix = new int[,]
            {
                { 4, 7, 8, 6, 4 },
                { 6, 7, 3, 9, 2 },
                { 3, 8, 1, 2, 4 },
                { 7, 1, 7, 3, 7 },
                { 2, 9, 8, 9, 3 }
            };

            Console.WriteLine("Min Cost : " + MinCost(matrix));
        }
    }
}
