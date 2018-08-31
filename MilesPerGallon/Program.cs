using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, gallons, mpg;


            Console.WriteLine("How many have you driven?");
            miles = Double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you used?");
            gallons = Double.Parse(Console.ReadLine());
            mpg = miles / gallons;
            Console.WriteLine("Your car gets " + mpg + " miles to the gallon.");
            Console.ReadLine();
        }
    }
}
