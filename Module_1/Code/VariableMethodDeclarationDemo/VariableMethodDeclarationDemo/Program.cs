using System;

namespace VariableMethodDeclarationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declare.
            string companyName;

            //variable initize
            companyName = "RKIT";

            //method called.
            printConsole(companyName);
        }

        //method use to print value.
        static void printConsole(string name) 
        { 
            Console.WriteLine("Welcome to " + name); 
        }
    }
}
