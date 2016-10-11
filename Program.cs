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
            decimal value = myCar.DetermineMarketValue();
            Console.WriteLine("car value is: {0:C}", value);

            Car myOtherCar;
            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}",myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
           
        }


    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal DetermineMarketValue ()
      {
            decimal carValue = 100.0M;

            return carValue;
     }
   
    }
}
