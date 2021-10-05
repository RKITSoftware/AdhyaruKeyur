using System;

namespace WithParametersWithReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            //method call with parameters and get the int as return type.
            Console.WriteLine("Sum is " + getSum(10,40));
        }

        #region Sum
        //method with return type and with Parameters.
        static int getSum(int number1, int number2)
        {
            return (number1 + number2);
        }
        #endregion Sum
    }
}
