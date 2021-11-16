using System;

namespace throwException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throe keyword is use to Generate a Expception.
                throw new DivideByZeroException("Invalid Division");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                //final block will execute everytime.
                Console.WriteLine("LAST STATEMENT");
            }
            
        }
    }
}
