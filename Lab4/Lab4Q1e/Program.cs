using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1e
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter number of x1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double m = (y2 - y1) / (x2 - x1);
            double yDifference = Math.Pow(y2 - y1, 2);
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + yDifference);
            Console.WriteLine($"The slope of the line is {m}");
            Console.WriteLine($"The distance between the points is {d}");
        }
    }
}
