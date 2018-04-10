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
                Console.WriteLine($"cur.Animal.Name: {cur.Animal.Name}"); // Runtime error: 'Object reference not set to an instance of an object.'
                cur = cur.Next; // get the next node
            }
            Console.WriteLine($"cur.Animal.Name: {cur.Animal.Name}"); // Another call because the loop kicks out early
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

                Node FrontNode = new Node(); // the node to be popped off the front of the list
                Node PrevNode = new Node(); // The next to last node on the list
                Node cur = Head; // start of node list
                                 // traverse the node
                while (cur.Next != null)
                {
                    Console.WriteLine($"Inside while cur.Nex != null. C.Animal.Name: {cur.Animal.Name}");

                    PrevNode = cur;
                    cur = cur.Next; // get the next node
                }
                // We have reached the front of the queue
                FrontNode = cur;
                cur = PrevNode;
                cur.Next = null;
                Console.WriteLine($"End of Dequeue reached, FrontNode.Animal.Name: {FrontNode.Animal.Name}"); //THIS IS NEVER REACHED!
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
        public static Node PeekDequeue()
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
            // Recursive function does not work.  Runs four times, returns Cat every time, even though there are two cats and two dogs.
            Console.WriteLine($"Inside Traverse. PeekDequeue().Animal {PeekDequeue().Animal}, PeekDequeue().Animal.Name {PeekDequeue().Animal.Name}");
            if (preference == "cat")
            {
                if (PeekDequeue().Animal is Cat)
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

            if (preference == "dog")
            {
                Console.WriteLine($"About to test if PeekDequeue().Animal is Dog: {PeekDequeue().Animal}"); // This is reached.  Cat is returned all four times.
                if (PeekDequeue().Animal is Dog)
                {
                    Console.WriteLine("About to Dequeue Dog"); // THIS IS NEVER REACHED
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
            else
                return null;
        }


    }

}
