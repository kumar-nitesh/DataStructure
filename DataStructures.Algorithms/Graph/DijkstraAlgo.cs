/********************************************************************************************
 * Implementing Dijkstra Algorithm
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/implementing-dijkstra-set-1-adjacency-matrix/1
 * Solution   : https://www.youtube.com/watch?v=tggiFvaxjrY
 * Time Complexity  : O(v * v)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class DijkstraAlgo : IExecute
    {
        /// <summary>
        /// Dijkstra - The shorter path from a given node to all vertices
        /// Type of Greedy Algorithm
        /// Using Adjacency Matrix
        /// Time for visiting all vertices =O(V)
        /// Time required for processing one vertex=O(V)
        /// Time required for visiting and processing all the vertices = O(V)*O(V) =O(V^2)
        /// </summary>
        private static int[] Algo(int[,] graph, int noOfVertices, int source)
        {
            int[] distance = new int[noOfVertices];
            bool[] visitedVertex = new bool[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;

            // Find shortest path for all vertices
            // Include(V - 1) edges to cover all V vertices
            for (int i = 0; i < noOfVertices - 1; i++)
            {
                // Select best Vertex by applying greedy method
                int u = GetMinimumDistanceVertex(distance, visitedVertex, noOfVertices);

                // Mark the picked vertex as processed.
                visitedVertex[u] = true;

                // Update distance of the adjacent vertices of the picked vertex.
                for (int v = 0; v < noOfVertices; v++)
                {

                    // Edge is present from u to v
                    // Vertex v is not included in shortest path graph
                    // Edge weight is smaller than current edge weight
                    if (!visitedVertex[v] && graph[u, v] != 0
                        && distance[u] != int.MaxValue
                        && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                    }
                }
            }

            return distance;
        }

        private static int GetMinimumDistanceVertex(int[] distance, bool[] visitedVertex, int noOfVertices)
        {
            int minimum = int.MaxValue;
            int vertex = 0;

            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visitedVertex[i] && distance[i] <= minimum)
                {
                    minimum = distance[i];
                    vertex = i;
                }
            }

            return vertex;
        }

        public void Execute()
        {
            Graph1();
            Graph2();
        }

        private static void Graph1()
        {
            int noOfVertices = 5;
            int noOfEdges = 5;

            AdjacencyMatrix graph = new AdjacencyMatrix(noOfVertices, noOfEdges);
            graph.AddWeightedEdge(0, 1, 4);
            graph.AddWeightedEdge(0, 2, 5);
            graph.AddWeightedEdge(1, 0, 4);
            graph.AddWeightedEdge(1, 2, 11);
            graph.AddWeightedEdge(1, 3, 9);
            graph.AddWeightedEdge(1, 4, 7);
            graph.AddWeightedEdge(2, 0, 5);
            graph.AddWeightedEdge(2, 1, 11);
            graph.AddWeightedEdge(2, 4, 3);
            graph.AddWeightedEdge(3, 1, 9);
            graph.AddWeightedEdge(3, 4, 13);
            graph.AddWeightedEdge(3, 5, 2);
            graph.AddWeightedEdge(4, 1, 7);
            graph.AddWeightedEdge(4, 2, 3);
            graph.AddWeightedEdge(4, 3, 13);
            graph.AddWeightedEdge(4, 5, 6);
            graph.AddWeightedEdge(5, 3, 2);
            graph.AddWeightedEdge(5, 4, 6);

            graph.Print();

            var result = Algo(graph.AdjacentMatrix, 6, 0);

            Console.Write("Vertex \t\t Distance " + "from Source\n");
            for (int i = 0; i <= noOfVertices; i++)
            {
                Console.Write(i + " \t\t " + result[i] + "\n");
            }
        }

        private static void Graph2()
        {
            int noOfVertices = 8;
            int noOfEdges = 8;

            AdjacencyMatrix graph = new AdjacencyMatrix(noOfVertices, noOfEdges);
            graph.AddWeightedEdge(0, 1, 4);
            graph.AddWeightedEdge(0, 7, 8);
            graph.AddWeightedEdge(1, 2, 8);
            graph.AddWeightedEdge(1, 7, 11);
            graph.AddWeightedEdge(2, 3, 7);
            graph.AddWeightedEdge(2, 8, 2);
            graph.AddWeightedEdge(2, 5, 4);
            graph.AddWeightedEdge(3, 4, 9);
            graph.AddWeightedEdge(3, 5, 14);
            graph.AddWeightedEdge(4, 5, 10);
            graph.AddWeightedEdge(5, 6, 2);
            graph.AddWeightedEdge(6, 7, 1);
            graph.AddWeightedEdge(6, 8, 6);
            graph.AddWeightedEdge(7, 8, 7);

            graph.Print();

            var result = Algo(graph.AdjacentMatrix, 9, 0);

            Console.Write("Vertex \t\t Distance " + "from Source\n");
            for (int i = 0; i <= noOfVertices; i++)
            {
                Console.Write(i + " \t\t " + result[i] + "\n");
            }
        }
    }
}
