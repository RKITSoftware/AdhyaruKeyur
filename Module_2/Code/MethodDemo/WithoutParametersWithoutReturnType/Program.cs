using System;

namespace WithoutParametersWithoutReturnType
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //method calling
            getSum();
        }

        #region Sum 
        //method withour parameters and without return type
        static void getSum()
        {
            Console.WriteLine("Sum is {0}", (10 + 40));
        }
        #endregion Sum
    }
}
