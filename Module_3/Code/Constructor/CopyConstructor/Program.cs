using System;

namespace CopyConstructor
{
    class Person
    {
        private string firstname;
        private string lastname;

        #region Copy constructor
        public Person(Person objPerson)   // declaring Copy constructor.
        {
            firstname = objPerson.firstname;
            lastname = objPerson.lastname;
        }
        #endregion Copy constructor

        #region Instance constructor
        public Person(string firstname, string lastname) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        #endregion Instance constructor

        #region Details of Person
        public string Details     
        {
            get
            {
                return "Full Name : " + firstname + " " + lastname;
            }
        }
        #endregion Details of Person
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object created.
            var objPerson = new Person("Keyur", "Adhyaru");
            Console.WriteLine(objPerson.Details);
        }
    }
}
