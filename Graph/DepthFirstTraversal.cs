/********************************************************************************************
 * Detect cycle in an undirected graph
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/dfs-traversal-of-graph/1
 * Solution   : https://www.youtube.com/watch?v=b5kij1Akf9I
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

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
            foreach (var node in adjacencyList.AdjacentList[vertex])
            {
                if (!visited[node])
                    DFSUtil(adjacencyList, node, visited);
            }
        }

        public void Execute()
        {
            int noOfVertices = 5;
            AdjacencyList adjacencyList = new AdjacencyList(noOfVertices);
            adjacencyList.AddEdge(0, 2);
            adjacencyList.AddEdge(0, 3);
            adjacencyList.AddEdge(0, 1);
            adjacencyList.AddEdge(2, 4);

            Console.WriteLine("Following is Depth First Traversal");
            DFS(adjacencyList, noOfVertices);
        }
    }
}
