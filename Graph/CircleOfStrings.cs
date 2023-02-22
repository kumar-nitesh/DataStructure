/********************************************************************************************
 * Circle of Strings
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/circle-of-strings/0
 * Solution   : https://leetcode.com/discuss/general-discussion/1297783/Circle-of-strings-oror-GRAPHS-oror-MICROSOFT-oror-EASY-oror-C%2B%2B
 * Time Complexity  : O(n)        
 * Space Complexity : O(n) 
 ********************************************************************************************/

namespace Graph
{
    public class CircleOfStrings : IExecute
    {
        /// <summary>
        /// Directed graph has eulerian circuit only if in degree and out degree of every vertex 
        /// is same, and all non-zero degree vertices form a single strongly connected component.
        /// 1. Create a directed graph of all characters
        /// 2. Find if there is an Eulerian circuit in the graph
        /// </summary>
        private bool IsCircle(string[] strings, int noOfVertices)
        {
            AdjacencyList graph = new AdjacencyList(noOfVertices);
            bool[] visited = new bool[noOfVertices];
            int[] indegree = new int[noOfVertices];
            int[] outdegree = new int[noOfVertices];

            for (int i = 0; i < strings.Length; i++)
            {
                string str = strings[i];
                int u = str[0] - 'a';
                int v = str[str.Length - 1] - 'a';

                visited[u] = true;
                visited[v] = true;
                indegree[v]++;
                outdegree[u]++;

                graph.AddEdge(u, v);
            }

            for (int i = 0; i < 26; i++)
            {
                if (indegree[i] != outdegree[i])
                {
                    return false;
                }
            }

            return IsStronglyConnected(strings[0].First() - 'a', 26, graph.AdjacentList, visited);
        }

        private static bool IsStronglyConnected(int source, int noOfVertices, LinkedList<int>[] adjacencyList, bool[] visited)
        {
            bool[] visitedVertex = new bool[noOfVertices];

            DFS(source, adjacencyList, visitedVertex);

            for (int i = 0; i < 26; i++)
            {
                if (!visitedVertex[i] && visited[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void DFS(int source, LinkedList<int>[] adjacencyList, bool[] visitedVertex)
        {
            // Mark the current node as visited and print it
            visitedVertex[source] = true;

            // Recur for all the vertices adjacent to this vertex
            for (int neighbour = 0; neighbour < adjacencyList.Count(); neighbour++)
            {
                if (!visitedVertex[neighbour])
                {
                    DFS(neighbour, adjacencyList, visitedVertex);
                }
            }
        }

        public void Execute()
        {
            string[] strings1 = { "ufiw", "jufe", "eifd", "doer" };
            Console.WriteLine(IsCircle(strings1, 26));

            string[] strings2 = { "abc", "bcd", "cdf" };
            Console.WriteLine(IsCircle(strings2, 26));

            string[] strings3 = { "ab", "bc", "cd", "da" };
            Console.WriteLine(IsCircle(strings3, 26));
        }
    }
}
