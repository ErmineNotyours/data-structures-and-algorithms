using System;

namespace queue_with_stacks
{
    public class Program
    {
        static void Main(string[] args)
        {
 
            // Stack a
            Node anode = new Node() { Value = 10 };
            Node anode2 = new Node() { Value = 15 };
            Node anode3 = new Node() { Value = 20 };
            Node anodeDequeue = new Node(); // Node to dequeue onto
            Node anodeEnqueue = new Node(); // Node used to enqueue

            Stack astack = new Stack(anode);
            astack.Push(anode2);
            astack.Push(anode3);


            // Stack b
            Node bnode = new Node();
            Stack bstack = new Stack(bnode);


            astack.PrintAllNodes();
            Console.WriteLine();

            // Enqueue simulation
            // Reverse the order of a stack onto b stack
            while (anode.Next != null)
            {
                Console.WriteLine($"Traverse of a list.  Current anode: {anode.Value}");
                bstack.Push(astack.Pop());
                anode = anode.Next;
            }
            bstack.Push(astack.Pop()); //Once more to get the last item

            // Now the b stack is in reverse order from the a stack
            anodeDequeue = bstack.Pop(); // This node holds the value we're enqueing from
            Console.WriteLine($"Dequeued {anodeDequeue.Value}"); // Crashes after printing this line with value 10
            // Push b stack back onto a stack
            while (bnode.Next != null)
            {
                Console.WriteLine($"Traverse of b list. Current bnode: {bnode.Value}");
                astack.Push(bstack.Pop());
                bnode = bnode.Next;
            }
            astack.Push(astack.Pop()); // Once more to get the very last item.

            // Display the stack
            astack.PrintAllNodes();

            // Enqueue simulation
            // The code for my Enqueue method is the same as my Pop method, so...

            anodeEnqueue.Value = 5;
            astack.Push(anodeEnqueue);



            Console.ReadLine();


        }
    }

}
