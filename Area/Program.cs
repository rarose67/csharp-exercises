using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            double pi = 3.14;

            do
            {
                Console.WriteLine("Enter the radius:");
                radius = Double.Parse(Console.ReadLine());
                if(radius < 0.0)
                    Console.WriteLine("The radius must be positive.");
            } while (radius < 0.0);
            
            if (radius >= 0.0)
            {
                area = pi * radius * radius;
                Console.WriteLine("The area of the circle is: " + area);
            }
            else
            {
                Console.WriteLine("The radius must be positive.");
            }
            Console.ReadLine();
        }
    }
}
