using System;

namespace ParameterizedConstructor
{
    class Addition
    {
        //class have feilds, methods, constructors etc.

        #region Feilds
        private int number1;
        private int number2;
        #endregion Feilds

        #region Parameterized Constructor
        public Addition(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        #endregion Parameterized Constructor

        #region Methods
        internal int sum()
        {
            return number1 + number2;
        }
        #endregion Methods
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class demo
            //using new keyword we can create object.
            Addition objAddition = new Addition(10, 20);
            int ans = objAddition.sum();
            Console.WriteLine("Sum is : {0}", ans);
        }
    }
}
