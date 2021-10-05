using System;

namespace WithoutParametersWithReturnValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //method calling
            Console.WriteLine("Sum is " + getSum());
        }

        #region Sum
        //method with return type and without Parameters.
        static int getSum()
        {
            return (10 + 40);
        }
        #endregion Sum
    }
}
