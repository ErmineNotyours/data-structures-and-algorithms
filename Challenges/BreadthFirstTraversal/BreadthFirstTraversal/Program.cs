using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };
            Node node5 = new Node() { Value = 5 };
            Node node6 = new Node() { Value = 6 };
            Node node7 = new Node() { Value = 7 };

            // Instantiate the tree
            MyTree tree = new MyTree(node); 

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            BreadthFirstTraversal(tree, node1);


            Console.WriteLine("End of main program.");
            Console.ReadLine();

        }

        /// <summary>
        /// Performs a breadth-first traversal of a tree.
        /// </summary>
        /// <param name="tree">Tree that we are traversing</param>
        /// <param name="node1">Explicitly include the first node from the tree because this method isn't getting it just from passing in the whole tree</param>
        static void BreadthFirstTraversal(MyTree tree, Node node1)
        {

            // The node that takes the node from the tree to the queue
            Node node = new Node();
            // The node in the queue  It's probably unnessary to have two different nodes, but it isn't working either way
            Node queueNode = new Node();

            // Instantiate the queue
            MyQueue queue = new MyQueue(queueNode);

            // Start at tree's root, seed the queue with its node
            queue.Enqueue(node1);
            // Point queueNode to the head of the queue.
            queueNode = queue.Head;


            Console.WriteLine($"Value of node in queue: {queueNode.Value}. Tree root value: {node1.Value} About to enter while loop");

            while (queueNode != null) // While queue is not empty.
            {
                // Print out the value
                Console.WriteLine(queueNode.Value);

                node = queueNode;

                // If the node has any children, put them on to the queue, in left-right order
                if (node.LeftChild != null)
                {
                    Console.WriteLine($"Enqueueing left child: {node.LeftChild.Value}");
                    queue.Enqueue(node.LeftChild);
                }
                if (node.RightChild != null)
                {
                    Console.WriteLine($"Enqueueing right child: {node.RightChild.Value}");
                    queue.Enqueue(node.RightChild);
                }

                // Dequeue the queue onto node
                queueNode = queue.Dequeue();


            }

        }

    }
}
