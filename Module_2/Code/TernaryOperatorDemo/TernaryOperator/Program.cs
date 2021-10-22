using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GlobalVariable
            int number = 10;
            string result;
            #endregion GlobalVariable

            //ternary Operator.
            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, result);
        }
    }
}
