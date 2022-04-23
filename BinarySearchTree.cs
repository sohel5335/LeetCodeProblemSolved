using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree binary = new BinaryTree();
            var root = binary.insert(null, 35);
            binary.insert(root, 29);
            binary.insert(root, 31);
            binary.insert(root, 28);
            binary.insert(root, 40);
            binary.insert(root, 37);
            binary.insert(root, 45);
            binary.InOrder(root);

        }
    }

    class BinaryTree
    {
        public Node insert(Node root, int val)
        {
            if (root is null)
            {
                root = new Node(val);
            }
            else if (root.val < val)
            {
                if (root.right is not null)
                {
                    insert(root.right, val);
                }
                else
                {
                    root.right = new Node(val);
                }

            }
            else if (root.val > val)
            {
                if (root.left is not null)
                {
                    insert(root.left, val);
                }
                else
                {
                    root.left = new Node(val);
                }
            }
            return root;
        }
        public void InOrder(Node root)
        {
            if (root.left is not null)
                InOrder(root.left);
            Console.WriteLine(root.val);
            if (root.right is not null)
                InOrder(root.right);
        }
        public void PreOrder(Node root)
        {
            Console.WriteLine(root.val);

            if (root.left is not null)
                PreOrder(root.left);
            if (root.right is not null)
                PreOrder(root.right);
        }

        public void PostOrder(Node root)
        {
            if (root.left is not null)
                PostOrder(root.left);
            if (root.right is not null)
                PostOrder(root.right);
            Console.WriteLine(root.val);
        }

    }
    class Node
    {
        public Node left;
        public Node right;
        public int val;
        public Node(int val)
        {
            this.val = val;
        }
    }
}
