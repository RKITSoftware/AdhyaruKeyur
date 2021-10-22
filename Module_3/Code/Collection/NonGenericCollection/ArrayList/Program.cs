using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable.
            string name = "Keyur Adhyaru";
            string endNumber = "19054";
            DateTime objdateTime = DateTime.UtcNow; 
            
            //created the object of ArrayList.
            ArrayList studentDetails = new ArrayList();

            //using add method we can add items.
            //items datatype can be anything.
            studentDetails.Add(name);
            studentDetails.Add(endNumber);
            studentDetails.Add(objdateTime);

            Console.WriteLine("-: Student Details :-\n");
            foreach (var i in studentDetails)
            {
                Console.WriteLine("{0}",i);
            }
            
        }
    }
}
