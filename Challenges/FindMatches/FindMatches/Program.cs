using System;
using System.Collections.Generic;

namespace FindMatches
{
    public class Program
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

            Console.WriteLine("Find Matches on a K-ary Tree");
            Console.WriteLine();
            string target = "B";
            Console.WriteLine($"Target: {target}");

            Console.WriteLine("Found:");

            List<Node> collection = new List<Node>();
            collection = FindMatches(nodeA, target, collection);
            foreach (var c in collection)
                Console.Write(c.Value + ", ");

            Console.ReadLine();
        }

        /// <summary>
        /// Finds matches in a K-ary tree.  Most of the work is done in another method, which is called recursively.
        /// </summary>
        /// <param name="node">The head of the tree</param>
        /// <param name="target">The target to match</param>
        /// <param name="collection">The collection of found nodes.</param>
        /// <returns>A collection of the matched nodes</returns>
        public static List<Node> FindMatches(Node node, string target, List<Node> collection)
        {
            Traverse(node, target, collection);

            return collection;
        }

        /// <summary>
        /// Traverses the K-ary tree looking for matches
        /// </summary>
        /// <param name="node">The reletive head to search for</param>
        /// <param name="target">The target to match</param>
        /// <param name="collection">The collection of found nodes so far</param>
        /// <returns>A collection of the found nodes so far</returns>
        public static List<Node> Traverse(Node node, string target, List<Node> collection)
        {
            if (node == null)
                return collection;

            if (node.Value == target)
            {
                collection.Add(node);
            }

            foreach (Node x in node.Children)
            {
                if (x != null)
                {
                    collection = Traverse(x, target, collection);
                }
            }

            return collection;
        }
    }
}
