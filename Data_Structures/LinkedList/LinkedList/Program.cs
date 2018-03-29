using System;
using LinkedList;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = null;

            node1.Value = 2;
            //node2.Value = 3;
            node3.Value = 4;
            node4.Value = 5;

            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts there

            sll.PrintAllNodes(); // traverses the node, prints them all out

            sll.Find(3); // Traverses the node, prints out the parameter if found

            sll.Add(11); // Adds value to the start of the node.

            Console.WriteLine("Here's the list again");
            sll.PrintAllNodes(); // prints the list again to show it worked.
            Console.ReadLine();
        }


    }
}
