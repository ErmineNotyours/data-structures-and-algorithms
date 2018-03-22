using System;

namespace reverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
        }

        static void ReverseString()
        {
            int[] array = { 7, 6, 5, 4, 3, 2, 1 }; // Data set
            int[] newArray = new int[array.Length];
            int arrayLength = array.Length;

            for (int i = 0; i < (arrayLength); i++)
            {

                newArray[arrayLength - i - 1] = array[i]; // Populate newArray with data in the reverse order from array

            }

            Console.WriteLine("Old array: ");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("New array: ");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.Read();
        }

    }


}