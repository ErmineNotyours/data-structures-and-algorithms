using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node0 = new Node() { Value = 4 };

            Node node1 = new Node() { Value = 8 };


            Stack stack = new Stack(node0);
            stack.Push(node1);

            Console.WriteLine("After push: " + stack.Peek().Value);
            Node node2 = stack.Pop();
            Console.WriteLine("Popped node: " + node2.Value);
            Console.WriteLine("After pop: " + stack.Peek().Value);
            Console.ReadLine();
        }
    }
}
