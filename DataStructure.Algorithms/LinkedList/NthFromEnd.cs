namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Solution - https://www.youtube.com/watch?v=ZVtJu3DpZHU
        /// </summary>
        /// <param name="Head"></param>
        /// <returns></returns>
        public int Print(Node Head, int k)
        {
            Node slow = Head;
            Node fast = Head;

            for (int i = 0; i < k; i++)
            {
                if (fast == null)
                {
                    return -1;
                }

                fast = fast.Next;
            }

            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow.Data;
        }
    }
}
