using System;

namespace BoxingandUnboxingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            
            //convert int type to object - Boxing.
            object objNum = num;
            Console.WriteLine("Object Value = " + objNum);

            num = 20; 
            Console.WriteLine("Int Value = " + num); 
            Console.WriteLine("Above Example is called Boxing\n");

            //unbox value from box.
            int unboxdata = (int)objNum; 
            Console.WriteLine("value form object = " + unboxdata);
        }
    }
}
