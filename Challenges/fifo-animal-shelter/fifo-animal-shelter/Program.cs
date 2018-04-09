using System;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize and populate the shelter
            Cat node = new Cat() { Name = "Mittens" };
            Cat node2 = new Cat() { Name = "Tom" };
            Dog node3 = new Dog() { Name = "Rover" };
            Dog node4 = new Dog() { Name = "Rex", Next = null };

            // Instantiate the shleter
            Node AnimalShelter = new Node();

            // Initial Enqueue 
            Queue.Enqueue(node);
            Queue.Enqueue(node2);
            Queue.Enqueue(node3);
            Queue.Enqueue(node4);



            // Alternate queue, for moving animals around to find preference
            Node altNode = new Node();
            //Queue altQueue = new Queue(altNode);

            // Task: use the above queue to find a dog
            // Dequeue until you find target preference.  If not found, move that animal to the altQueue.  When done, place that queue back on the main queue in reverse order, as a stack, to preserve the order.

            Queue.PrintAllNodes(); //Print the queue
            string preference = "dog"; // Search for a dog
            Node animal = ShelterDequeue(preference, AnimalShelter); // Search for the preference animal, cat or dog.
            Console.WriteLine($"Congratulations!  You've just adopted a {animal.Value} named {animal.Name}!");
            Console.WriteLine("Animal shleter after adoption:");
            Queue.PrintAllNodes(); //Print the queue
            Console.ReadLine();


        }

        // New requirement: create methods outside of Main.

        static Node ShelterDequeue(string preference, Node queue)
        {
            if (preference != "cat" && preference != "dog") // For the case when no preference is given, just dequeue the next animal
                return Queue.Dequeue();

            // traverse the queue, until the target animal is found.  Use recursion?

            Node node = Queue.Head;

            return Queue.Traverse(node, preference);

            //Sample code for solving the problem:
            //if (preference is Dog)
            //{
            //    //Do something for dog
            //}

            //Node nodeTest = new Node();
            //nodeTest = Queue.Dequeue();
        }
    }
}
