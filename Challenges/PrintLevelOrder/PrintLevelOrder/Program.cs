using System;
using System.Collections.Generic;

namespace PrintLevelOrder
{
    public class Program
    {     
        public static Node Children { get; private set; }

        static void Main(string[] args)
        {
            Node node = new Node();

            // Declare and populate the nodes
            Node nodeA = new Node() { Value = "A" };
            Node nodeB = new Node() { Value = "B" };
            Node nodeC = new Node() { Value = "C" };
            Node nodeD = new Node() { Value = "D" };
            Node nodeE = new Node() { Value = "E" };
            Node nodeF = new Node() { Value = "F" };
            Node nodeG = new Node() { Value = "G" };
            Node nodeH = new Node() { Value = "H" };
            Node nodeI = new Node() { Value = "I" };
            Node nodeJ = new Node() { Value = "J" };
            Node nodeK = new Node() { Value = "K" };
            Node nodeL = new Node() { Value = "L" };
            Node nodeM = new Node() { Value = "M" };
            Node nodeN = new Node() { Value = "N" };
            Node nodeO = new Node() { Value = "O" };
            Node nodeP = new Node() { Value = "P" };
            Node nodeQ = new Node() { Value = "Q" };


            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);

            // Link the tree.
            nodeA.Children.Add(nodeB);
            nodeA.Children.Add(nodeC);
            nodeA.Children.Add(nodeD);
            nodeA.Children.Add(nodeE);
            nodeA.Children.Add(nodeF);
            nodeA.Children.Add(nodeG);


            nodeB.Children.Add(nodeH);
            nodeB.Children.Add(nodeI);
            nodeB.Children.Add(nodeJ);


            nodeE.Children.Add(nodeK);
            nodeE.Children.Add(nodeL);

            nodeG.Children.Add(nodeM);

            nodeH.Children.Add(nodeN);
            nodeH.Children.Add(nodeO);

            nodeK.Children.Add(nodeP);

            nodeL.Children.Add(nodeQ);


            PrintLevelOrder(nodeA);


            Console.ReadLine();

        }

        public static string PrintLevelOrder(Node node)
        {
            string progress = ""; // String collection of items traversed so far.  Used in testing.
            var q = new Queue<Node>(); // Instantiate a built-in Queue.
            Node flag = new Node(); // The flag that signals the new line
            flag.Value = "**NEWLINE**"; // The string that signals the new line
            q.Enqueue(node); // Enqueue the root of the tree to seed the process.
            q.Enqueue(flag); // Enqueue the new line flag

            Node SampleNode = new Node(); // Node to dequeue and use to enqueue its children.

            //While the queue is not empty...
            while (q.Count > 1) // check for > 1 to account for the flag node added
            {             
                //Dequeue a node from the queue
                SampleNode = q.Dequeue();

                progress += SampleNode.Value;

                if (SampleNode.Value == flag.Value)
                {
                    Console.WriteLine(); // New tree level, print a carriage return
                    q.Enqueue(flag); // Put a new flag on the front of the queue         
                }
                else
                {
                    //Print the node's value
                    Console.Write($"{SampleNode.Value}"); // Write the node's value, without a carriage return
                    //Enqueue the child nodes, if they have any
                    //Use a foreach loop
                    foreach (var x in SampleNode.Children)
                        q.Enqueue(x);
                }
            }

            return progress;

        }
    }
}
