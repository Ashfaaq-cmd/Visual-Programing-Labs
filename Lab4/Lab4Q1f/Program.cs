using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius for the closed cylinder");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height for the closed cylinder");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;
            double surfaceArea = 2 * Math.PI * radius * (radius + height);
            Console.WriteLine($"The volume of the closed cylinder is {volume}");
            Console.WriteLine($"The surface area of the closed cylinder is {surfaceArea}");
        }
    }
}
