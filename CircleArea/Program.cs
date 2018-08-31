using System;

namespace RectArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area;
           

            Console.WriteLine("Please enter the length of the rectangle.");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle.");
            width = Double.Parse(Console.ReadLine());
            area = length * width;
            Console.WriteLine("Area of the Rectangle is " + area + "!");
            Console.ReadLine();
        }
    }
}
