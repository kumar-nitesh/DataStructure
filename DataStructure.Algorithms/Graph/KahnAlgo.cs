/********************************************************************************************
 * Topological sort - Using Kahn's Algo
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/topological-sort/1
 * Solution   : https://www.youtube.com/watch?v=tggiFvaxjrY
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class KahnAlgo : IExecute
    {
        /// <summary>
        /// 1. Find Indegree of each vertex.
        /// 2. Create a queue and put all vertices with indegree as 0.
        /// 3. Start traversing the graph using BFS.
        /// 4. Decrement the indegree of each vertex as traversed.
        /// </summary>
        /// <param name="adjacencyList"></param>
        /// <param name="noOfVertices"></param>
        private static List<int> Sort(AdjacencyList adjacencyList, int noOfVertices)
        {
            int[] indegree = new int[noOfVertices];
            List<int> result = new List<int>();
            int visitedVerticesCount = 0;

            // Traverse adjacency lists to fill indegrees of vertices.
            // This step takes O(V+E) time.
            for (int i = 0; i < noOfVertices; i++)
            {
                foreach (var vertex in adjacencyList.AdjacentList[i])
                {
                    indegree[vertex]++;
                }
            }

            // Create an queue and enqueue all vertices with indegree 0
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < noOfVertices; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            // Processing
            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                result.Add(vertex);

                foreach (var neighbour in adjacencyList.AdjacentList[vertex])
                {
                    indegree[neighbour]--;

                    if (indegree[neighbour] == 0)
                    {
                        queue.Enqueue(neighbour);
                    }
                }

                visitedVerticesCount++;
            }

            if (visitedVerticesCount != noOfVertices)
            {
                Console.WriteLine("There exists a cycle in the graph");
                return new List<int>();
            }

            return result;
        }

        public void Execute()
        {
            int noOfVertices = 6;
            AdjacencyList graph = new AdjacencyList(noOfVertices);
            graph.AddDirectedEdge(5, 2);
            graph.AddDirectedEdge(5, 0);
            graph.AddDirectedEdge(4, 0);
            graph.AddDirectedEdge(4, 1);
            graph.AddDirectedEdge(2, 3);
            graph.AddDirectedEdge(3, 1);

            var result = Sort(graph, noOfVertices);
            result.ForEach(Console.WriteLine);
        }
    }
}
