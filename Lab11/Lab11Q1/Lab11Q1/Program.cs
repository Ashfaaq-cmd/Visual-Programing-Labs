using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter lenght:");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Computation(width, lenght);
        }

         static void Computation(double width, double lenght)
        {
          double area = width * lenght;
          double perimeter = 2 * (width + lenght);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
