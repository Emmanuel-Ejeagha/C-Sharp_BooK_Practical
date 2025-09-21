using System;

namespace Chpt17TreeAndGraph;

public class BinarySearchTree<T> where T : IComparable<T>
{
    /// <summary>Represents a binary tree node</summary>
    /// <typeparam name="T">The type of the nodes</typeparam>
    internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        public T value;
        public BinaryTreeNode<T> parent;
        public BinaryTreeNode<T> leftChild;
        public BinaryTreeNode<T> rightChild;

        public BinaryTreeNode(T value)
        {
            this.value = value;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return value.CompareTo(other.value);
        }
    }

    /// <summary>The root of the tree</summary>
    private BinaryTreeNode<T> root;

    public BinarySearchTree()
    {
        this.root = null;
    }

    public void Insert(T value)
    {
        this.root = Insert(value, null, root);
    }

    private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
    {
        if (node == null)
        {
            node = new BinaryTreeNode<T>(value);
            node.parent = parentNode;
            return node;
        }

        int compareTo = value.CompareTo(node.value);
        if (compareTo < 0)
        {
            node.leftChild = Insert(value, node, node.leftChild);
        }
        else if (compareTo > 0)
        {
            node.rightChild = Insert(value, node, node.rightChild);
        }
        // If compareTo == 0, value already exists, do nothing
        return node;
    }

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
                return node;
            }
        }
        return null;
    }

    public bool Contains(T value)
    {
        return Find(value) != null;
    }

    public void Remove(T value)
    {
        BinaryTreeNode<T> nodeToDelete = Find(value);
        if (nodeToDelete != null)
        {
            Remove(nodeToDelete);
        }
    }

    private void Remove(BinaryTreeNode<T> node)
    {
        if (node.leftChild != null && node.rightChild != null)
        {
            BinaryTreeNode<T> replacement = node.rightChild;
            while (replacement.leftChild != null)
            {
                replacement = replacement.leftChild;
            }
            node.value = replacement.value;
            Remove(replacement);
            return;
        }

        BinaryTreeNode<T> theChild = node.leftChild ?? node.rightChild;

        if (theChild != null)
        {
            theChild.parent = node.parent;
        }

        if (node.parent == null)
        {
            root = theChild;
        }
        else
        {
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

    public void PrintTreeDFS()
    {
        PrintTreeDFS(this.root);
        Console.WriteLine();
    }

    private void PrintTreeDFS(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            PrintTreeDFS(node.leftChild);
            Console.Write(node.value + " ");
            PrintTreeDFS(node.rightChild);
        }
    }
}