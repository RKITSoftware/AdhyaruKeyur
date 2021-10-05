using System;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = getSum(10, 40); // method calling.
            Console.WriteLine("Sum is " + ans);
        }

        #region Get Sum
        static int getSum(int number1,int number2)
        {
            return number1 + number2;
        }
        #endregion Get Sum
    }
}
