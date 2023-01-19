namespace Graph
{
    public class Graph
    {
        private int Vertice { get; set; }

        private List<int>[] Adjacent { get; set; }

        Graph(int vertice)
        {
            Vertice = vertice;
            Adjacent = new List<int>[vertice];

            for (int i = 0; i < vertice; i++)
            {
                Adjacent[i] = new List<int>();
            }
        }

        void AddEdge(int vertice, int weight)
        {
            Adjacent[vertice].Add(weight);
        }
    }
}
