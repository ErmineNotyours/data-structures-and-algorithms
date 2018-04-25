using System;
using System.Collections.Generic;
using System.Text;

namespace multi_bracket_validation
{
    public class Stack
    {

        public static Node Head { get; set; }

        /// <summary>
        /// Sets memory location for the head.
        /// </summary>
        /// <param name="node">Incoming node at the top of the stack.</param>
        public Stack(Node node)
        {
            Head = node;
        }

        /// <summary>
        /// Pushes a new item on the top of a stack
        /// </summary>
        /// <param name="node">The new node to be pushed</param>
        public static void Push(Node node)
        {
            node.Next = Head; // Set this node to point to what the Head was pointing at, now the second node down
            Head = node; // Point head to new node.
        }

        public static Node Peek() => Head; // Access the node at the head of the stack

        /// <summary>
        /// Pops a node off the stack and returns the result.
        /// </summary>
        /// <returns>the popped node</returns>
        public static Node Pop()
        {
            try
            {

                if (Head == null)
                    throw new System.ArgumentException("Stack is empty.");
                Node node = Head; // Set node to head
                Head = node.Next; // Set Head to next node down.  This discards reference the top node.
                Console.WriteLine($"In Pop, setting head to next node down.  Now points to {Head.Value}");
                // Does this ever empty the stack?  Does Head ever point to null?  Only in test cases.

                return node;

            }
            catch (Exception)
            {
                Console.WriteLine("You can't pop because the stack is empty.");
                return Head; // Will be Null
            }

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

    }
}
