/********************************************************************************************
 * Topological sort
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/topological-sort/1
 * Solution   : https://www.youtube.com/watch?v=T_boOrr0rvk
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace Graph
{
    public class TopologicalSortV2 : IExecute
    {
        private static void Sort(AdjacencyList adjacencyList, int noOfVertices)
        {
            bool[] visited = new bool[noOfVertices];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                {
                    TopoSort(adjacencyList, i, visited, stack);
                }
            }

            // Print contents of stack
            foreach (var vertex in stack)
            {
                Console.Write(vertex + " ");
            }
        }

        /// <summary>
        /// Using Kahn's Algorithm
        /// </summary>
        private static void TopoSort(AdjacencyList adjacencyList, int node, bool[] visited, Stack<int> stack)
        {
            visited[node] = true;

            foreach (int neighbour in adjacencyList.AdjacentList[node])
            {
                if (!visited[neighbour])
                {
                    TopoSort(adjacencyList, neighbour, visited, stack);
                }
            }

            stack.Push(node);
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

            Sort(graph, noOfVertices);
        }
    }
}
