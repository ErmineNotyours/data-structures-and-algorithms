using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyQueue
    {
        public Node Head { get; set; }

        /// <summary>
        /// Sets memory location for the head.
        /// In another application, setting Head to null allowed for more functionality, but you can only have one queue.  The way this was constructed, you probably couldn't have another queue anyway.
        /// </summary>
        /// <param name="node">Incoming node at the top of the stack.  (No longer needed)</param>
        public MyQueue(Node node)
        {
            Head = null;
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
            // This code works fine for hard coded pushes and enqueues, but fails when code dynamically enqueues.
            Node temp = node;
            node.Next = Head; // Point new node to what the head was pointing at, now the second node.
            Head = node; // Point Head to new node

            // When this code is active and the above code is commented out, the queue test fails.  Only the first item is enqueued, and it persists after it is dequeued.
            // This makes sense, because setting the Head (the end from which it is enqueued) to null would limit the queue to just this first item.
            //if (Head == null)
            //{
            //    Head = node;
            //}
            //else
            //{
            //    Head = node; // Point Head to new node
            //    Head.Next = null; // this would spell the premature end of the queue, if other items are supposed to be behind it.
            //}
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

                Node PrevNode = new Node(); // The next to last node on the list
                Node cur = Head; // start of node list
                // traverse the node
                while (cur.Next != null)
                {
                    PrevNode = cur;
                    cur = cur.Next; // get the next node
                }
                // We have reached the dequeue end of the queue
                PrevNode.Next = null;
                return cur;
            }
            catch (Exception)
            {
                Console.WriteLine("You can't dequeue because the queue is empty.");
                return null;

            }
        }


    }
}
