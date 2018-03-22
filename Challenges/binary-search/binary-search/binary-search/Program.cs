using System;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch();
        }

        static void BinarySearch()
        {
            int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 90, 99, 111, 222 };
            int key = 90; // expected output: 8 (arrays are base zero)
            int l = 0; // left side of search boundary
            int r = array.Length; // right side of search boundary
            int result = -1; // index of array with key; defalut -1 if not found

            while (l <= r)
            {
                int m = (l + r) / 2; // Center of array

                if (m >= array.Length)
                {
                    break; // index out of range
                }
                if (key == array[m])
                {
                    Console.WriteLine("key == array[m]: key:{0}, m:{1}, array[m]: {2}", key, m, array[m]);
                    result = m; // You've found the target
                    break;
                }
                else if (key < array[m])
                {
                    Console.WriteLine("key < array[m]: key:{0}, m:{1}, array[m]: {2}, r:{3}, l:{4}", key, m, array[m], r, l);
                    r = m - 1; // key must be lower than center
                }
                else
                {
                    Console.WriteLine("key > array[m]: key:{0}, m:{1}, array[m]: {2}, r:{3}, l:{4}", key, m, array[m], r, l = m + 1); // key must be higher than center
                }
            }

            Console.WriteLine("Original array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine($"Key: {key}, result: {result}");
            Console.ReadLine();

        }
    }
}