using System;

namespace StaticConstructor
{
    class Circle
    {
        private static double pi;
        private double radius;

        #region Static constructor
        static Circle()
        {
            pi = 3.14;
        }
        #endregion Static constructor

        #region Parameterized Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        #endregion Parameterized Constructor

        public double areaofCircle()
        {
            return (pi * radius * radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var objCircle = new Circle(2.0);
            var result = objCircle.areaofCircle();
            Console.WriteLine("Area of Circle is : {0}",result);
        }
    }
}
