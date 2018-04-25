using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Queue;

namespace KeryTree
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
            Console.WriteLine("Entering BreadthFIrst");
            string progress = "";
            // Enqueue the root node onto a queue to start
            MyQueue queue = new MyQueue(node);
            queue.Enqueue(node);

            Node SampleNode = new Node();

            //While the queue is not empty...
            while (!queue.IsQueueEmpty())
            {
                //Console.WriteLine("Top of while queue not empty");
                //Dequeue a node from the queue
                SampleNode = queue.Dequeue();

                //Print the node's value
                Console.Write($"{SampleNode.Value}, ");
                progress += SampleNode.Value;

                //Enqueue the child nodes, if they have any
                //Use a foreach loop
                foreach (var x in SampleNode.Children)
                    queue.Enqueue(x);
            }

            return progress;
        }



    }
}
