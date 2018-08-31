using System;
using System.Collections.Generic;
using System.Linq;


namespace Sum
{
    class Program
    {
        static int EvenSum(List<int> numbers)
        {
            int sum = 0;

            foreach(int num in numbers)
            {
                if((num % 2) == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            String line;
            int sum;

            Console.WriteLine("Pease enter a number (enter a blank to finish)");
            line = Console.ReadLine();
            while (!(line.Equals("")))
            {
                numlist.Add(int.Parse(line));
                Console.WriteLine("Pease enter a number (enter a blank to finish)");
                line = Console.ReadLine();
            }
            sum = EvenSum(numlist);
            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();

        }
    }
}
