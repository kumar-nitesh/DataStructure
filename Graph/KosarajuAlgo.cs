/********************************************************************************************
 * Strongly Connected Components (Kosaraju's Algo)
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/strongly-connected-components-kosarajus-algo/1
 * Solution   : https://www.youtube.com/watch?v=Rs6DXyWpWrI
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace Graph
{
    public class KosarajuAlgo : IExecute
    {
        /// <summary>
        /// 1. Topological Sort
        /// 2. Create Transpose
        /// 3. DFS
        /// </summary>
        /// <param name="adjacencyList"></param>
        /// <param name="noOfVertices"></param>
        private static int Algo(AdjacencyList adjacencyList, int noOfVertices)
        {
            Stack<int> stack = new Stack<int>();
            bool[] visitedVertex = new bool[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visitedVertex[i])
                {
                    TopologicalSort(adjacencyList, i, visitedVertex, stack);
                }
            }

            // Create a reversed graph
            var transpose = GetTranspose(adjacencyList, noOfVertices);

            for (int i = 0; i < noOfVertices; i++)
            {
                visitedVertex[i] = false;
            }

            int sccCount = 0;
            while (stack.Count > 0)
            {
                int vertex = stack.Pop();

                if (!visitedVertex[vertex])
                {
                    sccCount++;
                    DFS(transpose, vertex, visitedVertex);
                    Console.WriteLine();
                }
            }

            return sccCount;
        }

        private static void DFS(AdjacencyList transpose, int node, bool[] visitedVertex)
        {
            visitedVertex[node] = true;

            Console.Write(node + " ");

            foreach (var neighbour in transpose.AdjacentList[node])
            {
                if (!visitedVertex[neighbour])
                {
                    DFS(transpose, neighbour, visitedVertex);
                }
            }
        }

        private static AdjacencyList GetTranspose(AdjacencyList adjacencyList, int noOfVertices)
        {
            AdjacencyList transpose = new AdjacencyList(noOfVertices);

            for (int i = 0; i < noOfVertices; i++)
            {
                foreach (int neighbour in adjacencyList.AdjacentList[i])
                {
                    transpose.AddDirectedEdge(neighbour, i);
                }
            }

            return transpose;
        }

        private static void TopologicalSort(AdjacencyList adjacencyList, int node, bool[] visitedVertex, Stack<int> stack)
        {
            visitedVertex[node] = true;

            foreach (var neighbour in adjacencyList.AdjacentList[node])
            {
                if (!visitedVertex[neighbour])
                {
                    TopologicalSort(adjacencyList, neighbour, visitedVertex, stack);
                }
            }

            stack.Push(node);
        }

        public void Execute()
        {
            int noOfVertices = 5;
            AdjacencyList graph = new AdjacencyList(noOfVertices);
            graph.AddDirectedEdge(1, 0);
            graph.AddDirectedEdge(0, 2);
            graph.AddDirectedEdge(2, 1);
            graph.AddDirectedEdge(0, 3);
            graph.AddDirectedEdge(3, 4);

            Console.WriteLine("No. of SCC : " + Algo(graph, noOfVertices));
        }
    }
}
