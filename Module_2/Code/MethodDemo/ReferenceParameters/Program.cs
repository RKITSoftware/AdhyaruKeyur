using System;

namespace ReferenceParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is the demo of ref Parameters.

            #region Gobal Variables
            int num1 = 10;
            int num2 = 20;
            int result = 0;
            #endregion Gobal Variables

            Program objProgram = new Program();

            //In the below statment we have pass the references.
            result = objProgram.Add(ref num1,ref num2);
            Console.WriteLine("Sum is : " + result);
        }


        #region Add Method
        private int Add(ref int number1, ref int number2)
        {
            //this function will add two numbers.
            return number1 + number2;
        }
        #endregion Add Method
    }
}
