using System;
using System.Collections.Generic;
using System.Text;

namespace llinsertions
{
    public class SinglyLinked
    {
        public Node Head { get; set; }

        /// <summary>
        /// Sets memory location value for Head
        /// </summary>
        /// <param name="node">The value as set by the caller.  Can't be changed in this object.</param>
        public SinglyLinked(Node node)
        {
            Head = node;
        }

        /// <summary>
        /// Adds a new node to the end of a linked list and populates it with a value.
        /// </summary>
        /// <param name="value">The value to be populated into the node</param>
        public int Append(int value)
        {
            Node cur = Head; // start of node list
            Node nodeLast = new Node(); // To be a new last node on the list

            // traverse the node
            while (cur.Next != null)
            {
                cur = cur.Next; // get the next node
            }
            // Now cur is the last node on the list
            nodeLast.Next = null; //  Point last node to null.  Necessary for making system know that this node exists.  Otherwise you'll get an "Object reference not set to an instance of an object" error
            cur.Next = nodeLast; // Point former last node to new last node
            nodeLast.Value = value; // Populate last node.
            return value; // Only necessary for testing.  This particular data doesn't do anything.  The method just writes to a list.

        }

        /// <summary>
        /// Adds a new node to the front of the list and populates it with a value
        /// </summary>
        /// <param name="value">The value to be populated into to the new node</param>
        public int Add(int value)
        {
            Node node0 = new Node(); // To be the first node on the list

            node0.Next = Head; // Point new node to the Head location (which is now going to be the location of the second node)
            Head = node0; // Point Head to new (first) node
            node0.Value = value; // Populate first node

            return value; // Only necessary for testing.  This particular data doesn't do anything.  The method just writes to a list.
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
        /// finds the node Value, inserts NewValue before it if it there, throws an exception if it is not
        /// Traversal adapted from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        /// <param name="Value">Value of list item to insert before</param><param name="NewValue">Value to insert in new item</param>
        public void InsertBefore(int Value, int NewValue)
        {
            try
            {

                bool found = false; // Flag stays at false if no item found.  Throws an exception if an item is never found
                Node cur = Head; // start of node list
                Node node0 = new Node(); // To be the new node on the list
                Node nodePrev = new Node(); // The previous node
                nodePrev.Next = Head; // initialize to Head for inserting in the front.
                if (cur.Value == Value) // special case for inserting before first item
                    Add(NewValue);

                // traverse the node
                while (cur.Next != null)
                {
                    if (cur.Value == Value)                
                    {
                        node0.Next = cur; // Point new node to this location, which is now going to be the location after
                        nodePrev.Next = node0; // Point previous location to new node.
                        node0.Value = NewValue; // Populate new node
                        found = true; 
                    }
                    nodePrev = cur; // make this the new previous node
                    cur = cur.Next; // get the next node
                }
                if (cur.Value == Value) // check again because loop kicks out before very last item
                {
                    node0.Next = cur; // Point new node to this location, which is now going to be the location after
                    nodePrev.Next = node0; // Point previous location to new node.
                    node0.Value = NewValue; // Populate new node
                    found = true;
                }
                if (!found)
                    throw new System.ArgumentException("Item not on the list");
            }
            catch (Exception)
            {

                Console.WriteLine("Item is not on the list.");
            }

        }


        /// <summary>
        /// finds the node Value, inserts NewValue before it if it there, does nothing if it is not
        /// Traversal adapted from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        /// <param name="Value">Value of list item to insert after</param>
        /// <param name="NewValue">New value to insert</param>
        public void InsertAfter(int Value, int NewValue)
        {
            try
            {

                bool found = false; // Flag stays at false if no items found.  Used to throw an exception.
                Node cur = Head; // start of node list
                Node node0 = new Node(); // To be the new node on the list
                Node nodeTemp = new Node(); // Temporary storage location for next node

                // traverse the node
                while (cur.Next != null)
                {
                    if (cur.Value == Value)
                    {
                        nodeTemp = cur; // Point temporary node to this location, which is going to be the location before
                        node0.Next = cur.Next; // Point new node to next node
                        nodeTemp.Next = node0; // Point current location to new node.
                        node0.Value = NewValue; // Populate new node
                        found = true;
                    }
                    cur = cur.Next; // get the next node
                }
                if (cur.Value == Value) // check again because loop kicks out before very last item
                {
                    Append(NewValue);
                    found = true;
                }
                if (!found)
                    throw new System.ArgumentException("Item not on the list");

            }
            catch (Exception)
            {

                Console.WriteLine("Item is not on the list.");
            }

        }

    }

}

