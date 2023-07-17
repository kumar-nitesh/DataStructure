/********************************************************************************************
 * Implementing Dijkstra Algorithm
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/implementing-dijkstra-set-1-adjacency-matrix/1
 * Solution   : https://gist.github.com/SuryaPratapK/531ec1fd8efdaeb0c098b89a7a1a9d3e
 * Time Complexity  : O(elog(v))         
 * Space Complexity : O(v + e) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    public class DijkstraAlgoV2 : IExecute
    {
        /// <summary>
        /// Type of Greedy Algorithm
        /// Using Adjacency List
        /// Time for visiting all vertices = O(V)
        /// Time required for processing one vertex = O(V)
        /// Time required for visiting and processing all the vertices = O(V) * O(V) = O(V^2)
        /// </summary>
        private static int[] Algo(LinkedList<Tuple<int, int>>[] adjacentListWeighted, int noOfVertices, int source)
        {
            int[] distance = new int[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            queue.Enqueue(0, source);

            while (queue.Count > 0)
            {
                int u = queue.Dequeue();

                foreach (var neighbour in adjacentListWeighted[u])
                {
                    var v = neighbour.Item1;
                    var w = neighbour.Item2;

                    if (distance[v] > distance[u] + w)
                    {
                        distance[v] = distance[u] + w;
                        queue.Enqueue(v, distance[v]);
                    }
                }

            }

            return distance;
        }

        public void Execute()
        {
            Graph1();
            Graph2();
        }

        private static void Graph1()
        {
            int noOfVertices = 6;

            AdjacencyListWeighted graph = new AdjacencyListWeighted(noOfVertices);
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

            graph.Print(graph);

            var result = Algo(graph.AdjacentListWeighted, 6, 0);

            Console.Write("Vertex \t\t Distance " + "from Source\n");
            for (int i = 0; i < noOfVertices; i++)
            {
                Console.Write(i + " \t\t " + result[i] + "\n");
            }
        }

        private static void Graph2()
        {
            int noOfVertices = 9;

            AdjacencyListWeighted graph = new AdjacencyListWeighted(noOfVertices);
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

            graph.Print(graph);

            var result = Algo(graph.AdjacentListWeighted, 9, 0);

            Console.Write("Vertex \t\t Distance " + "from Source\n");
            for (int i = 0; i < noOfVertices; i++)
            {
                Console.Write(i + " \t\t " + result[i] + "\n");
            }
        }
    }
}