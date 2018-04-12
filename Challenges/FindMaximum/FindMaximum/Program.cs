using System;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = -1 };
            Node node2 = new Node() { Value = -2 };
            Node node3 = new Node() { Value = -3 };
            Node node4 = new Node() { Value = -4 };
            Node node5 = new Node() { Value = -5 };
            Node node6 = new Node() { Value = -6 };
            Node node7 = new Node() { Value = -7 };

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

            int result = FindMaximumValue(tree, node1);
            Console.WriteLine($"Maximum value is: {result}");
            Console.ReadLine();

        }

        /// <summary>
        /// Shell for finding maximum value through a recursive call in another method
        /// </summary>
        /// <param name="tree">The binary tree</param>
        /// <param name="node1">The root node of the tree</param>
        /// <returns>The highest value in the tree</returns>
        public static int FindMaximumValue(MyTree tree, Node node1)
        {
            int result = node1.Value; // Seed the test variable with a node from the tree, not zero.  This is in case all the nodes are negative numbers

            result = InOrder(node1, result); // Call the recursive function here
            return result;

        }

        /// <summary>
        /// Searches a tree in an in-order traversal, returning the highest value found.  This method recursively calls itself.
        /// </summary>
        /// <param name="node">A node from the tree</param>
        /// <param name="result">Highest number so far</param>
        /// <returns>The highest value so far</returns>
        public static int InOrder(Node node, int result)
        {
            // 1. Check if the current node is empty or null
            // 2. Traverse the left subtree by recursively calling the in-order method
            if (node.LeftChild != null)
            {
                result = InOrder(node.LeftChild, result);
            }

            // 3. Display the data part of the root (or current node).
            // (Placing the process method here makes it an in-order traversal)
            Console.WriteLine(node.Value);
            if (node.Value > result)
                result =  node.Value; // If a higher value is found, it must be the candidate highest value

            // 4. Traverse the right subtree by recursively calling the in-order method.
            if (node.RightChild != null)
            {
                result = InOrder(node.RightChild, result);
            }

            return result;
        }
    }
}
