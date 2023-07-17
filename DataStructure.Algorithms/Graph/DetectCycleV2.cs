/********************************************************************************************
 * Detect cycle in a directed graph
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/detect-cycle-in-a-directed-graph/1
 * Solution   : https://www.youtube.com/watch?v=Tl5qbEmEQyY
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class DetectCycleV2 : IExecute
    {
        private static bool CycleDetection(AdjacencyList adjacencyList, int noOfVertices)
        {
            bool[] visited = new bool[noOfVertices];
            bool[] dfsVisited = new bool[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                {
                    if (IsCyclic(adjacencyList, i, -1, visited, dfsVisited))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// Using DFS
        /// Condition - Both visited and dfsVisited are true.
        /// </summary>
        private static bool IsCyclic(AdjacencyList adjacencyList, int node, int parent, bool[] visited, bool[] dfsVisited)
        {
            visited[node] = true;
            dfsVisited[node] = true;

            foreach (int neighbour in adjacencyList.AdjacentList[node])
            {
                if (!visited[neighbour])
                {
                    if (IsCyclic(adjacencyList, neighbour, node, visited, dfsVisited))
                        return true;
                }
                else if (dfsVisited[neighbour])
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
            graph.AddDirectedEdge(0, 1);
            graph.AddDirectedEdge(0, 2);
            graph.AddDirectedEdge(1, 2);
            graph.AddDirectedEdge(2, 0);
            graph.AddDirectedEdge(2, 3);
            graph.AddDirectedEdge(3, 3);

            AdjacencyList graph2 = new AdjacencyList(3);
            graph2.AddDirectedEdge(0, 1);
            graph2.AddDirectedEdge(1, 2);

            Console.WriteLine("Detect Cycle : " + CycleDetection(graph, noOfVertices));
            Console.WriteLine("Detect Cycle : " + CycleDetection(graph2, 3));
        }
    }
}
