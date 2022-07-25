namespace LinkedList
{
    public partial class LinkedList
    {
        public void AddAtHead(int val)
        {
            Node newHead = new Node(val);
            newHead.Next = Head;

            Head = newHead;
            Size++;
        }
    }
}
