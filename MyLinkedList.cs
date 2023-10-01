namespace LinkedList
{
    internal class MyLinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        public int Count { get; private set; }

        public void Add(T item)
        {
            Node<T>? newNode = new(item);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail!.Next = newNode;
                _tail = newNode;

            }
            ++Count;
        }

        public void RemoveItem(T item)
        {
            if (_head == null) return;

            if(EqualityComparer<T>.Default.Equals(_head.Value, item))
            {
                _head = _head.Next;
                --Count;

                if(Count == 0) _tail = null;
                return;
            }
            Node<T>? current = _head;

            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Value, item))
                {
                    if (current.Next == _tail)
                        _tail = current;
                    current.Next = current.Next.Next;
                    --Count;
                    return;
                }
                current = current.Next;
            }

        }
        public bool ContainsItem(T item)
        {
            Node<T>? current = _head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                    return true;

                current = current.Next;
            }

            return false;
        }


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
