using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region one-dimensional Array
            Console.Write("one-dimensional array \n");
            int[] intArray = new int[] { 10, 20, 4 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(" " + intArray[i]);
            }
            Console.Write("\n\n");
            #endregion one-dimensional Array

            #region Two-dimensional array
            Console.Write("Two-dimensional array \n");

            int[,] d2array = new int[,] { { 1, 2 ,2},
                                         { 3, 4 ,2}};

            //here length method return the total length in i*j format.
            //getlength return the length of column if we pass 0.
            //getlength return the length of row if we pass 1.
            for (int i = 0; i < d2array.GetLength(0); i++)
            {
                for (int j = 0; j < d2array.GetLength(1); j++)
                {
                    Console.Write(d2array[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            #endregion Two-dimensional array

            #region JaggedArray
            Console.WriteLine("Jagged Array");
            // Declare the array of four elements:  
            int[][] jaggedArray = new int[4][];

            // Initialize the elements:  
            jaggedArray[0] = new int[2] { 7, 9 };
            jaggedArray[1] = new int[4] { 12, 42, 26, 38 };
            jaggedArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
            jaggedArray[3] = new int[3] { 4, 6, 8 };

            // Display the array elements:  
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + ", ");
                }
                Console.WriteLine();
            }
            #endregion JaggedArray
        }
    }
}
