using System;

namespace InternalAccessModifier
{
    internal class Person
    {
        //local variable.
        string name;

        //constructor
        public Person(string fullName)
        {
            this.name = fullName;
        }

        public void DisplayName()
        {
            Console.WriteLine("Name is {0}", this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object.
            var objPerson = new Person("Keyur Adhyaru");
            objPerson.DisplayName();
        }
    }
}
