using System;

namespace partialClass
{
    //partial class demo
    //partial class use - partial Keyword.
    public partial class PartialClass
    {
        //feilds
        private string _firstName;
        private string _lastName;

        #region Getter and Setter.
        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            set
            { 
                _firstName = value; 
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        #endregion Getter and Setter.
    }

    public partial class PartialClass
    {
        public void FullName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //obj created.
            var objPartialClass = new PartialClass();
            //we can access feild or method using object.
            objPartialClass.FirstName = "Keyur";
            objPartialClass.LastName = "Adhyaru";
            objPartialClass.FullName();
        }
    }
}
//Note : Nested partial types are allowed.
