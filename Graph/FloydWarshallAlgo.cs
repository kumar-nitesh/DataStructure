/********************************************************************************************
 * Floyd Warshall
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/implementing-floyd-warshall2042/1
 * Solution   : https://www.youtube.com/watch?v=nV_wOZnhbog
 * Time Complexity  : O(v * v * v)        
 * Space Complexity : O(1) 
 ********************************************************************************************/

namespace Graph
{
    public class FloydWarshallAlgo : IExecute
    {
        /// <summary>
        /// Flyod Warshall - The shorter path from every vertex to every other vertex
        /// Formula - Matrix[i,j]=min(Matrix[i,j],Matrix[i,k]+Matrix[k,j])
        /// </summary>
        private int[,] Algo(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    if (matrix[i, j] == -1)
                    {
                        matrix[i, j] = int.MaxValue;
                    }
                }
            }

            for (int k = 0; k < rows; ++k)
            {
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < cols; ++j)
                    {
                        if (matrix[i, k] < int.MaxValue && matrix[k, j] < int.MaxValue
                            && matrix[i, k] + matrix[k, j] < int.MaxValue)
                        {
                            matrix[i, j] = Math.Min(matrix[i, j], matrix[i, k] + matrix[k, j]);
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] >= int.MaxValue)
                    {
                        matrix[i, j] = -1;
                    }
                }

            }

            return matrix;
        }

        public void Execute()
        {
            int[,] matrix = new int[,]
            {
                {0,1,43},
                {1,0,6},
                {-1,-1,0}
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var result = Algo(matrix, rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", result[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
