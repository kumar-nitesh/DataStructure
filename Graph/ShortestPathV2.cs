/********************************************************************************************
 * Shortest Source to Destination Path in a directed accyclic graph
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/shortest-source-to-destination-path3544/1
 * Solution   : https://www.youtube.com/watch?v=P_bfy0LOU5g
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v + e) 
 ********************************************************************************************/

namespace Graph
{
    public class ShortestPathV2 : IExecute
    {
        /// <summary>
        /// 1. Topological Sort
        /// 2. Calculate distance
        /// </summary>
        public int[] DirectedAcylicGraph(AdjacencyListWeighted weightedAdjacencyList, int noOfVertices, int source)
        {
            var stack = Sort(weightedAdjacencyList, noOfVertices);

            int[] distance = new int[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;

            while (stack.Count > 0)
            {
                int top = stack.Pop();

                if (distance[top] != int.MaxValue)
                {
                    foreach (var neighbour in weightedAdjacencyList.AdjacentListWeighted[top])
                    {
                        if (distance[top] + neighbour.Item2 < distance[neighbour.Item1])
                        {
                            distance[neighbour.Item1] = distance[top] + neighbour.Item2;
                        }
                    }
                }
            }

            return distance;
        }

        private static Stack<int> Sort(AdjacencyListWeighted weightedAdjacencyList, int noOfVertices)
        {
            bool[] visited = new bool[noOfVertices];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                {
                    TopoSort(weightedAdjacencyList, i, visited, stack);
                }
            }

            return stack;
        }

        private static void TopoSort(AdjacencyListWeighted weightedAdjacencyList, int node, bool[] visited, Stack<int> stack)
        {
            visited[node] = true;

            foreach (var neighbour in weightedAdjacencyList.AdjacentListWeighted[node])
            {
                if (!visited[neighbour.Item1])
                {
                    TopoSort(weightedAdjacencyList, neighbour.Item1, visited, stack);
                }
            }

            stack.Push(node);
        }

        public void Execute()
        {
            int noOfVertices = 6;
            AdjacencyListWeighted weightedAdjacencyList = new AdjacencyListWeighted(noOfVertices);
            weightedAdjacencyList.AddDirectedWeightedEdge(0, 1, 5);
            weightedAdjacencyList.AddDirectedWeightedEdge(0, 2, 3);
            weightedAdjacencyList.AddDirectedWeightedEdge(1, 3, 6);
            weightedAdjacencyList.AddDirectedWeightedEdge(1, 2, 2);
            weightedAdjacencyList.AddDirectedWeightedEdge(2, 4, 4);
            weightedAdjacencyList.AddDirectedWeightedEdge(2, 5, 2);
            weightedAdjacencyList.AddDirectedWeightedEdge(2, 3, 7);
            weightedAdjacencyList.AddDirectedWeightedEdge(3, 4, -1);
            weightedAdjacencyList.AddDirectedWeightedEdge(4, 5, -2);

            var result = DirectedAcylicGraph(weightedAdjacencyList, noOfVertices, 1);
            result.ToList().ForEach(Console.WriteLine);
        }
    }
}
