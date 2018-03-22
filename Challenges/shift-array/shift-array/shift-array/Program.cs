using System;

namespace shift_array
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertShfitArray();
        }


        static void InsertShfitArray()
        {
            int[] array = { 4, 8, 15, 23, 42 }; // Original array
            int[] newArray = new int[array.Length + 1]; //new array, with one element more than original array
            int x = 16; // number to be inserted into middle of the new array

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < (newArray.Length / 2)) // Before the middle of the array
                {
                    newArray[i] = array[i]; // Arrays are copied directly
                }
                else if (i > (newArray.Length / 2)) // After the middle of the array
                {
                    newArray[i] = array[i - 1]; // New array gets offset data from original array
                }
                else if (i == newArray.Length / 2) // The middle of the array
                {
                    newArray[i] = x;
                }
            }

            Console.WriteLine("Original array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("New number added: {0}", x);
            Console.WriteLine("");
            Console.WriteLine("New Array:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.ReadLine();

        }

    }
}