/********************************************************************************************
 * Shortest Source to Destination Path in a directed graph
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/shortest-source-to-destination-path3544/1
 * Solution   : https://www.youtube.com/watch?v=P_bfy0LOU5g
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace Graph
{
    public class ShortestPathV2 : IExecute
    {
        public List<int> DirectedAcylicGraph(AdjacencyList adjacencyList, int noOfVertices, int source, int destination)
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[noOfVertices];
            int[] parent = new int[noOfVertices];

            // BFS
            for (int i = 0; i < noOfVertices; i++)
            {
                if (!visited[i])
                    BFS(adjacencyList, i, visited, parent);
            }

            List<int> path = new List<int>();
            int currentNode = destination;
            path.Add(currentNode);

            while (currentNode != source)
            {
                currentNode = parent[currentNode];
                path.Add(currentNode);
            }

            path.Reverse();

            return path;
        }

        public void BFS(AdjacencyList adjacencyList, int vertex, bool[] visited, int[] parent)
        {
            Queue<int> queue = new Queue<int>();
            visited[vertex] = true;
            queue.Enqueue(vertex);
            parent[vertex] = -1;

            while (queue.Any())
            {
                int frontNode = queue.Peek();
                queue.Dequeue();

                foreach (var neighbour in adjacencyList.AdjacentList[frontNode])
                {
                    if (!visited[neighbour])
                    {
                        queue.Enqueue(neighbour);
                        visited[neighbour] = true;
                        parent[neighbour] = frontNode;
                    }
                }
            }
        }

        public void Execute()
        {
            int noOfVertices = 8;
            AdjacencyList adjacencyList = new AdjacencyList(noOfVertices);
            adjacencyList.AddEdge(0, 1);
            adjacencyList.AddEdge(0, 3);
            adjacencyList.AddEdge(1, 2);
            adjacencyList.AddEdge(3, 4);
            adjacencyList.AddEdge(3, 7);
            adjacencyList.AddEdge(4, 5);
            adjacencyList.AddEdge(4, 6);
            adjacencyList.AddEdge(4, 7);
            adjacencyList.AddEdge(5, 6);
            adjacencyList.AddEdge(6, 7);

            var result = UndirectedGraph(adjacencyList, noOfVertices, 0, 7);
            result.ForEach(Console.WriteLine);
            Console.WriteLine("Shortest Path : " + (result.Count - 1));
        }
    }
}
