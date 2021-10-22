using System;

namespace StaticClass
{
    //static class Demo.
    //we cannot create the object of static class.

    public static class Convertor
    {
        #region Inch To CentiMeters
        public static double InchsToCentimeters(string HeightInInchs)
        {
            double inchs = Double.Parse(HeightInInchs);
            double Centimeters = (inchs * 2.54);
            return Centimeters;
        }
        #endregion Inch To CentiMeters

        #region CentiMeters to Inch
        public static double CentimetesToInchs(string HeightInCentimeters)
        {
            double centimeters = Double.Parse(HeightInCentimeters);
            double Inchs = (centimeters / 2.54);
            return Inchs;
        }
        #endregion CentiMeters to Inch
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Inchs to Centimeters.");
            Console.WriteLine("2. From Centimeters to Inchs.");
            string selection = Console.ReadLine();
            double C = 0, I = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the height in inchs: ");
                    //we can directly use method of static class.
                    C = Convertor.InchsToCentimeters(Console.ReadLine());
                    Console.WriteLine("Height in centimeters: {0:F2}", C);
                    break;
                case "2":
                    Console.Write("Please enter the Height in centimeters: ");
                    //we can directly use method of static class.
                    I = Convertor.CentimetesToInchs(Console.ReadLine());
                    Console.WriteLine("Height in Inchs: {0:F2}", I);
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
