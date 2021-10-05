using System;

namespace Increment_Decrement_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            // Incremental Operator    
            Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a);
            
            // Decrement Operator    
            Console.WriteLine("Decremental Operator");
            Console.WriteLine(--a);
            Console.WriteLine(a);
            Console.WriteLine(a--);
            Console.WriteLine(a);
            
        }
    }
}
