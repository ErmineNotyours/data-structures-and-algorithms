using System;
using llinsertions;


namespace llinsertions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Declare the nodes
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            //Node node4 = new Node();

            // Link the nodes
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = null;
           // node4.Next = null;

            // Populate the nodes
            //node1.Value = 1;
            //node2.Value = 3;
            //node3.Value = 2;
            //node4.Value = 5;

            // Instantiate the list
            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts there

            sll.PrintAllNodes(); // traverses the node, prints them all out

            //sll.InsertBefore(3, 5);
            //sll.InsertAfter(5, 5);


            int dummy = sll.Append(11); // Adds new node and value to the end of the list.

            //dummy = sll.Add(1); // Adds new node and value to the start of the list.

            Console.WriteLine("Here's the list again");
            sll.PrintAllNodes(); // prints the list again to show it worked.
            Console.ReadLine();
        }


    }
}
