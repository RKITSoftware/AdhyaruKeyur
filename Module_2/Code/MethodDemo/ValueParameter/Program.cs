using System;

namespace ValueParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is the example of value Parameters.

            #region GlobalVariable
            int num1 = 10;
            int num2 = 20;
            int result = 0;
            #endregion GlobalVariable

            result = swapValue(num1, num2);
            Console.WriteLine("Swap Value and Return first One : " + result);
        }

        #region SwapValue Method
        private static int swapValue(int number1, int number2)
        {
            //this function will swap value without modify original data.
            return number1 = number2;
        }
        #endregion SwapValue Method
    }
}
