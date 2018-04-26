using System;
using System.Collections.Generic;
using System.Text;

namespace FindMatches
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
        /// Performs a breadth-first traversal of a k-ary tree.
        /// Start by enqueueing the root of the tree to a queue.
        /// Now you can loop through, dequeueing the node, then pushing the children of the dequeued nodes onto the queue.  Once the queue is empty, the traversal is over.
        /// </summary>
        /// <param name="node">The incoming tree root</param>
        public string BreadthFirst(Node node)
        {
            string progress = ""; // String collection of items traversed so far.  Used in testing.
            var q = new Queue<Node>(); // Instantiate a built-in Queue.
            q.Enqueue(node); // Enqueue the root of the tree to seed the process.

            Node SampleNode = new Node(); // Node to dequeue and use to enqueue its children.

            //While the queue is not empty...
            while (q.Count > 0)
            {
                //Dequeue a node from the queue
                SampleNode = q.Dequeue();

                //Print the node's value
                Console.Write($"{SampleNode.Value}, ");
                progress += SampleNode.Value;

                //Enqueue the child nodes, if they have any
                //Use a foreach loop
                foreach (var x in SampleNode.Children)
                    q.Enqueue(x);
            }

            return progress;
        }

        public string AddNode(Node parent, string value)
        {
            // Test to see if tree already exists?

            // Create new node
            Node node = new Node() { Value = value };

            // Link the node
            parent.Children.Add(node);

            return (node.Value);
        }

    }

}
