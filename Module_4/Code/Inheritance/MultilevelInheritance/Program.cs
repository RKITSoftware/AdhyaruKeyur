using System;

namespace MultilevelInheritance
{
    public class Grandparent
    {
        public void DisplayGrandParentsAB()
        {
            Console.WriteLine("A and B are my grandparents");
        }
    }

    public class Parents : Grandparent
    {
        public void DisplayParentsCD()
        {
            Console.WriteLine("C and D are my parents");
        }
    }

    public class Child : Parents
    {
        public void DisplayChildZ()
        {
            Console.WriteLine("I am the child Z");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Level Inheritance");

            Child objChild = new Child();
            objChild.DisplayChildZ();
            objChild.DisplayParentsCD(); // accessing derived class
            objChild.DisplayGrandParentsAB(); // accessing base class
        }
    }
}
