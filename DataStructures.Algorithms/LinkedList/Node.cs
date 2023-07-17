namespace DataStructures.Algorithms.LinkedList
{
    public class Node
    {
        public Node? Next;
        public int Data;

        public Node down;

        public Node(int data) => this.Data = data;
    }
}
