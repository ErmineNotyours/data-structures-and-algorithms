using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
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
            result += " " + node.Value;

            // 4. Traverse the right subtree by recursively calling the in-order method.
            if (node.RightChild != null)
            {
                result += InOrder(node.RightChild, result);
            }

            return result;
        }

        /// <summary>
        /// Performs BizzBuzz an in-order traversal.  This method recursively calls itself.
        /// </summary>
        /// <param name="node">A node from the tree</param>
        /// <param name="result">String result for unit testing</param>
        public static string FizzBuzz(Node node, string result)
        {
            try
            {

           
            // 1. Check if the current node is empty or null
            // 2. Traverse the left subtree by recursively calling the in-order method
            if (node.LeftChild != null)
            {
                result += FizzBuzz(node.LeftChild, result);
            }

            // 3. Process the data part of the root (or current node).
            // Because we're testing numbers and replacing the contents with strings, strings are the default type, and must be converted to int for mathematical testing.
            int test = Int32.Parse(node.Value);
            if (test % 15 == 0) // Test divisibility by 15 first for "FizzBuzz" so it won't be tested again below.
            {
                node.Value = "FizzBuzz";
            }
            else if (test % 5 == 0) // Test for divisibility by 5
            {
                node.Value = "Buzz";
            }
            else if (test % 3 == 0) // Test for divisibility by 3
            {
                node.Value = "Fizz";
            }
            result += " " + node.Value;

            // 4. Traverse the right subtree by recursively calling the in-order method.
            if (node.RightChild != null)
            {
                result += FizzBuzz(node.RightChild, result);
            }

            return result;
            }
            catch (Exception)
            {

                Console.WriteLine("Tried to reach an empty tree?");
                return "";
            }
        }

    }
}
