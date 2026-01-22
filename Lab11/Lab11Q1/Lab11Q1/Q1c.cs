using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q1
{
    internal class Q1c
    {
        static void Q1cMain(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter lenght:");
            double lenght = Convert.ToDouble(Console.ReadLine());
          double area= AreaOfRectangle (width, lenght);
          double  perimeter= PerimeterOfRectangle(width, lenght);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        private static double PerimeterOfRectangle(double width, double lenght)
        {
           return 2 * (width + lenght);
        }

        private static double AreaOfRectangle(double width, double lenght)
        {
          return width * lenght;
        }
    }                                                   
    }

