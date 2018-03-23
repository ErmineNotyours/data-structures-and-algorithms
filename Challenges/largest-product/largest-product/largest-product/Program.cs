using System;

namespace largest_product
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestProduct();
        }

        static void LargestProduct()
        {
            int[][] array = {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6 },
                new int[] { 7, 8 },
                // new int[] { 9, 10, 11, 12 },
                // new int[] { 13, 14, 15, 16 }
            }; // Jagged array style chosen because array.Length method works on it.

            int maxProd = array[0][0] * array[0][1]; // since arrays could contain all negative numbers, this avoids setting maxProd higher than the higest maximum product as it would be if set to zero, assuming array is sorted.

            // Traverse the array
            for (int row = 0; row < array.Length - 1; row++)
            {
                for (int column = 0; column < array[row].Length - 1; column++)
                {
                    int candidate = array[row][column] * array[row][column + 1]; // Compare to cell to the right
                    if (candidate > maxProd)
                    {
                        maxProd = candidate;
                    }
                    candidate = array[row][column] * array[row + 1][column]; // Compare to cell below
                    if (candidate > maxProd)
                    {
                        maxProd = candidate;
                    }
                    candidate = array[row][column] * array[row + 1][column + 1]; // Compare to cell below and to the right
                    if (candidate > maxProd)
                    {
                        maxProd = candidate;
                    }
                    candidate = array[row + 1][column] * array[row + 1][column + 1]; // Compare to cell above and to the right
                    if (candidate > maxProd)
                    {
                        maxProd = candidate;
                    }
                    candidate = array[row][column + 1] * array[row + 1][column + 1]; // Compare to cell above and to the left
                    if (candidate > maxProd)
                    {
                        maxProd = candidate;
                    }
                    Console.WriteLine($"row: {row}, column: {column}, maxProd: {maxProd}");
                }
            }

            Console.WriteLine("Original array: ");
            for (int column = 0; column < array.Length; column++)
            {
                for (int row = 0; row < array[column].Length; row++)
                {
                    Console.Write($"{array[column][row]} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine($"Largest product: {maxProd}");
            Console.Read();
        }
    }
}
