using LinkedList;

MyLinkedList<int> myLinkedList = new();
myLinkedList.Add(18);
myLinkedList.Add(26);
myLinkedList.Add(35);

myLinkedList.Print();

Console.WriteLine(myLinkedList.ContainsItem(2));
Console.WriteLine(myLinkedList.ContainsItem(35));

myLinkedList.RemoveItem(35);

myLinkedList.Print();