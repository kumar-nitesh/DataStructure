/********************************************************************************************
 * Representation of a Graph - Adjacency List with Weights
 ********************************************************************************************/

namespace DataStructures.Algorithms.Graph
{
    /// <summary>
    /// Adding a vertex is easier. 
    /// Computing all neighbors of a vertex takes optimal time.
    /// Queries can be done in O(V) time.
    /// </summary>
    public class AdjacencyListWeighted : IExecute
    {
        public int NoOfVertices { get; set; }

        public LinkedList<Tuple<int, int>>[] AdjacentListWeighted { get; set; }

        public AdjacencyListWeighted()
        {

        }

        public AdjacencyListWeighted(int noOfVertices)
        {
            NoOfVertices = noOfVertices;
            AdjacentListWeighted = new LinkedList<Tuple<int, int>>[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                AdjacentListWeighted[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        public void AddWeightedEdge(int u, int v, int w)
        {
            AdjacentListWeighted[u].AddLast(Tuple.Create(v, w));
            AdjacentListWeighted[v].AddLast(Tuple.Create(u, w));
        }

        public void AddDirectedWeightedEdge(int u, int v, int w)
        {
            AdjacentListWeighted[u].AddLast(Tuple.Create(v, w));
        }

        public void Print(AdjacencyListWeighted adjacentList)
        {
            for (int i = 0; i < adjacentList.NoOfVertices; i++)
            {
                Console.WriteLine("Adjacency list of vertex " + i);
                Console.Write("head");

                foreach (var item in adjacentList.AdjacentListWeighted[i])
                {
                    Console.WriteLine(" -> " + item.Item1 + " Weight : " + item.Item2);
                }
            }
        }

        public void Execute()
        {
            int noOfVertices = 5;
            AdjacencyListWeighted adjacentList = new AdjacencyListWeighted(noOfVertices);

            // Adding edges one by one
            adjacentList.AddWeightedEdge(0, 1, 10);
            adjacentList.AddWeightedEdge(0, 4, 20);
            adjacentList.AddWeightedEdge(1, 2, 30);
            adjacentList.AddWeightedEdge(1, 3, 40);
            adjacentList.AddWeightedEdge(1, 4, 50);
            adjacentList.AddWeightedEdge(2, 3, 60);
            adjacentList.AddWeightedEdge(3, 4, 70);

            adjacentList.Print(adjacentList);
        }
    }
}
