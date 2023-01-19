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
        private int NoOfVertices { get; set; }

        private int NoOfEdges { get; set; }

        private int[,] AdjacentMatrix { get; set; }

        public AdjacencyMatrix()
        {

        }

        AdjacencyMatrix(int noOfVertices, int noOfEdges)
        {
            NoOfVertices = noOfVertices;
            NoOfEdges = noOfEdges;
            AdjacentMatrix = new int[noOfVertices + 1, noOfEdges + 1];
        }

        void AddEdge(int[,] adjMatrix, int u, int v)
        {
            adjMatrix[u, v] = 1;
            adjMatrix[v, u] = 1;
        }

        void Print(AdjacencyMatrix adjacencyMatrix)
        {
            Console.WriteLine(String.Join(" ", adjacencyMatrix.AdjacentMatrix.Cast<int>()));
        }

        public void Execute()
        {
            AdjacencyMatrix adjacencyMatrix = new AdjacencyMatrix(2, 2);

            // Adding edges one by one
            AddEdge(adjacencyMatrix.AdjacentMatrix, 0, 1);
            AddEdge(adjacencyMatrix.AdjacentMatrix, 1, 0);
            AddEdge(adjacencyMatrix.AdjacentMatrix, 2, 1);
            AddEdge(adjacencyMatrix.AdjacentMatrix, 1, 2);

            Print(adjacencyMatrix);
        }
    }
}
