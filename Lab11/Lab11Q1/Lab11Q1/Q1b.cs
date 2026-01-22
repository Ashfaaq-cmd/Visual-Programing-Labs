using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q1
{
    internal class Q1b
    {
        static void Q1bMain(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter lenght:");
            double lenght = Convert.ToDouble(Console.ReadLine());
            Area(width, lenght);
            Perimeter(width, lenght);
        }
         static void Area(double width, double lenght)
        {
          double area = width * lenght;
          
            Console.WriteLine("Area: " + area);
            
        }
            static void Perimeter(double width, double lenght)
            {
            double perimeter = 2 * (width + lenght);
                Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
