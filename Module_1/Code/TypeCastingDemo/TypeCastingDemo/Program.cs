using System;

namespace TypeCastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10; 
            double numDouble = num; 
            Console.WriteLine("Int =" + num + " & Double = " + numDouble); 

            //type cast double to string.
            Console.WriteLine("\nDouble to String = " + Convert.ToString(numDouble));
        }
    }
}
