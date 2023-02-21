/********************************************************************************************
 * Snake and Ladder Problem
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/snake-and-ladder-problem4816/1
 * Solution   : https://www.youtube.com/watch?v=T_boOrr0rvk
 * Time Complexity  : O(n)        
 * Space Complexity : O(n) 
 ********************************************************************************************/

namespace Graph
{
    public class SnakeAndLadder : IExecute
    {
        /// <summary>
        /// Consider Snake and ladder board as a directed graph 
        /// with a number of vertices equal to the number of cells in the board.
        /// Then find the shortest path in a graph.[Apply BFS]
        /// </summary>
        private int MinNumberOfDiceThrows(int[] array, int N)
        {
            bool[] visitedVertex = new bool[N];
            Queue<VertexAndDistance> queue = new Queue<VertexAndDistance>();

            VertexAndDistance source = new VertexAndDistance(0, 0);
            queue.Enqueue(source);
            visitedVertex[0] = true;

            while (queue.Count > 0)
            {
                source = queue.Dequeue();
                int vertex = source.Vertex;

                // If front vertex is the destination vertex.
                if (vertex == N - 1)
                    break;

                for (int i = vertex + 1; i <= (vertex + 6) && i < N; i++)
                {
                    VertexAndDistance vertexAndDistance = new();
                    if (!visitedVertex[i])
                    {
                        vertexAndDistance.Distance = source.Distance + 1;
                        visitedVertex[i] = true;

                        if (array[i] != -1)
                        {
                            vertexAndDistance.Vertex = array[i];
                        }
                        else
                        {
                            vertexAndDistance.Vertex = i;
                        }

                        queue.Enqueue(vertexAndDistance);
                    }
                }
            }

            return source.Distance;
        }

        public void Execute()
        {
            int N = 30;
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
                array[i] = -1;

            // Ladders
            array[2] = 21;
            array[4] = 7;
            array[10] = 25;
            array[19] = 28;

            // Snakes
            array[26] = 0;
            array[20] = 8;
            array[16] = 3;
            array[18] = 6;

            Console.WriteLine("Min Dice throws required is " + MinNumberOfDiceThrows(array, N));
        }
    }

    public class VertexAndDistance
    {
        public int Vertex { get; set; }
        public int Distance { get; set; }

        public VertexAndDistance()
        {

        }

        public VertexAndDistance(int vertex, int distance)
        {
            this.Vertex = vertex;
            this.Distance = distance;
        }
    }
}
