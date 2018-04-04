using System;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // The shelter
            Node node = new Node() { Value = "cat", Name = "Mittens" };
            Node node2 = new Node() { Value = "cat", Name = "Tom" };
            Node node3 = new Node() { Value = "dog", Name = "Rover" };
            Node node4 = new Node() { Value = "dog", Name = "Rex", Next = null };


            Queue queue = new Queue(node);
            // Initial Enqueue
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);



            // Alternate queue, for moving animals around to find preference
            Node altNode = new Node();
            Queue altQueue = new Queue(altNode);

            // Task: use the above queue to find a dog
            // Dequeue until you find target preference.  If not found, move that animal to the altQueue.  When done, place that queue back on the main queue in reverse order, as a stack, to preserve the order.

            queue.PrintAllNodes(); //Print the queue
            string preference = "dog"; // Search for a dog
            ShelterDequeue(preference, queue); // Search for the preference animal, cat or dog.

        }

        // create methods outside of Main, where the Main methods are anonomyous.

        static void ShelterDequeue(string preference, Node queue)
        {
            Node nodeTest = new Node();
            nodeTest = queue.Dequeue();
        }
    }
}
