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
            Console.Write("\n");
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

            #endregion Two-dimensional array
        }
    }
}
