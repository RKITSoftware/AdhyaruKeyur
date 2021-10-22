using System;

namespace PrivateConstructor
{
    class PrivateConstructor
    {
        public string createdDate;
        public string name;

        #region Private constructor
        private PrivateConstructor()
        {
            createdDate = DateTime.UtcNow.ToString();
        }
        #endregion Private constructor

        #region Parameterized Constructor
        public PrivateConstructor(string name)
        {
            this.name = name;
        }
        #endregion Parameterized Constructor

    }

    class Program
    {
        static void Main(string[] args)
        {
            // the constructor is inaccessible
            //var objPrivateConstructor = new PrivateConstructor();

            var objPrivateConstructor = new PrivateConstructor("keyur");
            Console.WriteLine("Name is : {0}",objPrivateConstructor.name);
        }
    }
}
