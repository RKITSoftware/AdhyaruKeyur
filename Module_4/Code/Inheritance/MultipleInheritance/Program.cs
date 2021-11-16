using System;

namespace MultipleInheritance
{
    //c# Does not Support Multiple Inheritance.
    interface AddItems
    {
        int add(int a, int b);
    }
    interface SubtractItems
    {
        int sub(int x, int y);
    }
    interface MultiplyItems
    {
        int mul(int r, int s);
    }
    interface DivideItems
    {
        int div(int c, int d);
    }

    class Calculation : AddItems, SubtractItems, MultiplyItems, DivideItems
    {
        
        public int add(int a, int b)
        {
            return a + b;
        }
       
        public int sub(int x, int y)
        {
            return x - y;
        }
       
        public int mul(int r, int s)
        {
            return r * s;
        }
       
        public int div(int c, int d)
        {
            return c / d;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Calculation objCalculation = new Calculation();
            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
            Console.WriteLine("Addition: " + objCalculation.add(8, 2));
            Console.WriteLine("Substraction: " + objCalculation.sub(20, 10));
            Console.WriteLine("Multiplication :" + objCalculation.mul(5, 2));
            Console.WriteLine("Division: " + objCalculation.div(20, 10));
        }
    }
}
