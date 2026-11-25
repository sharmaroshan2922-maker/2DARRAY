using System;
namespace TwoDimensionalArray
{


    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            // Taking input
            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Displaying array
            Console.WriteLine("\n2D Array is:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}