namespace Graph
{
    /// <summary>
    /// Adding a vertex is easier. 
    /// Computing all neighbors of a vertex takes optimal time.
    /// Queries can be done in O(V) time.
    /// </summary>
    public class AdjacencyList : IExecute
    {
        public int NoOfVertices { get; set; }

        public LinkedList<int>[] AdjacentList { get; set; }

        public AdjacencyList()
        {

        }

        public AdjacencyList(int noOfVertices)
        {
            NoOfVertices = noOfVertices;
            AdjacentList = new LinkedList<int>[noOfVertices];

            for (int i = 0; i < noOfVertices; i++)
            {
                AdjacentList[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int u, int v)
        {
            AdjacentList[u].AddLast(v);
            AdjacentList[v].AddLast(u);
        }

        public void AddDirectedEdge(int u, int v)
        {
            AdjacentList[u].AddLast(v);
        }

        public void Print(AdjacencyList adjacentList)
        {
            for (int i = 0; i < adjacentList.NoOfVertices; i++)
            {
                Console.WriteLine("Adjacency list of vertex " + i);
                Console.Write("head");

                foreach (var item in adjacentList.AdjacentList[i])
                {
                    Console.WriteLine(" -> " + item);
                }
            }
        }

        public void Execute()
        {
            AdjacencyList adjacentList = new AdjacencyList(5);

            // Adding edges one by one
            AddEdge(0, 1);
            AddEdge(0, 4);
            AddEdge(1, 2);
            AddEdge(1, 3);
            AddEdge(1, 4);
            AddEdge(2, 3);
            AddEdge(3, 4);

            Print(adjacentList);
        }
    }
}
