using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1.ToString() };
            Node node2 = new Node() { Value = 3.ToString() };
            Node node3 = new Node() { Value = 5.ToString() };
            Node node4 = new Node() { Value = 16.ToString() };
            Node node5 = new Node() { Value = 21.ToString() };
            Node node6 = new Node() { Value = 30.ToString() };
            Node node7 = new Node() { Value = 45.ToString() };

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

            MyTree MyFizzBuzz = FizzBuzzTree(tree, node1);

            Console.WriteLine("Tree after FizzBuzz:");
            InOrder = MyTree.InOrder(node1, "");

            Console.ReadLine();
        }

        public static MyTree FizzBuzzTree(MyTree tree, Node node)
        {
            string MyFizzBuzz = MyTree.FizzBuzz(node, "");

            return tree;
        }
    }
}
