using System;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Event class Object.
            EmployeeSeparator objEmployeeSeparator = new EmployeeSeparator();
            //subscribe to the event
            Finance objFinance = new Finance(objEmployeeSeparator);

            //fire the event.
            objEmployeeSeparator.Separater();
        }
    }
}
