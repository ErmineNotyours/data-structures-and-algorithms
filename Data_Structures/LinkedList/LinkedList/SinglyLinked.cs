﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class SinglyLinked
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

        //O(1) - .Add() - adds a node to the front of the linked list
        //O(n) - .Find() - Finds a specific value in the linked list   DONE

        /// <summary>
        /// Adds a new node to the end of a linked list and populates it with a value.
        /// </summary>
        /// <param name="value">The value to be populated into the node</param>
        public void AddAtEnd(int value)
        {
            Node cur = Head; // start of node list
            Node nodeLast = new Node(); // To be a new last node on the list

            // traverse the node
            while (cur.Next != null)
            {
                cur = cur.Next; // get the next node
            }
            // Now cur is the last node on the list
            nodeLast.Next = null; // Necessary for making system know that this node exists.  Otherwise you'll get an "Object reference not set to an instance of an object" error
            cur.Next = nodeLast; // Former last node now points to new last node
            nodeLast.Value = value; // Populate last node. 
        }

        /// <summary>
        /// Adds a new node to the front of the list and populates it with a value
        /// </summary>
        /// <param name="value">The value to be populated into to the new node</param>
        public void Add(int value)
        {
            Node cur = Head; // start of node list
            Node node0 = new Node(); // To be the first node on the list

            node0.Next = cur; // Point new node to former first node
            Head = node0; // Point head to new node
            node0.Value = value; // Populate first node

        }

        /// <summary>
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
        /// finds the node query, console outputs it if it there, does nothing if it is not
        /// Adapted from https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
        /// </summary>
        public void Find(int query)
        {
            Node cur = Head; // start of node list
            // traverse the node
            while (cur.Next != null)
            {   
                if (cur.Value == query)
                    Console.WriteLine($"I found {query}!");
                cur = cur.Next; // get the next node
            }
            if (cur.Value == query) // Another call for cur.Value because the loop kicks out early
                Console.WriteLine($"I found {query}!");
        }


    }

}
