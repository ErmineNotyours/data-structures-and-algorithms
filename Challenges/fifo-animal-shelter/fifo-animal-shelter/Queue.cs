using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Queue
    {
        public static Node Head { get; set; }

        /// <summary>
        /// Sets memory location for the head.
        /// </summary>
        /// <param name="node">Incoming node at the top of the stack.</param>
        public Queue(Node node)
        {
            Head = node;
        }

        /// <summary>
        /// Traverses the list, prints all the items to the console
        /// from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        public static void PrintAllNodes()
        {
            Node cur = Head; // start of node list
                             // traverse the node
            while (cur.Next != null)
            {
                Console.WriteLine($"nameof(cur): {nameof(cur)}, cur.Name: {cur.Name}");
                cur = cur.Next; // get the next node
            }
            Console.WriteLine($"nameof(cur): {nameof(cur)}, cur.Name: {cur.Name}"); // Another call for cur.Value because the loop kicks out early
        }

        /// <summary>
        /// Adds a new node to the front of the queue and populates it with a value
        /// </summary>
        /// <param name="node">The node to be populated into to the new queue</param>
        public static void Enqueue(Node node)
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
        public static Node Dequeue()
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

        /// <summary>
        /// Traverses the list, returns the value of the oldest item without removing it.
        /// Traversal adapted from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        public Node PeekDequeue()
        {
            
            Node cur = Head; // start of node list
            // traverse the node
            while (cur.Next != null)
            {
                cur = cur.Next; // get the next node
            }
            // We have reached the front of the queue

            return cur;
           

            
        }

        /// <summary>
        /// Traverses the queue, searching for a class by the same name as preference.  Returns the node with the oldest target, or recersively calls itself if it doesn't
        /// </summary>
        /// <param name="node">Starting node to search from</param>
        /// <param name="preference">preference name</param>
        /// <returns></returns>
        public static Node Traverse(Node node, string preference)
        {
            // Need to test for node type Cat or Dog.  Use nameof(node) (C# In a Nutshell, page 95)
            Console.WriteLine($"Inside Traverse. node.Name: {node.Name}");
            if (node is preference)
            {
                return Dequeue();
            }
            else
                if (node.Next != null)
            {
                Traverse(node.Next, preference);
                return node;
            }
            else
                return null;
        }


    }

}
