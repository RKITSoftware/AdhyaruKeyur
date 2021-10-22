using System;

namespace ProtectedAccessModifier
{
    class Person
    {
        protected string name = "ABC";
        public string getName()
        {
            return this.name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of the class Person
            Person objPerson = new Person();

            //below code get the compile error.
            //because we cannot access protected methods or variable.
            //objPerson.name;

            Console.WriteLine("Name = {0}",objPerson.getName());
           
        }
    }
}
