using System;

namespace CallMethodUsingNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here we have use System Define Namespace with using keyword\n");
            
            //we can use method of class using namespace.
            demo.Demo.printName("namespace demo");
        }
    }
}
namespace demo 
{ 
    class Demo 
    { 
        //method is user to print value.
        public static void printName(String name) 
        { 
            Console.WriteLine(name); 
        } 
    } 
}
