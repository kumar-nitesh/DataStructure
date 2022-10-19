/********************************************************************************************
 * Rotten Oranges
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/rotten-oranges/0
 * Solution   : 
 * 
 * Time Complexity  : O(m * n)        
 * Space complexity : O(m * n) 
 ********************************************************************************************/

namespace StacksAndQueues
{
    public class RottenOranges : IExecute
    {
        int OrangesRotting(int[][] grid)
        {
            int rows = grid.Count();
            int cols = grid[0].Count();

            Queue<int[]> queue = new Queue<int[]>();
            int freshCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        freshCount++;
                    }
                    else if (grid[i][j] == 2)
                    {
                        queue.Enqueue(new int[] { i, j });
                    }
                }
            }

            int[,] dirs = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
            int time = 0;
            while (queue.Count > 0 && freshCount > 0)
            {
                time++;
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    int[] curr = queue.Dequeue();

                    for (int j = 0; j < 4; j++)
                    {
                        int newRow = curr[0] + dirs[j, 0];
                        int newCol = curr[1] + dirs[j, 1];
                        if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && grid[newRow][newCol] == 1)
                        {
                            grid[newRow][newCol] = 2;
                            queue.Enqueue(new int[] { newRow, newCol });
                            freshCount--;
                        }
                    }
                }
            }

            return freshCount == 0 ? time : -1;
        }

        public void Execute()
        {
            int[][] arr = new int[][]
            { new int[] { 0,1,2 },
              new int[] { 0,1,2 },
              new int[] { 2,1,1 }
            };

            int ans = OrangesRotting(arr);
            if (ans == -1)
            {
                Console.WriteLine("All oranges cannot rot");
            }
            else
            {
                Console.WriteLine("Time required for all " + "oranges to rot => " + ans);
            }
        }
    }
}