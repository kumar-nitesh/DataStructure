/********************************************************************************************
 * Detect cycle in an undirected graph
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/bfs-traversal-of-graph/1
 * Solution   : https://www.youtube.com/watch?v=YYq38LTz774
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class BreadthFirstTraversal : IExecute
    {
        /// <summary>
        /// Time Complexity : O(V + E)
        /// Auxiliary Space:  O(V)
        /// </summary>
        /// <param name="adjacencyList"></param>
        /// <param name="noOfVertices"></param>
        public List<int> BFS(AdjacencyList adjacencyList, int noOfVertices)
        {
            // Mark all the vertices as not visited.
            bool[] visited = new bool[noOfVertices];
            List<int> bfsTraversal = new List<int>();

            // Call the recursive helper
            // function to print BFS
            // traversal starting from
            // all vertices one by one
            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                    bfsTraversal = BFSUtil(adjacencyList, i, visited, bfsTraversal);
            }

            return bfsTraversal;
        }

        public List<int> BFSUtil(AdjacencyList adjacencyList, int vertex, bool[] visited, List<int> bfsTraversal)
        {
            Queue<int> queue = new Queue<int>();
            visited[vertex] = true;
            queue.Enqueue(vertex);

            while (queue.Any())
            {
                int frontNode = queue.Peek();
                queue.Dequeue();

                bfsTraversal.Add(frontNode);

                foreach (var neighbour in adjacencyList.AdjacentList[frontNode])
                {
                    if (!visited[neighbour])
                    {
                        queue.Enqueue(neighbour);
                        visited[neighbour] = true;
                    }
                }
            }

            return bfsTraversal;
        }

        public void Execute()
        {
            int noOfVertices = 5;
            AdjacencyList adjacencyList = new AdjacencyList(noOfVertices);
            adjacencyList.AddEdge(0, 2);
            adjacencyList.AddEdge(0, 3);
            adjacencyList.AddEdge(0, 1);
            adjacencyList.AddEdge(2, 4);

            Console.WriteLine("Following is Breadth First Traversal");
            var result = BFS(adjacencyList, noOfVertices);
            result.ForEach(Console.WriteLine);
        }
    }
}
