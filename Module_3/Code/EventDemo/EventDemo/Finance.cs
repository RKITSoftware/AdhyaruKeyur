using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;

        public Finance(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler; 
        }

        public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("Finance Department : Employee Separation Process Related to Finance");
        }
    }
}
