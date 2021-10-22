using System;

namespace PublicAccessModifier
{
    //public access modifier Demo
    class Person
    {

        // Declaring members age
        // and name as public
        public int age;
        public string name;

        // Constructor
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        // also declared as public
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of the class Person
            Person objPerson = new Person(18, "ABC");
            Console.WriteLine("Name : {0}",objPerson.getName());
            Console.WriteLine("Age : {0}", objPerson.getAge());

        }
    }
}
