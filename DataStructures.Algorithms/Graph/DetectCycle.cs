/********************************************************************************************
 * Detect cycle in an undirected graph
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/find-the-number-of-islands/1
 * Solution   : https://www.geeksforgeeks.org/find-the-number-of-islands-using-dfs/
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class DetectCycle : IExecute
    {
        private static bool CycleDetection(AdjacencyList adjacencyList, int noOfVertices)
        {
            bool[] visited = new bool[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                {
                    if (IsCyclic(adjacencyList, i, -1, visited))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Using DFS
        /// Condition - Both visited and neighbour is not parent are true.
        /// </summary>
        private static bool IsCyclic(AdjacencyList adjacencyList, int node, int parent, bool[] visited)
        {
            visited[node] = true;

            foreach (int neighbour in adjacencyList.AdjacentList[node])
            {
                if (!visited[neighbour])
                {
                    if (IsCyclic(adjacencyList, neighbour, node, visited))
                        return true;
                }
                else if (neighbour != parent)
                {
                    return true;
                }
            }

            return false;
        }

        public void Execute()
        {
            int noOfVertices = 5;
            AdjacencyList graph = new AdjacencyList(noOfVertices);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(3, 4);

            AdjacencyList graph2 = new AdjacencyList(3);
            graph2.AddEdge(0, 1);
            graph2.AddEdge(1, 2);

            Console.WriteLine("Detect Cycle : " + CycleDetection(graph, noOfVertices));
            Console.WriteLine("Detect Cycle : " + CycleDetection(graph2, 3));
        }
    }
}
