using System;

namespace sealedClass
{
    //sealed Class Demo.
    //sealed class cannot be inherite.
    //to Create sealed class use sealed keyword.

    #region sealed Class
    public sealed class Addition
    {
        public int addTwoNumbers(int num1,int num2)
        {
            return num1 + num2;
        }
    }
    #endregion sealed Class

    class Program
    {
        static void Main(string[] args)
        {
            //By creating object we can use the method of sealed class.
            var objAddition = new Addition();
            var ans = objAddition.addTwoNumbers(10, 5);
            Console.WriteLine("Sum is : {0}", ans);
        }
    }

}
//Note : Access modifiers are not applied to a sealed class.
