using System;

namespace AbstractPerson
{
    public abstract class Person
    {
        //properties Getter and setter is used to set or get value.
        //we can also use this with abstract class.
        public abstract string Name
        {
            get;
            set;
        }
       
    }

    class Student : Person
    {
        private string name = "Keyur Adhyaru";

        //properties override.
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object created.
            var objStudent = new Student();
            Console.WriteLine("Name = "+ objStudent.Name);
        }
    }
}
