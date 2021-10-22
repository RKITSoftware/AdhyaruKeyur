using System;

namespace OutParameters
{
    class Program
    {

        static void Main(string[] args)
        {
            //here is the example of out Parameters.

            #region GlobalVariable
            int result = 0;
            #endregion GlobalVariable

            //In the Below statment We will take the sum in out variable - result.
            Add(10, 20,out result);
            Console.WriteLine("Sum is : " + result);
        }

        #region Add Method
        private static void Add(int number1,int number2,out int ans)
        {
            //this function will add two numbers.
             ans = number1 + number2;
        }
        #endregion Add Method


    }
}
