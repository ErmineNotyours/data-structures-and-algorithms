using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Declare and populate the nodes
            Node snode = new Node() { Value = 4 };
            Node snode2 = new Node() { Value = 8 };
            Node snode3 = new Node() { Value = 15 };
            Node snode4 = new Node() { Value = 16 };
            Node snode5 = new Node() { Value = 23 };
            Node snode6 = new Node() { Value = 42 };

            // Instantiate the stack
            Stack stack = new Stack(snode);

            // Link the stack
            stack.Push(snode2);
            stack.Push(snode3);
            stack.Push(snode4);
            stack.Push(snode5);
            stack.Push(snode6);

            // Declare and populate the nodes
            Node node = new Node() { Value = 4 };
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16 };
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42, Next = null }; // Point last item on queue to null.  Necessary for passing unit tests and for completely dequeuing the queue.  This can't be entered when the nodes are placed in Enqueue.
            Node node7 = new Node();

            // Instantiate the queue
            MyQueue queue = new MyQueue(node);

            // Link the queue
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);
            queue.Enqueue(node6);


            Console.WriteLine("Stack demonstration.");
            Console.WriteLine("Peek after pushes: " + stack.Peek().Value);
            stack.PrintAllNodes(); // Print the stack before Pop
            Node snode7 = stack.Pop(); // Pop the stack
            Console.WriteLine("Popped node: " + snode7.Value);
            Console.WriteLine("Peek after pop: " + stack.Peek().Value);
            stack.PrintAllNodes(); // Print the stack after Pop
            Console.WriteLine();

            Console.WriteLine("Queue demonstration.");

            queue.PrintAllNodes(); // Print the queue before the dequeue

            node7 = queue.Dequeue();
            Console.WriteLine($"Dequed {node7.Value}");

            queue.PrintAllNodes(); // Print the queue after the dequeue


            Console.ReadLine();


        }
    }
}
