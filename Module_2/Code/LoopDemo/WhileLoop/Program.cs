using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Variables
            int i = 1, sum = 0;
            #endregion Local Variables

            //while check the condition first and execute the program.
            while (i <= 5)
            {
                sum += i;
                i++;    //increment the variable
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
