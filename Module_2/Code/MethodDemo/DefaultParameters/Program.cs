using System;

namespace DefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is the example of default or optional Parameters.

            #region Gobal Variables
            int result = 0;
            #endregion Gobal Variables

            //only pass the one parameter. - other Parameters will take default value.
            result = Add(10);
            Console.WriteLine("Pass One Parameter - Sum is : {0}",result);

            //only pass the two parameter. - other Parameters will take default value.
            result = Add(10,20);
            Console.WriteLine("Pass two Parameter - Sum is : {0}", result);

            //pass all parameters. - So it will take the Parameters value.
            result = Add(10,10,20);
            Console.WriteLine("Pass All Parameter - Sum is : {0}", result);

            //Note : Optional parameter must be defined after any required parameter.
        }

        #region Add Method
        private static int Add(int number1, int number2 = 0,int number3 = 0)
        {
            //this function will add numbers.
            return number1 + number2 + number3;
        }
        #endregion Add Method
    }
}
