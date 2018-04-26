using System;
using System.Collections.Generic;
using System.Text;

namespace KeryTree
{
    public class MyQueue
    {
        public Node Head { get; set; }

        /// <summary>
        /// Sets memory location for the head.
        /// When Head was set to node, I was stuck on an infinite loop in traversing the queue to remove A.  By setting Head to null, you can not have more than one queue at a time.
        /// </summary>
        /// <param name="node">Incoming node at the top of the stack. (No longer needed)</param>
        public MyQueue()
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
            // When this code is active, infinite loop in Console Writeline "traversing the queue"
            // When this code is active, the head points to itself and the queue becomes looped when the queue is not populated through hard coding.
            Console.WriteLine($"Enqueueing {node.Value}"); ;
            node.Next = Head; // Point new node to what the head was pointing at, supposedly the second node; or null if this is the first enqueue
            Head = node; // Point Head to new node

            // When this code is active, the queue demonstration in the main Stack and Queue program fails.
            // Infinite loop in dequeuing node "M" in this program. 
            // By pointing Head.Next to null, it limits the queue to just the first item.  Nothing else is ever seen.
            //if (Head == null)
            //{
            //    Head = node;
            //}
            //else
            //{
            //    Head = node; // Point Head to new node
            //    Head.Next = null; // this would spell the premature end of the queue, if other items are supposed to be behind it.
            //}
        }

        /// <summary>
        /// Supposed to tell if queue is empty.  Doesn't work.  Nothing sets the Head to null when the queue is completely dequeued.
        /// </summary>
        /// <returns>boolean</returns>
        public Boolean IsQueueEmpty()
        {
            if (Head == null)
                return true;
            else
                return false;
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

                Node PrevNode = new Node(); // The next to last node checked or on the list
                Node cur = Head; // Set current node to start of list
                // traverse the node
                while (cur.Next != null)
                {
                    // Stuck in an INFINITE LOOP the third time something is dequeued.
                    // Goes like this (in BreadthFirst method): A is enqueued, then is supposedly dequeued.  The second row (A's children) is enqueued.  Then the queue is checked for dequeue again.  A is again dequeued.  (It shouldn't still be there.)  A's children are enqueued again.  A call for dequeue is made again (third time).  The queue is now traversed for the end of the queue (a pointer pointing to null) but it is never found.  It seems the queue has a circular reference (confirmed in debugging).  At least A does not show up on this traversal.  If A is successfully dequeued in the first place, this might not happen.  The problem seems to happen on an attempt to Dequeue on a queue that only has one item.
                    // I was able to run Dequeue twice, though it didn't dequeue A, so it didn't completely work.  It did detect a null those first two times, so that part works.  Perhaps the problem came from re-enqueueing duplicate nodes.
                    Console.WriteLine($"Traversing for Dequeue, cur: {cur.Value}");
                    PrevNode = cur;
                    cur = cur.Next; // get the next node
                }
                // We have reached the dequeue end of the queue

                PrevNode.Next = null; // PrevNode is now at the dequeue end of the queue, so set to null so the new end can be found.
                // TODO: Need to set Head to null if the queue is empty, or refactor IsQueueEmpty.

                Console.WriteLine($"Dequeuing {cur.Value}");
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
