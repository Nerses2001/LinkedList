# LinkedList
## LinkedList Description

This repository contains a simple implementation of a linked list in C#.

## Linked List

A linked list is a data structure that represents a collection of nodes, each storing a value and a reference to the next node. The first node is called the head, and the last one is the tail. Linked lists offer efficient operations for adding, removing, and searching for elements.

## Time Complexity of Operations

- Insertion (Add): O(1) — insertion at the end of the list.
- Deletion (RemoveItem): O(n) — deletion of an element from the middle of the list (in the worst case).
- Search (ContainsItem): O(n) — searching for an element in the middle of the list (in the worst case).

## How it Works

```csharp
namespace LinkedList
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    internal class MyLinkedList<T>
    {
        // Implementation of MyLinkedList<T> goes here
        private Node<T>? _head;
        private Node<T>? _tail;
        public int Count { get; private set; }

        // ... (other methods of MyLinkedList<T>)

        public void Print()
        {
            Node<T>? currentNode = _head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
```
## Main Methods

- **Add(T item):** Adds an element to the end of the linked list.
- **RemoveItem(T item):** Removes an element from the linked list.
- **ContainsItem(T item):** Checks for the presence of an item in the linked list.
- **Print():** Prints the elements of the linked list to the console.
