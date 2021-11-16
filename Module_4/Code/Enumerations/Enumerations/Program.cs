using System;

namespace Enumerations
{
    class Program
    {
        //defaut enum without values.
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        //enum with values.
        enum Categories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }

        //enum with given values.
        enum CategoriesValues
        {
            Electronics = 1,    // 1
            Food = 29,           // 29
            Automotive = 6, // 6
            Arts = 30,           // 30
            BeautyCare = 3,     // 3
            Fashion = 10,        // 10
        }

        enum VehicleDoors { Motorbike = 0, Sportscar = 2, Sedan = 4, Hatchback = 5 };

        static void Main(string[] args)
        {
            //access enums using dot.
            Console.WriteLine("The values of the WeekDays Enum are:");
            foreach (int position in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine("{0} has a value {1}",((WeekDays)position), position);

            Console.WriteLine();
            Console.WriteLine("Category {0} have the Value = {1}", CategoriesValues.Automotive, (int)CategoriesValues.Automotive);

            Console.WriteLine();
            VehicleDoors myVeh = VehicleDoors.Sportscar;
            VehicleDoors yourVeh = VehicleDoors.Motorbike;
            Console.WriteLine("{0} have more doors than a {1}.", myVeh, yourVeh);

            Console.WriteLine();
            Console.WriteLine("The value of my favorite vehicle is {0}.", Enum.Format(typeof(VehicleDoors), myVeh, "g"));
            Console.WriteLine("The value of my favorite vehicle is {0}.", Enum.Format(typeof(VehicleDoors), myVeh, "d"));

            Console.WriteLine();
            Console.WriteLine("The 2th value of the VehicleDoors Enum is {0}", Enum.GetName(typeof(VehicleDoors), 2));

            Console.WriteLine();
            Console.WriteLine("The members of the Colors enum are:");
            foreach (string s in Enum.GetNames(typeof(VehicleDoors)))
                Console.WriteLine(s);

            Console.WriteLine();
            VehicleDoors vehicleDoors = 
                            VehicleDoors.Sedan | VehicleDoors.Motorbike;
            VehicleDoors flagValue = VehicleDoors.Hatchback | VehicleDoors.Sportscar;
            Console.WriteLine("{0} includes {1}: {2}",
                              vehicleDoors, flagValue, vehicleDoors.HasFlag(flagValue));
            
            Console.WriteLine();
            Console.WriteLine("{0}: {1}", "Sportcar the value : ", Enum.IsDefined(typeof(VehicleDoors), VehicleDoors.Sportscar));

        }
    }
}
