namespace BinaryTreeTest
{
    using System;

    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>>
        where T : IComparable
    {
        // Contains the value of the node
        internal T value;

        // Contains the parent of the node
        internal BinaryTreeNode<T> parent;

        // Contains the left child of the node
        internal BinaryTreeNode<T> leftChild;

        // Contains the right child of the node
        internal BinaryTreeNode<T> rightChild;

        //Constructs the tree node

        public BinaryTreeNode(T value)
        {
            this.value = value;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as BinaryTreeNode<T>;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }

        public static bool operator ==(BinaryTreeNode<T> firstNode, BinaryTreeNode<T> secondNode)
        {
            return object.Equals(firstNode, secondNode);
        }

        public static bool operator !=(BinaryTreeNode<T> firstNode, BinaryTreeNode<T> secondNode)
        {
            return !object.Equals(firstNode, secondNode);
        }
    }
}
