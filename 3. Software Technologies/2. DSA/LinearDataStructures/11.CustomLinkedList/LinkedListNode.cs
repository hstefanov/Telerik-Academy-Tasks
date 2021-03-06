﻿namespace CustomLinkedList
{
    using System.Collections.Generic;
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }
    }
}
