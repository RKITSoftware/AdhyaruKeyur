using System;

namespace HierarchicalInheritance
{
    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class ChildC : Parent
    {
        public void DisplayChildC()
        {
            Console.WriteLine("I am the child C");
        }
    }

    public class ChildD : Parent
    {
        public void DisplayChildD()
        {
            Console.WriteLine("I am the child D");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hirarchical Inheritance Demo");

            ChildC objChildC = new ChildC();
            ChildD objChildD = new ChildD();

            objChildC.DisplayChildC();
            objChildC.DisplayParentsAB();  // accessing parent class

            objChildD.DisplayChildD();
            objChildD.DisplayParentsAB();   // accessing parent class
        }
    }
}
