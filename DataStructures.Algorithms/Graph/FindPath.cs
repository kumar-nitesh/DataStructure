/********************************************************************************************
 * Find whether path exist
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/find-whether-path-exist5238/1
 * Solution   : 
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class FindPath : IExecute
    {
        /// <summary>
        /// 1. Find Source
        /// 2. BFS Traversal
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private bool PathExists(int[,] matrix)
        {
            Queue<BFSElement> queue = new Queue<BFSElement>();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            //1. Find Source
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        queue.Enqueue(new BFSElement(i, j));
                        break;
                    }
                }
            }

            while (queue.Count > 0)
            {
                var front = queue.Dequeue();

                int x = front.i;
                int y = front.j;

                if (x < 0 || x >= rows || y < 0 || y >= cols)
                    continue;

                if (matrix[x, y] == 0)
                    continue;

                if (matrix[x, y] == 2)
                    return true;

                matrix[x, y] = 0;

                queue.Enqueue(new BFSElement(x + 1, y));
                queue.Enqueue(new BFSElement(x - 1, y));
                queue.Enqueue(new BFSElement(x, y + 1));
                queue.Enqueue(new BFSElement(x, y - 1));
            }

            return false;
        }


        public void Execute()
        {
            int[,] matrix = new int[,]
            {
                { 0, 3, 0, 1 },
                { 3, 0, 3, 3 },
                { 2, 3, 3, 3 },
                { 0, 3, 3, 3 }
            };

            Console.WriteLine("Path Exists : " + PathExists(matrix));

            int[,] matrix2 = new int[,]
            {
                { 3,0,3,0,0 },
                { 3,0,0,0,3 },
                { 3,3,3,3,3 },
                { 0,2,3,0,0 },
                { 3,0,0,1,3 }
            };

            Console.WriteLine("Path Exists : " + PathExists(matrix2));
        }
    }

    public class BFSElement
    {
        public int i { get; set; }

        public int j { get; set; }

        public BFSElement(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
}
