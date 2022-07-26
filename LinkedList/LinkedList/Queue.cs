namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Using the difference in node counts
        /// </summary>
        /// Time Complexity: O(m+n) 
        /// Auxiliary Space: O(1)
        public void Queue(LinkedList list)
        {

        }

        /// <summary>
        /// Method to add an key to the queue.
        /// Use Add at Tail Method.
        /// </summary>
        /// Time Complexity: O(N) 
        public void enqueue(int key)
        {
            Node newNode = new Node(key);
            Node temp = Head;

            while (temp != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            Size++;
        }


        // Method to remove an key from queue.
        public void dequeue()
        {
        }
    }
}