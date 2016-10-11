using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Tesla";
            myCar.Model = "Guybrush Threepwood";
            myCar.Year = 1200;
            myCar.Color = "Purple";

            Console.WriteLine("{0} {1} {2} {3}",myCar.Make, myCar.Model, myCar.Year, myCar.Color);
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
