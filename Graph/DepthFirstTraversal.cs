namespace Graph
{
    public class DepthFirstTraversal : IExecute
    {
        /// <summary>
        /// Time Complexity : O(V + E)
        /// Auxiliary Space:  O(V)
        /// </summary>
        /// <param name="adjacencyList"></param>
        /// <param name="noOfVertices"></param>
        public void DFS(AdjacencyList adjacencyList, int noOfVertices)
        {
            // Mark all the vertices as not visited(set as
            // false by default in java)
            bool[] visited = new bool[noOfVertices];

            // Call the recursive helper
            // function to print DFS
            // traversal starting from
            // all vertices one by one
            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                    DFSUtil(adjacencyList, i, visited);
            }
        }

        public void DFSUtil(AdjacencyList adjacencyList, int vertex, bool[] visited)
        {
            // Mark the current node as visited and print it
            visited[vertex] = true;
            Console.Write(vertex + " ");

            // Recur for all the vertices adjacent to this vertex
            for (int i = 0; i < adjacencyList.AdjacentList.Count(); i++)
            {
                if (!visited[i])
                    DFSUtil(adjacencyList, i, visited);
            }
        }

        public void Execute()
        {
            int noOfVertices = 4;
            AdjacencyList adjacencyList = new AdjacencyList(noOfVertices);
            //adjacencyList.AddEdge(0, 1);
            //adjacencyList.AddEdge(0, 2);
            //adjacencyList.AddEdge(1, 2);
            //adjacencyList.AddEdge(2, 0);
            //adjacencyList.AddEdge(2, 3);
            //adjacencyList.AddEdge(3, 3);

            adjacencyList.AddEdge(0, 1);
            adjacencyList.AddEdge(0, 2);
            adjacencyList.AddEdge(1, 3);
            adjacencyList.AddEdge(2, 3);

            Console.WriteLine("Following is Depth First Traversal");
            DFS(adjacencyList, noOfVertices);
        }
    }
}
