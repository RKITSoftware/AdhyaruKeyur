using System;

namespace DefaultConstructor
{

    class Addition
    {
        //local variables.
        public int num1, num2;

        #region Default Constructor
        public Addition()   
        {
            num1 = 10;
            num2 = 15;
        }
        #endregion Default Constructor
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object created.
            var objAddition = new Addition();

            Console.WriteLine("Sum is : "+ (objAddition.num1+objAddition.num2));
        }
    }
}
