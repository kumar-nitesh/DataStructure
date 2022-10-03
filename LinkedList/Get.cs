namespace LinkedList
{
    public partial class LinkedList
    {
        public int Get(int index)
        {
            if (index < 0 || index > Size)
            {
                return -1;
            }

            Node current = Head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return -1;
            }

            return current.Data;
        }
    }
}