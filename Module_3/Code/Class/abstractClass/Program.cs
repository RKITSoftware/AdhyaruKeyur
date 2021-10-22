using System;

namespace abstractClass
{
    public abstract class Person
    {
        #region Feilds with Getter and Setter
        //getter is used to get the value.
        //setter is user to set the value.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion Feilds with Getter and Setter

        #region Abstract Method.
        //abstract method can contain both abstract and not abstract methods.
        public abstract void PersonDetails();
        public void AbstractClassDemo()
        {
            Console.WriteLine("Abstract Class Demo\n\n");
        }
        #endregion Abstract Method.
    }

    public class Customer : Person
    {
        //we have implemented Person Abstract class here.                
        public override void PersonDetails()
        {
            Console.WriteLine("Please enter first name:");
            //we can set the value of abstract class.
            FirstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter last name:");
            LastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("First Name: {0}", FirstName);
            Console.WriteLine("Last Name: {0}", LastName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //below is the object of class customer.
            Customer objCustomer = new Customer();

            //we can call the abstarct class method here.
            objCustomer.AbstractClassDemo();
            objCustomer.PersonDetails();
           
        }
    }
}
