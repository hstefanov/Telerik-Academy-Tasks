namespace BinaryTreeTest
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    public class BinarySearchTree<T> : IEnumerable<BinaryTreeNode<T>>, ICloneable where T : IComparable
    {
        private BinaryTreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        //Inserts new value in the binary search tree
        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentException("Cannot insert null value!");
            }
            this.root = Insert(value, null, root);
        }

        //Inserts node in the binary search tree by given value
        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node.leftChild =
                    Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild =
                    Insert(value, node, node.rightChild);
                }
            }
            return node;
        }

        //Finds a given value in the tree and returns the node
        private BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = this.root;
            while (node != null)
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo < 0)
                {
                    node = node.leftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.rightChild;
                }
                else
                {
                    break;
                }
            }
            return node;
        }

        //Removes an element from the tree if exists
        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete == null)
            {
                return;
            }
            Remove(nodeToDelete);
        }

        private void Remove(BinaryTreeNode<T> node)
        {
            // Case 3: If the node has two children.
            // Note that if we get here at the end
            // the node will be with at most one child
            if (node.leftChild != null && node.rightChild != null)
            {
                BinaryTreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }
                node.value = replacement.value;
                node = replacement;
            }
            BinaryTreeNode<T> theChild = node.leftChild != null ?
        node.leftChild : node.rightChild;
            // If the element to be deleted has one child
            if (theChild != null)
            {
                theChild.parent = node.parent;
                // Handle the case when the element is the root
                if (node.parent == null)
                {
                    root = theChild;
                }
                else
                {
                    // Replace the element with its child subtree
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = theChild;
                    }
                    else
                    {
                        node.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                // Handle the case when the element is the root
                if (node.parent == null)
                {
                    root = null;
                }
                else
                {
                    // Remove the element - it is a leaf
                    if (node.parent.leftChild == node)
                    {
                        node.parent.leftChild = null;
                    }
                    else
                    {
                        node.parent.rightChild = null;
                    }
                }
            }
        }
    }
}
