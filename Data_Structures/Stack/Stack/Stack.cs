using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack
    {
        public Node Head { get; set; }
        public Stack(Node node)
        {
            Head = node;
        }

        /// <summary>
        /// Pushes a new item on the top of a stack
        /// </summary>
        /// <param name="node">The new node to be pushed</param>
        public void Push(Node node)
        {
            node.Next = Head; // Set this node to point to what the Head was pointing at, now the second node down
            Head = node; // Point head to new node.
        }

        public Node Peek() => Head; // Access the node at the head of the stack

        /// <summary>
        /// Pops a node off the stack and returns the result.
        /// </summary>
        /// <returns>the popped node</returns>
        public Node Pop()
        {
            Node node = Head; // Set node to head
            Node tempNode = new Node();
            tempNode = node; // temporarily store node
            Head = node.Next; // Set Head to next node down.  This discards the top node.
            return tempNode;
            
        }
    }
}
