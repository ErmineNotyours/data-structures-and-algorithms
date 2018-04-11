using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
{
    public class MyQueue
    {
        public Node Head { get; set; }

        /// <summary>
        /// Sets memory location for the head.
        /// </summary>
        /// <param name="node">Incoming node at the top of the stack.</param>
        public MyQueue(Node node)
        {
            Head = node;
            node.Next = null;
        }

        /// <summary>
        /// Traverses the list, prints all the items to the console
        /// from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        public void PrintAllNodes()
        {
            Node cur = Head; // start of node list
            // traverse the node
            while (cur.Next != null)
            {
                Console.WriteLine($"cur.Value: {cur.Value}");
                cur = cur.Next; // get the next node
            }
            Console.WriteLine($"cur.Value: {cur.Value}"); // Another call for cur.Value because the loop kicks out early
        }

        /// <summary>
        /// Adds a new node to the front of the queue and populates it with a value
        /// </summary>
        /// <param name="node">The node to be populated into to the new queue</param>
        public void Enqueue(Node node)
        {
            //This is the same code as Push.
            node.Next = Head; // Point new node to what the head was pointing at, now the second node.
            Head = node; // Point Head to new node

            //return value; // Only necessary for testing.  This particular data doesn't do anything.  It just writes to a list.
        }

        /// <summary>
        /// Traverses the list, removes item from the front
        /// Traversal adapted from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        public Node Dequeue()
        {
            try
            {
                if (Head == null)
                    throw new System.ArgumentException("Queue is empty");

                Node FrontNode = new Node(); // the node popped of the front of the list
                Node PrevNode = new Node(); // The next to last node on the list
                Node cur = Head; // start of node list
                // traverse the node
                while (cur.Next != null)
                {
                    Console.WriteLine($"cur.value: {cur.Value} -- Infinite loop!"); // Infinite loop
                    PrevNode = cur;
                    cur = cur.Next; // get the next node
                }
                // We have reached the front of the queue
                FrontNode = cur;
                cur = PrevNode;
                cur.Next = null;

                return FrontNode;
            }
            catch (Exception)
            {
                Console.WriteLine("You can't dequeue because the queue is empty.");
                return null;

            }
        }


    }
}
