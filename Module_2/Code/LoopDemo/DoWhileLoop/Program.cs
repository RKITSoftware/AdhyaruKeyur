using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Variables
            int i = 1, sum = 0;
            #endregion Local Variables

            //do-while first execute the code and at the end check the condition.
            do
            {
                sum += i;
                //increment the variable
                i++;    
            } while (i <= 5);
           

            Console.WriteLine("Sum = " + sum);
        }
    }
}
