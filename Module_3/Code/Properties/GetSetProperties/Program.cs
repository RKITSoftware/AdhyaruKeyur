using System;

namespace GetSetProperties
{
    class Person
    {
        //properties Getter and setter is used to set or get value.
        // private static string name;
        public static string name { get; set; }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            //set the value.
            Person.name = "Keyur Adhyaru";

            //get the value.
            Console.WriteLine("Full Name is "+ Person.name);
        }
    }
}
