using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and populate the nodes
            Node node = new Node() { Value = 4 };
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16 };
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42, Next = null }; // Point last item on queue to null.  Necessary for passing unit tests.
            Node node7 = new Node();

            // Instatiate the queue
            MyQueue queue = new MyQueue(node);

            // Populate the queue
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);
            queue.Enqueue(node6);

            queue.PrintAllNodes(); // Print the queue before the dequeue

            node7 = queue.Dequeue();
            Console.WriteLine($"Dequed {node7.Value}");

            queue.PrintAllNodes(); // Print the queue after the dequeue

            Console.ReadLine();
        }
    }
}
