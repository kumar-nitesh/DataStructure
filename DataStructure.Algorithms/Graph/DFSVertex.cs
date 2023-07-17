namespace DataStructures.Algorithms.Graph
{
    public class DFSVertex : IExecute
    {
        /// <summary>
        /// Time Complexity : O(V + E)
        /// Auxiliary Space:  O(V)
        /// </summary>
        /// <param name="adjacencyList"></param>
        /// <param name="vertex"></param>
        /// <param name="visited"></param>
        public void DFS(AdjacencyList adjacencyList, int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            for (int i = 0; i < adjacencyList.AdjacentList.Count(); i++)
            {
                if (!visited[i])
                    DFS(adjacencyList, i, visited);
            }
        }

        public void Execute()
        {
            int noOfVertices, noOfEdges;
            Console.WriteLine("Enter Number of vertices");
            int.TryParse(Console.ReadLine(), out noOfVertices);

            Console.WriteLine("Enter Number of edges");
            int.TryParse(Console.ReadLine(), out noOfEdges);

            AdjacencyList adjacencyList = new AdjacencyList(noOfVertices);

            for (int i = 0; i < noOfEdges; i++)
            {
                int s, d;
                string[] input = Console.ReadLine().Split(' ');
                int.TryParse(input[0], out s);
                int.TryParse(input[1], out d);
                adjacencyList.AddEdge(s, d);
            }

            bool[] visited = new bool[noOfVertices];
            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                {
                    DFS(adjacencyList, 2, visited);
                }
            }
        }
    }
}
