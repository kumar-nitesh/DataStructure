namespace DataStructures.Algorithms.LinkedList
{
    public static class SampleList
    {
        /// <summary>
        /// Solution - https://www.prepbytes.com/blog/linked-list/given-only-a-pointer-to-a-node-to-be-deleted-in-a-singly-linked-list-how-do-you-delete-it/
        /// </summary>
        public static void Operations()
        {
            Console.WriteLine("Linked List");

            LinkedList obj = new LinkedList();

            obj.AddAtHead(4);
            obj.AddAtHead(3);
            obj.AddAtHead(2);
            obj.AddAtHead(1);

            Console.WriteLine("The Size of the Linked List is : " + obj.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(obj.Get(0));
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(2));
            Console.WriteLine(obj.Get(3));

            Console.WriteLine("The Element at Index is : " + obj.Get(2));

            Console.WriteLine("******************Adding Element at Head***************");
            obj.AddAtHead(5);
            Console.WriteLine("The Size of the Linked List is : " + obj.Size);
            Console.WriteLine(obj.Get(0));
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(2));
            Console.WriteLine(obj.Get(3));
            Console.WriteLine(obj.Get(4));

            Console.WriteLine("******************Adding Element at Tail***************");
            obj.AddAtTail(6);
            Console.WriteLine("The Size of the Linked List is : " + obj.Size);
            Console.WriteLine(obj.Get(0));
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(2));
            Console.WriteLine(obj.Get(3));
            Console.WriteLine(obj.Get(4));
            Console.WriteLine(obj.Get(5));

            Console.WriteLine("******************Adding Element at Index***************");
            obj.AddAtIndex(4, 7);
            Console.WriteLine("The Size of the Linked List is : " + obj.Size);
            Console.WriteLine(obj.Get(0));
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(2));
            Console.WriteLine(obj.Get(3));
            Console.WriteLine(obj.Get(4));
            Console.WriteLine(obj.Get(5));
            Console.WriteLine(obj.Get(6));

            Console.WriteLine("******************Delete Element at Index***************");
            obj.DeleteAtIndex(2);
            Console.WriteLine("The Size of the Linked List is : " + obj.Size);
            Console.WriteLine(obj.Get(0));
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(2));
            Console.WriteLine(obj.Get(3));
            Console.WriteLine(obj.Get(4));
            Console.WriteLine(obj.Get(5));
        }

        public static void MergeSort()
        {
            Console.WriteLine("Linked List");

            LinkedList obj = new LinkedList();

            obj.AddAtHead(3);
            obj.AddAtHead(2);
            obj.AddAtHead(5);
            obj.AddAtHead(4);
            obj.AddAtHead(1);

            Console.WriteLine("The Size of the Linked List is : " + obj.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(obj.Get(0));
            Console.WriteLine(obj.Get(1));
            Console.WriteLine(obj.Get(2));
            Console.WriteLine(obj.Get(3));

            Console.WriteLine("Linked List - Merge Sort");
            var result = obj.MergeSort(obj.Head);

            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }
        }

        public static void RemoveDuplicatesSorted()
        {
            Console.WriteLine("Linked List");

            LinkedList linkedList = new LinkedList();

            linkedList.AddAtHead(4);
            linkedList.AddAtHead(4);
            linkedList.AddAtHead(2);
            linkedList.AddAtHead(2);
            linkedList.AddAtHead(1);

            Console.WriteLine("The Size of the Linked List is : " + linkedList.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedList.Get(0));
            Console.WriteLine(linkedList.Get(1));
            Console.WriteLine(linkedList.Get(2));
            Console.WriteLine(linkedList.Get(3));
            Console.WriteLine(linkedList.Get(4));

            Console.WriteLine("Linked List - Remove Duplicates from Sorted List");
            var result = linkedList.RemoveDuplicatesSorted(linkedList);

            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }
        }

        public static void RemoveDuplicatesUnsorted()
        {
            Console.WriteLine("Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(3);
            linkedlist.AddAtHead(1);
            linkedlist.AddAtHead(5);
            linkedlist.AddAtHead(5);
            linkedlist.AddAtHead(1);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - Remove Duplicates from Unsorted List");
            var result = linkedlist.RemoveDuplicatesUnsorted(linkedlist);

            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }
        }

        public static void IntersectionPoint()
        {
            Console.WriteLine("Linked List");

            LinkedList list1 = new LinkedList();
            list1.AddAtHead(4);
            list1.AddAtHead(2);
            list1.AddAtHead(1);
            list1.AddAtHead(9);
            list1.AddAtHead(1);

            Console.WriteLine("The Size of the Linked List is : " + list1.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(list1.Get(0));
            Console.WriteLine(list1.Get(1));
            Console.WriteLine(list1.Get(2));
            Console.WriteLine(list1.Get(3));
            Console.WriteLine(list1.Get(4));

            LinkedList list2 = new LinkedList();

            list2.AddAtHead(4);
            list2.AddAtHead(2);
            list2.AddAtHead(3);

            Console.WriteLine("The Size of the Linked List is : " + list2.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(list2.Get(0));
            Console.WriteLine(list2.Get(1));
            Console.WriteLine(list2.Get(2));

            Console.WriteLine("Linked List - Intersection Point");
            Console.WriteLine(list1.GetIntersectionNode(list1, list2));
        }

        public static void DetectLoop()
        {
            Console.WriteLine("Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(20);
            linkedlist.AddAtHead(4);
            linkedlist.AddAtHead(15);
            linkedlist.AddAtHead(10);

            linkedlist.Head.Next.Next.Next.Next = linkedlist.Head;

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));

            Console.WriteLine("Linked List - Detect Loop");
            Console.WriteLine(linkedlist.DetectLoop(linkedlist.Head));
        }

        public static void RemoveLoop()
        {
            Console.WriteLine("Linked List");

            LinkedList linkedlist = new LinkedList();
            linkedlist.Head = new Node(12);
            linkedlist.Head.Next = new Node(20);
            linkedlist.Head.Next.Next = new Node(35);
            linkedlist.Head.Next.Next.Next = new Node(40);
            linkedlist.Head.Next.Next.Next.Next = new Node(15);

            linkedlist.Head.Next.Next.Next.Next.Next = linkedlist.Head.Next.Next;

            Console.WriteLine("Linked List - Remove Loop");

            ////Indefinite Loop
            //while (linkedlist.Head != null)
            //{
            //    Console.WriteLine(linkedlist.Head.Data);
            //    linkedlist.Head = linkedlist.Head.Next;
            //}

            linkedlist.RemoveLoop(linkedlist.Head);

            while (linkedlist.Head != null)
            {
                Console.WriteLine(linkedlist.Head.Data);
                linkedlist.Head = linkedlist.Head.Next;
            }
        }

        public static void Reverse()
        {
            Console.WriteLine("Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(5);
            linkedlist.AddAtHead(4);
            linkedlist.AddAtHead(3);
            linkedlist.AddAtHead(2);
            linkedlist.AddAtHead(1);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - Reverse");
            var result = linkedlist.Reverse(linkedlist.Head);

            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }

            LinkedList linkedlist1 = new LinkedList();
            linkedlist1.AddAtHead(8);
            linkedlist1.AddAtHead(7);
            linkedlist1.AddAtHead(6);
            linkedlist1.AddAtHead(5);
            linkedlist1.AddAtHead(4);
            linkedlist1.AddAtHead(3);
            linkedlist1.AddAtHead(2);
            linkedlist1.AddAtHead(1);

            Console.WriteLine("Linked List - K Reverse");
            var result1 = linkedlist.KReverse(linkedlist1.Head, 3);

            while (result1 != null)
            {
                Console.WriteLine(result1.Data);
                result1 = result1.Next;
            }

            LinkedList linkedlist2 = new LinkedList();
            linkedlist2.AddAtHead(8);
            linkedlist2.AddAtHead(7);
            linkedlist2.AddAtHead(6);
            linkedlist2.AddAtHead(5);
            linkedlist2.AddAtHead(4);
            linkedlist2.AddAtHead(3);
            linkedlist2.AddAtHead(2);
            linkedlist2.AddAtHead(1);

            Console.WriteLine("Linked List - K Reverse Remaining");
            var result2 = linkedlist.KReverseV2(linkedlist2.Head, 3);

            while (result2 != null)
            {
                Console.WriteLine(result2.Data);
                result2 = result2.Next;
            }
        }

        public static void Rotate()
        {
            Console.WriteLine("Rotate a Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(9);
            linkedlist.AddAtHead(8);
            linkedlist.AddAtHead(7);
            linkedlist.AddAtHead(4);
            linkedlist.AddAtHead(2);

            LinkedList linkedlist1 = new LinkedList();

            linkedlist1.AddAtHead(2);
            linkedlist1.AddAtHead(1);
            linkedlist1.AddAtHead(0);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - Left Shift");
            var result = linkedlist.LeftShift(linkedlist.Head, 3);

            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }

            Console.WriteLine("Linked List - Right Shift");
            var result1 = linkedlist.RightShift(linkedlist1.Head, 4);

            while (result1 != null)
            {
                Console.WriteLine(result1.Data);
                result = result1.Next;
            }
        }

        public static void NthFromEnd()
        {
            Console.WriteLine("RemoveNthFromEnd in a Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(9);
            linkedlist.AddAtHead(8);
            linkedlist.AddAtHead(7);
            linkedlist.AddAtHead(4);
            linkedlist.AddAtHead(2);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - RemoveNthFromEnd");
            Console.WriteLine(linkedlist.Print(linkedlist.Head, 3));
        }

        public static void DeleteNode()
        {
            Console.WriteLine("DeleteWithoutHeadPointer in a Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(9);
            linkedlist.AddAtHead(8);
            linkedlist.AddAtHead(7);
            linkedlist.AddAtHead(4);
            linkedlist.AddAtHead(2);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - DeleteWithoutHeadPointer");
            linkedlist.DeleteNode(linkedlist.Head.Next.Next);

            while (linkedlist.Head != null)
            {
                Console.WriteLine(linkedlist.Head.Data);
                linkedlist.Head = linkedlist.Head.Next;
            }
        }

        public static void IsPalindrome()
        {
            Console.WriteLine("Palindrome in a Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(3);
            linkedlist.AddAtHead(1);
            linkedlist.AddAtHead(18);
            linkedlist.AddAtHead(1);
            linkedlist.AddAtHead(3);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - IsPalindrome");

            Console.WriteLine(linkedlist.IsPalindrome(linkedlist.Head));
        }

        public static void Flatten()
        {
            Console.WriteLine("Flatten in a Linked List");

            LinkedList flattenList = new LinkedList();
            flattenList.Head = Push(flattenList.Head, 30);
            flattenList.Head = Push(flattenList.Head, 8);
            flattenList.Head = Push(flattenList.Head, 7);
            flattenList.Head = Push(flattenList.Head, 5);
            flattenList.Head.Next = Push(flattenList.Head.Next, 20);
            flattenList.Head.Next = Push(flattenList.Head.Next, 10);
            flattenList.Head.Next.Next = Push(flattenList.Head.Next.Next, 50);
            flattenList.Head.Next.Next = Push(flattenList.Head.Next.Next, 22);
            flattenList.Head.Next.Next = Push(flattenList.Head.Next.Next, 19);

            Console.WriteLine("Linked List - Flatten");
            var result = flattenList.Flatten(flattenList.Head);

            Node temp = result;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.down;
            }

            Console.WriteLine("Linked List - Multi-Level Flatten");

            Node head1 = SetMultiLevelFlattenData();

            flattenList.MultilevelFlatten(head1);
            while (head1 != null)
            {
                Console.Write(head1.Data + " ");
                head1 = head1.Next;
            }
        }

        public static void Sort()
        {
            Console.WriteLine("Sort in a Linked List");

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddAtHead(1);
            linkedlist.AddAtHead(0);
            linkedlist.AddAtHead(1);
            linkedlist.AddAtHead(2);
            linkedlist.AddAtHead(0);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist.Get(0));
            Console.WriteLine(linkedlist.Get(1));
            Console.WriteLine(linkedlist.Get(2));
            Console.WriteLine(linkedlist.Get(3));
            Console.WriteLine(linkedlist.Get(4));

            Console.WriteLine("Linked List - Sort");

            var result = linkedlist.Sort(linkedlist.Head);

            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }

            LinkedList linkedlist1 = new LinkedList();

            linkedlist1.AddAtHead(1);
            linkedlist1.AddAtHead(2);
            linkedlist1.AddAtHead(0);
            linkedlist1.AddAtHead(1);
            linkedlist1.AddAtHead(0);

            Console.WriteLine("The Size of the Linked List is : " + linkedlist1.Size);
            Console.WriteLine("The Elements in the Linked List are : ");

            Console.WriteLine(linkedlist1.Get(0));
            Console.WriteLine(linkedlist1.Get(1));
            Console.WriteLine(linkedlist1.Get(2));
            Console.WriteLine(linkedlist1.Get(3));
            Console.WriteLine(linkedlist1.Get(4));

            Console.WriteLine("Linked List - Sort In Place");

            var result1 = linkedlist.SortInPlace(linkedlist1.Head);

            while (result1 != null)
            {
                Console.WriteLine(result1.Data);
                result1 = result1.Next;
            }
        }

        public static void AddTwoNumbers()
        {
            Console.WriteLine("Add Two Numbers in a Linked List");

            LinkedList firstList = new LinkedList();
            firstList.AddAtHead(5);
            firstList.AddAtHead(4);

            LinkedList secondList = new LinkedList();
            secondList.AddAtHead(5);
            secondList.AddAtHead(4);
            secondList.AddAtHead(3);

            Console.WriteLine("The Size of the Linked List is : " + firstList.Size);
            Console.WriteLine("The Elements in the First Linked List are : ");

            Console.WriteLine(firstList.Get(0));
            Console.WriteLine(firstList.Get(1));

            Console.WriteLine("The Size of the Linked List is : " + firstList.Size);
            Console.WriteLine("The Elements in the Second Linked List are : ");

            Console.WriteLine(secondList.Get(0));
            Console.WriteLine(secondList.Get(1));
            Console.WriteLine(secondList.Get(2));

            Console.WriteLine("The Sum of the Linked List is : " + firstList.Size);
            var result = firstList.AddTwoNumbers(firstList.Head, secondList.Head);
            Display(result);
        }

        private static void Display(Node result)
        {
            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }
        }

        private static Node Push(Node head_ref, int data)
        {
            Node new_node = new Node(data);

            new_node.down = head_ref;
            head_ref = new_node;
            return head_ref;
        }

        private static Node CreateList(int[] arr, int n)
        {
            Node node = null;
            Node p = null;

            int i;
            for (i = 0; i < n; ++i)
            {
                if (node == null)
                {
                    node = p = new Node(arr[i]);
                }
                else
                {
                    p.Next = new Node(arr[i]);
                    p = p.Next;
                }
                p.Next = p.down = null;
            }
            return node;
        }

        private static Node SetMultiLevelFlattenData()
        {
            int[] arr1 = new int[] { 10, 5, 12, 7, 11 };
            int[] arr2 = new int[] { 4, 20, 13 };
            int[] arr3 = new int[] { 17, 6 };
            int[] arr4 = new int[] { 9, 8 };
            int[] arr5 = new int[] { 19, 15 };
            int[] arr6 = new int[] { 2 };
            int[] arr7 = new int[] { 16 };
            int[] arr8 = new int[] { 3 };

            /* create 8 linked lists */
            Node head1 = CreateList(arr1, arr1.Length);
            Node head2 = CreateList(arr2, arr2.Length);
            Node head3 = CreateList(arr3, arr3.Length);
            Node head4 = CreateList(arr4, arr4.Length);
            Node head5 = CreateList(arr5, arr5.Length);
            Node head6 = CreateList(arr6, arr6.Length);
            Node head7 = CreateList(arr7, arr7.Length);
            Node head8 = CreateList(arr8, arr8.Length);

            /* modify child pointers to
            create the list shown above */
            head1.down = head2;
            head1.Next.Next.Next.down = head3;
            head3.down = head4;
            head4.down = head5;
            head2.Next.down = head6;
            head2.Next.Next.down = head7;
            head7.down = head8;
            return head1;
        }
    }
}
