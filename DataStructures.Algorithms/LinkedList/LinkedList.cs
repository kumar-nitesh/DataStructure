namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        public Node Head { get; set; }
        public int Size { get; set; }

        public LinkedList()
        {
            this.Size = 0;
            this.Head = null;
        }
    }
}
