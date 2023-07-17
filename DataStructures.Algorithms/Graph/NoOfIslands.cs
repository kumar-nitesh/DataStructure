/********************************************************************************************
 * Find the number of islands
 * 
 * Source     : Leet Code
 * Difficulty : Graph - Medium
 * Problem    : https://leetcode.com/problems/number-of-islands/
 * Solution   : https://www.youtube.com/watch?v=__98uL6wst8
 * Time Complexity  : O(r * c)        
 * Space Complexity : O(r * c) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class NoOfIslands : IExecute
    {
        /// <summary>
        /// An island is surrounded by water and is formed by connecting adjacent lands 
        /// horizontally or vertically i.e., in all 4 directions
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        private static int NumberOfIslands(int[,] grid)
        {
            int numIslands = 0;
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            if (rows == 0) { return 0; }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        MarkCurrentIsland(grid, i, j, rows, cols);
                        numIslands++;
                    }
                }

            }

            return numIslands;
        }

        private static void MarkCurrentIsland(int[,] grid, int i, int j, int rows, int cols)
        {
            //Boundary case for matrix
            if (i < 0 || i >= rows || j < 0 || j >= cols || grid[i, j] != 1)
                return;

            //Mark current cell as visited
            grid[i, j] = 2;

            //Make recursive call in all 4 adjacent directions
            MarkCurrentIsland(grid, i + 1, j, rows, cols);  //DOWN
            MarkCurrentIsland(grid, i, j + 1, rows, cols);  //RIGHT
            MarkCurrentIsland(grid, i - 1, j, rows, cols);  //TOP
            MarkCurrentIsland(grid, i, j - 1, rows, cols);  //LEFT
        }

        public void Execute()
        {
            int[,] grid1 = new int[,]
            {
                { 0, 1 },
                { 1, 0 },
                { 1, 1 },
                { 1, 0 }
            };

            int[,] grid2 = new int[,]
            {
                { 1, 1, 1, 1, 0 },
                { 1, 1, 0, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

            Console.WriteLine("No. Of Islands : " + NumberOfIslands(grid1));

            Console.WriteLine("No. Of Islands : " + NumberOfIslands(grid2));
        }
    }
}
