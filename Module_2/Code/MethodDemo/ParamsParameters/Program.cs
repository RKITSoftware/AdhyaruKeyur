using System;

namespace ParamsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is the example of Params Parameters.
            //using Params keyword we can pass multiple parameters of same types.

            #region GlobalVariable
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;
            int result = 0;
            #endregion GlobalVariable

            result = Add(num1, num2, num3, num4);
            Console.WriteLine("Sum is : {0}",result);
        }

        #region Add Method.
        public static int Add(params int[] list)
        {
            int tempResult = 0;
            foreach (var item in list)
            {
                tempResult += item;
            }
            return tempResult;
        }
        #endregion Add Method.
    }
}
