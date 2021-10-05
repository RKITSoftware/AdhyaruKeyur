using System;

namespace WithParametersWithoutReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            //method calling with parameters.
            getSum(10,40);
        }

        #region Sum
        //method without return type and with Parameters.
        static void getSum(int number1,int number2)
        {
            Console.WriteLine("Sum is " + (number1 + number2));
        }
        #endregion Sum
    }
}
