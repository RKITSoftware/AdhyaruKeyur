using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPress = 2;
            switch (numPress)
            {
                case 1:
                    Console.WriteLine("You have Press 1");
                    break;

                case 2:
                    Console.WriteLine("You have Press 2");
                    break;

                case 3:
                    Console.WriteLine("You have Press 3");
                    break;

                default:
                    //default case is execute when no-one case matched.
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
