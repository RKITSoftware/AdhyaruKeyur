using System;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is the demo of named Parameters.
            Program objProgram = new Program();
            int result = objProgram.Add(number2: 10, number1: 20);
            Console.WriteLine("Sum is : " + result);
        }

        #region Add Method
        private int Add(int number1,int number2)
        {
            //this function will add two numbers.
            return number1 + number2;
        }
        #endregion Add Method
    }
}
