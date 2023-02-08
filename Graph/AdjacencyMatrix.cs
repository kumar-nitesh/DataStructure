/********************************************************************************************
 * Representation of a Graph - Adjacency Matrix
 ********************************************************************************************/

namespace Graph
{
    /// <summary>
    /// Removing an edge takes O(1) time.
    /// Queries can be done in O(1) time.
    /// Consumes more space O(V^2).
    /// Adding a vertex is O(V^2) time.
    /// Computing all neighbors of a vertex takes O(V) time. 
    /// </summary>
    public class AdjacencyMatrix : IExecute
    {
        public int NoOfVertices { get; set; }

        public int NoOfEdges { get; set; }

        public int[,] AdjacentMatrix { get; set; }

        public AdjacencyMatrix()
        {

        }

        public AdjacencyMatrix(int noOfVertices, int noOfEdges)
        {
            NoOfVertices = noOfVertices;
            NoOfEdges = noOfEdges;
            AdjacentMatrix = new int[noOfVertices + 1, noOfEdges + 1];
        }

        public void AddEdge(int u, int v)
        {
            AdjacentMatrix[u, v] = 1;
            AdjacentMatrix[v, u] = 1;
        }

        public void AddWeightedEdge(int u, int v, int w)
        {
            AdjacentMatrix[u, v] = w;
            AdjacentMatrix[v, u] = w;
        }

        public void Print()
        {
            int rowLength = AdjacentMatrix.GetLength(0);
            int colLength = AdjacentMatrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", AdjacentMatrix[i, j]));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void Execute()
        {
            AdjacencyMatrix adjacencyMatrix = new AdjacencyMatrix(2, 2);

            // Adding edges one by one
            adjacencyMatrix.AddEdge(0, 1);
            adjacencyMatrix.AddEdge(1, 0);
            adjacencyMatrix.AddEdge(2, 1);
            adjacencyMatrix.AddEdge(1, 2);

            Print();
        }
    }
}
