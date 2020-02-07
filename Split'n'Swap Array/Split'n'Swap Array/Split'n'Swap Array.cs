using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_n_Swap_Array
{
    class Split_n_SwapArray
    {
        static void Main(string[] args)
        {
            Split_n_SwapLinearArray();
            Split_n_SwapMatrixArray();

            Console.ReadLine();
        }

        // reads and validates array size
        static bool ReadSize(out int size)
        {
            if (int.TryParse(Console.ReadLine(), out size) && size > 1)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid size.");
                return false;
            }
        }

        // swap two parts of an array
        static void SwapArray<T>(T[] arr, int position)
        {
            T[] arr2 = new T[arr.Length];
            arr.CopyTo(arr2, 0);
            Array.Copy(arr2, position, arr, 0, arr.Length - position);
            Array.Copy(arr2, 0, arr, arr.Length - position, position);
        }

        static void Split_n_SwapLinearArray()
        {
            // read array size and split position
            Console.Write("Enter array length: ");
            if (!ReadSize(out int length)) return;
            Console.Write("Enter split position: ");
            int.TryParse(Console.ReadLine(), out int position);
            if (position < 1 || position >= length)
            {
                Console.WriteLine("Invalid position.");
                Console.ReadLine();
                return;
            }

            // generate and print the array
            Console.WriteLine("Array was:");
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(100);
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();

            // split and swap array
            SwapArray(arr, position);
            // print array
            Console.WriteLine("Array became:");
            Console.WriteLine(string.Join("\t", arr));
            Console.WriteLine();
        }

        static void Split_n_SwapMatrixArray()
        {
            // read matrix sizes and split position
            Console.Write("Enter matrix width: ");
            if (!ReadSize(out int width)) return;
            Console.Write("Enter matrix height: ");
            if (!ReadSize(out int height)) return;
            Console.Write("Split vertically? (y/n): ");
            bool vertically = "y" == Console.ReadLine();

            Console.Write("Enter split position: ");
            int.TryParse(Console.ReadLine(), out int position);
            if (position < 1 || vertically && position >= width || !vertically && position >= height)
            {
                Console.WriteLine("Invalid position.");
                Console.ReadLine();
                return;
            }

            // generate and print matrix
            Console.WriteLine("Array was:");
            int[][] arr = new int[width][];
            Random random = new Random();
            for (int i = 0; i < width; i++)
            {
                arr[i] = new int[height];
                for (int j = 0; j < height; j++)
                {
                    arr[i][j] = random.Next(100);
                    Console.Write($"{arr[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // split and swap matrix
            if (vertically)
            {
                foreach (int[] row in arr) SwapArray(row, position);
            }
            else
            {
                SwapArray(arr, position);
            }

            // print matrix
            Console.WriteLine("Array became:");
            foreach (int[] row in arr) Console.WriteLine(string.Join("\t", row));
            Console.WriteLine();
        }

    }
}
