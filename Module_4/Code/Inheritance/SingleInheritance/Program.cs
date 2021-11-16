using System;

namespace SingleInheritance
{
    public class Parent
    {
        //based Class
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class Son : Parent
    {
        //derived Class
        public void DisplaySonC()
        {
            Console.WriteLine("I am the son C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance Demo");

            Son objSon = new Son();
            objSon.DisplaySonC();
            objSon.DisplayParentsAB(); // accessing parent class
        }
    }
}
