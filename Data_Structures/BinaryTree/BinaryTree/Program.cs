using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };
            Node node5 = new Node() { Value = 5 };
            Node node6 = new Node() { Value = 6 };
            Node node7 = new Node() { Value = 7 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            Console.WriteLine("In-order sort:");
            string InOrder = MyTree.InOrder(node1, "");
            Console.WriteLine($"Result of In order sort: {InOrder}");

            Console.WriteLine("Pre-order sort:");
            string PreOrder = MyTree.PreOrder(node1, "");
            Console.WriteLine($"Result of pre-order sort: {PreOrder}");

            Console.WriteLine("Post-order sort:");
            string PostOrder = MyTree.PostOrder(node1, "");
            Console.WriteLine($"Result of post-order sort: {PostOrder}");

            Console.ReadLine();

        }

    }
}
