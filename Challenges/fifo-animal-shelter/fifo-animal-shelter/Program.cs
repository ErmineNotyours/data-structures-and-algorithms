using System;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize and populate the nodes
            // If the following block is commented out, it produces the following errors in the next block: 'The name 'Mittens' does not exist in the current context', etc.  This block doesn't seem connected to anything, but it's not as superfluous as you might think.
            Cat Mittens = new Cat() { Name = "Mittens" };
            Cat Tom = new Cat() { Name = "Tom" };
            Dog Rover = new Dog() { Name = "Rover" };
            Dog Rex = new Dog() { Name = "Rex", Next = null };

            // Instantiate the shelter
            Animal AnimalShelter = new Animal();

            // Initialize and populate some more nodes
            Node cat1 = new Cat() { Animal = Mittens };
            Node cat2 = new Cat() { Animal = Tom };
            Node dog1 = new Dog() { Animal = Rover };
            Node dog2 = new Dog() { Animal = Rex, Next = null };


            // Initial Enqueue, populate the shelter (queue)
            Queue.Enqueue(cat1);
            Queue.Enqueue(cat2);
            Queue.Enqueue(dog1);
            Queue.Enqueue(dog2);


            Queue.PrintAllNodes(); //Print the queue
            string preference = "dog"; // Search for a dog
            Node animal = ShelterDequeue(preference, AnimalShelter); // Search for the preference animal, cat or dog.
            Console.WriteLine($"Congratulations!  You've just adopted a {animal.Animal} named {animal.Animal.Name}!");
            Console.WriteLine("Animal shleter after adoption:");
            Queue.PrintAllNodes(); //Print the queue
            Console.ReadLine(); // Names aren't printed, but you can still see four animals in the queue.  Dequeue isn't completely working.


        }

        // New requirement: create methods outside of Main.

        static Node ShelterDequeue(string preference, Node queue)
        {
            if (preference != "cat" && preference != "dog") // For the case when no preference is given, just dequeue the next animal
                return Queue.Dequeue();

            // traverse the queue, until the target animal is found.  Use recursion.

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
