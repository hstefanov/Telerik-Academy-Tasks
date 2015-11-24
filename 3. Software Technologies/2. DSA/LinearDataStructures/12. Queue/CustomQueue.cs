﻿namespace Queue
{
    using System;
    public class CustomQueue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] queue;
        private int front;
        private int rear;

        public CustomQueue(int capacity = DefaultCapacity)
        {
            this.queue = new T[capacity];
            this.front = 0;
            this.rear = 0;
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.queue.Length;
            }
        }

        public void Enqueue(T item)
        {
            if (this.front == this.rear && this.Count != 0)
            {
                this.EnsureCapacity();
            }

            this.queue[this.rear] = item;
            this.rear++;

            if (this.rear >= this.queue.Length)
            {
                this.rear = 0;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count <= 0)
            {
                throw new InvalidOperationException();
            }

            T item = this.queue[this.front];
            this.front++;

            if (this.front >= this.queue.Length)
            {
                this.front = 0;
            }

            this.Count--;

            return item;
        }

        public bool IsEmpty()
        {
            return this.Count <= 0;
        }

        private void EnsureCapacity()
        {
            int newCapacity = this.queue.Length * 2;
            int oldCount = this.Count;
            T[] newQueue = new T[newCapacity];

            int i = 0;
            while (this.Count != 0)
            {
                newQueue[i] = this.Dequeue();
                i++;
            }

            this.front = 0;
            this.rear = i;
            this.Count = oldCount;
            this.queue = newQueue;
        }
    }
}
