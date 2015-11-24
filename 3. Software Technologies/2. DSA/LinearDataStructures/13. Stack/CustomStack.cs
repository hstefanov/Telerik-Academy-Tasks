namespace Stack
{
    using System;
    public class CustomStack<T>
    {
        private const int DefaultCapacity = 4;

        private T[] stack;

        private int top;

        public CustomStack(int capacity = DefaultCapacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException();
            }

            this.stack = new T[capacity];
            this.top = 0;
        }

        public void Push(T item)
        {
            this.stack[this.top] = item;
            this.top++;

            if (this.top >= this.stack.Length)
            {
                this.EnsureCapacity();
            }
        }

        public T Pop()
        {
            if (this.top == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }

            this.top--;
            T item = this.stack[this.top];

            return item;
        }

        public T Peek()
        {
            if (this.top == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = this.stack[this.top];
            return item;
        }

        public void Clear()
        {
            this.stack = new T[DefaultCapacity];
            this.top = 0;
        }

        public bool IsEmpty()
        {
            if (this.top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EnsureCapacity()
        {
            int newCapacity;

            if (this.stack.Length == 0)
            {
                newCapacity = DefaultCapacity;
            }
            else
            {
                newCapacity = this.stack.Length * 2;
            }

            T[] newStack = new T[newCapacity];

            for (int i = 0; i < this.stack.Length; i++)
            {
                newStack[i] = this.stack[i];
            }

            this.stack = newStack;
        }
    }
}
