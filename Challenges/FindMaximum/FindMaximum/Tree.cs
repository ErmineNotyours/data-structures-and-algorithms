using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class MyTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Sets the memory location for Root
        /// </summary>
        /// <param name="node">A node for a tree</param>
        public MyTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// Performs an in-order traversal.  This method recursively calls itself.
        /// The steps for performing an in-order traversal are: (From Wikipedia)
        /// 1. Check if the current node is empty or null.
        /// 2. Traverse the left subtree by recursively calling the in-order function.
        /// 3. Display the data part of the root (or current node).
        /// 4. Traverse the right subtree by recursively calling the in-order function.
        /// </summary>
        /// <param name="node">A node from the tree</param>
        /// <param name="result">String result for unit testing</param>
        public static string InOrder(Node node, string result)
        {
            // 1. Check if the current node is empty or null
            // 2. Traverse the left subtree by recursively calling the in-order method
            if (node.LeftChild != null)
            {
                result += InOrder(node.LeftChild, result);
            }

            // 3. Display the data part of the root (or current node).
            // (Placing the print method here makes it an in-order traversal)
            Console.WriteLine(node.Value);
            result += " " + node.Value.ToString();

            // 4. Traverse the right subtree by recursively calling the in-order method.
            if (node.RightChild != null)
            {
                result += InOrder(node.RightChild, result);
            }

            return result;
        }

        /// <summary>
        /// Performs a pre-order traversal.  This method is called recursively by itself.
        /// The steps for performing a pre-order traversal are:  (From Wikipedia)
        /// 1. Check if the current node is empty or null.
        /// 2. Display the data part of the root (or current node).
        /// 3. Traverse the left subtree by recursively calling the pre-order function.
        /// 4. Traverse the right subtree by recursively calling the pre-order function.
        /// </summary>
        /// <param name="node">A node from the tree</param>
        /// <param name="result">String result for unit testing</param>
        public static string PreOrder(Node node, string result)
        {
            // 1. Check if the current node is empty or null.  (This step is performed in other steps)

            // 2. Display the data part of the root (or current node)
            // (Placing the print method here makes it a pre-order traversal)
            Console.WriteLine(node.Value);
            result += " " + node.Value.ToString();

            // 3. Traverse the left subtree by recursively calling the pre-order method.
            if (node.LeftChild != null)
            {
                result += PreOrder(node.LeftChild, result);
            }

            // 4. Traverse the right subtree by recursively calling the pre-order method.
            if (node.RightChild != null)
            {
                result += PreOrder(node.RightChild, result);
            }
            return result;
        }

        /// <summary>
        /// Performs a post-order traversal.  This method is called recursively by itself.
        /// The steps for performing a post-order traversal are: (from Wikipedia)
        /// 1. Check if the current node is empty or null.
        /// 2. Traverse the left subtree by recursively calling the post-order function.
        /// 3. Traverse the right subtree by recursively calling the post-order function.
        /// 4. Display the data part of the root (or current node).
        /// </summary>
        /// <param name="node">A node from the tree.</param>
        /// <param name="result">String result for unit testing</param>
        public static string PostOrder(Node node, string result)
        {
            // 1. Check if the current node is empty or null. (This is performed in the other steps)

            // 2. Traverse the left subtree by recursively calling the post-order method.
            if (node.LeftChild != null)
            {
                result += PostOrder(node.LeftChild, result);
            }

            // 3. Traverse the right subtree by recursively calling the post-order method.
            if (node.RightChild != null)
            {
                result += PostOrder(node.RightChild, result);
            }

            // Display the data part of the root (or current node).
            // (Placing the print method here makes it a post-order traversal.)
            Console.WriteLine(node.Value);
            result += " " + node.Value.ToString();

            return result;

        }

    }
}
