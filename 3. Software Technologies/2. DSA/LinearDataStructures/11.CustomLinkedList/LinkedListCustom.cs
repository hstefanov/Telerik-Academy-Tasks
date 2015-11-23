namespace CustomLinkedList
{
    using System.Collections.Generic;
    public class LinkedListCustom<T> : ICollection<T>
    {
        public LinkedListNode<T> head { get; private set; }

        public LinkedListNode<T> tail { get; private set; }

        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            LinkedListNode<T> temp = this.head;

            this.head = node;

            this.head.Next = temp;

            if (this.Count == 0)
            {
                this.tail = this.head;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (this.Count == 0)
            {
                this.head = node;
            }
            else
            {
                this.tail.Next = node;
            }
            this.tail = node;
            this.Count++;
        }
        public void Add(T item)
        {
            this.AddLast(item);
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> currentNode = this.head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = this.head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void RemoveFirst()
        {
            if (this.Count != 0)
            {
                this.head = this.head.Next;

                this.Count--;

                if (this.Count == 0)
                {
                    this.tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (this.Count != 0)
            {
                if (this.Count == 1)
                {
                    this.head = null;
                    this.tail = null;
                }
                else
                {
                    var currentNode = this.head;
                    var tempTail = this.tail;
                    this.tail = null;
                    while (currentNode.Next != tempTail)
                    {
                        currentNode = currentNode.Next;
                    }

                    this.tail = currentNode;
                    this.tail.Next = null;
                }

                this.Count--;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = this.head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            this.tail = previous;
                        }

                        this.Count--;
                    }
                    else
                    {
                        this.RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = this.head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
