using System;

namespace ll_find_loop
{
    using System;
    using LinkedList;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Declare the nodes
            Node anode1 = new Node();
            Node anode2 = new Node();
            Node anode3 = new Node();

            Node bnode1 = new Node();
            Node bnode2 = new Node();
            Node bnode3 = new Node();
            Node bnode4 = new Node();
            Node bnode5 = new Node();

            // Link the nodes
            anode1.Next = anode2;
            anode2.Next = anode3;
            anode3.Next = null;

            bnode1.Next = bnode2;
            bnode2.Next = bnode3;
            bnode3.Next = bnode4;
            bnode4.Next = bnode5;
            bnode5.Next = bnode2; // Circular list

            // Populate the nodes
            anode1.Value = 1;
            anode2.Value = 3;
            anode3.Value = 2;

            bnode1.Value = 1;
            bnode2.Value = 7;
            bnode3.Value = 2;
            bnode4.Value = 3;
            bnode5.Value = 5;

            // Instantiate the lists
            SinglyLinked asll = new SinglyLinked(anode1); 
            SinglyLinked bsll = new SinglyLinked(bnode1);


            Console.WriteLine("List A:");
            asll.PrintAllNodes(); // traverses the node, prints them all out

            Console.WriteLine("List B:");
            Console.WriteLine("Infinite loop!");
            //bsll.PrintAllNodes(); // Infinite loop!

            Console.WriteLine();

            Console.WriteLine($"List A is a loop? {asll.hasLoop()}");
            Console.WriteLine($"List B is a loop? {bsll.hasLoop()}");

            //sll.Find(3); // Traverses the node, prints out the parameter if found

            //int dummy = sll.AddAtEnd(11); // Adds new node and value to the end of the list.

            //dummy = sll.Add(1); // Adds new node and value to the start of the list.

            //Console.WriteLine("Here's the list again");
            //sll.PrintAllNodes(); // prints the list again to show it worked.
            //Console.ReadLine();
        }


    }
}

