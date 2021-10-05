using System;

namespace BreakContinueJumpGotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Break Statment
            Console.WriteLine("Loop Break when i Becomes 3");
            for (int i = 1; i < 4; i++)
            {
                if (i == 3)
                    break;

                Console.WriteLine("i = " + i);
            }
            #endregion Break Statment

            #region Continue
            // if the value of i becomes 3 then it will skip 3 continue with 4. 
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;

                Console.WriteLine("i = " + i);
            }
            #endregion Continue

            #region goto statment
            int number = 2;
            switch (number)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;

                default:
                    Console.WriteLine("No match found");
                    goto case 1;
            }
            #endregion goto statment
        }
    }
}
