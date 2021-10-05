using System;
using System.Collections.Generic;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //list is use to create the collection.
            var numbers = new List<int>() { 5, -8, 13, 0, 4 };

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
