Console.WriteLine("Linked List");

LinkedList.LinkedList obj = new LinkedList.LinkedList();

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