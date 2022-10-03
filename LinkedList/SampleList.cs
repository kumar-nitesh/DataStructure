namespace LinkedList
{
    public static class SampleList
    {
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

            while (result != null)
            {
                Console.WriteLine(result1.Data);
                result = result1.Next;
            }
        }
    }
}
