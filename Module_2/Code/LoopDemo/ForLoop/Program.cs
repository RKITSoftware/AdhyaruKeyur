using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region local Variables
            int sum = 0;
            int userInput;
            #endregion local Variables

            //readline method is used to take user input
            Console.Write("Enter integer value: ");

            //readline return the value in string.
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                sum += i;
                // sum = sum + i;
            }

            Console.WriteLine("Sum of first {0} natural numbers = {1}", userInput, sum);
        }
    }
}
