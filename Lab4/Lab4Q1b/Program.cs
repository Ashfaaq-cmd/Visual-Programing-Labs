using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of circle with radius {radius} is {area}");
            Console.ReadKey();
        }
    }
}
