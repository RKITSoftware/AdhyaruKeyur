using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    class EmployeeSeparator
    {
        //delegate is used to dispatch the event.
        //we can use Predefined delegate :: EventHandler.
        //below is the custom delegate.
        public delegate void EmployeeSeparatedEventHandler();
        public event EmployeeSeparatedEventHandler EmployeeSeparated;
        public void Separater()
        {
            //check that event is subscribe by anyone or not.
            // if we did not check then this will throw the exception.
            if (EmployeeSeparated != null)
            {
                EmployeeSeparated();
            }
            
        }
    }
}
