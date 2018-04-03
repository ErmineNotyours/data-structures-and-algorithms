using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node = new Node() { Value = 4 };
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16 };
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42 };
            Node node7 = new Node();

            Queue queue = new Queue(node);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);
            queue.Enqueue(node6);

            Node snode = new Node() { Value = 4 };
            Node snode2 = new Node() { Value = 8 };
            Node snode3 = new Node() { Value = 15 };
            Node snode4 = new Node() { Value = 16 };
            Node snode5 = new Node() { Value = 23 };
            Node snode6 = new Node() { Value = 42 };
            //Node snode7 = new Node();

            Stack stack = new Stack(snode);
            stack.Push(snode2);
            stack.Push(snode3);
            stack.Push(snode4);
            stack.Push(snode5);
            stack.Push(snode6);


            //Stack stack = new Stack(snode);
            //stack.Push(node1);

            Console.WriteLine("Peek after pushes: " + stack.Peek().Value);
            stack.PrintAllNodes();
            Node snode7 = stack.Pop();
            Console.WriteLine("Popped node: " + snode7.Value);
            Console.WriteLine("Peek after pop: " + stack.Peek().Value);
            stack.PrintAllNodes();
            Console.WriteLine();

            queue.PrintAllNodes();

            node7 = queue.Dequeue();
            Console.WriteLine($"Dequed {node7.Value}");

            queue.PrintAllNodes();


            Console.ReadLine();


        }
    }
}
