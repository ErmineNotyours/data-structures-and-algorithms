using System;
using System.Collections.Generic;

namespace FindMatches
{
    class Program
    {
        public static Node Children { get; private set; }

        static void Main(string[] args)
        {

            Node node = new Node();

            // Declare and populate the nodes
            Node nodeA = new Node() { Value = "A" };
            Node nodeB = new Node() { Value = "B" };
            Node nodeC = new Node() { Value = "C" };
            Node nodeD = new Node() { Value = "D" };
            Node nodeE = new Node() { Value = "B" };
            Node nodeF = new Node() { Value = "F" };
            Node nodeG = new Node() { Value = "G" };
            Node nodeH = new Node() { Value = "H" };
            Node nodeI = new Node() { Value = "I" };
            Node nodeJ = new Node() { Value = "J" };
            Node nodeK = new Node() { Value = "B" };
            Node nodeL = new Node() { Value = "L" };
            


            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);

            // Link the tree.
            nodeA.Children.Add(nodeB);
            nodeA.Children.Add(nodeC);
            nodeA.Children.Add(nodeD);
            nodeA.Children.Add(nodeE);
            nodeA.Children.Add(nodeF);
            nodeA.Children.Add(nodeG);


            nodeB.Children.Add(nodeH);
            nodeB.Children.Add(nodeI);
            nodeB.Children.Add(nodeJ);


            nodeE.Children.Add(nodeK);
            nodeE.Children.Add(nodeL);

            string target = "B";

            List<Node> collection = new List<Node>();

            FindMatches(nodeA, target, collection);
            foreach (var c in collection)
                Console.Write(c.Value + ", ");

            Console.ReadLine();


        }

        public static string FindMatches(Node node, string target, List<Node> collection)
        {
            string progress = "";
            Traverse(node, target, collection);

            return progress;
        }

        public static List<Node> Traverse(Node node, string target, List<Node> collection)
        {
            if (node.Value == target)
            {
                Console.WriteLine($"Adding: {node.Value}");
                collection.Add(node);
            }

            foreach (var x in node.Children)
            {
                // Stack overflow.
                if (node.Children != null)
                {
                    Console.WriteLine($"About to call Traverse, node: {node.Value}"); // Only ever prints "A".
                    collection = Traverse(node.Children.x, target, collection);
                }
            }

            return collection;
        }
    }
}
