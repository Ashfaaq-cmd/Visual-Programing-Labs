using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, tot,avg;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third number");
            num3 = Convert.ToDouble(Console.ReadLine());

            tot = num1 + num2 + num3;
            avg = tot / 3;

            Console.WriteLine("The smallest number is " + Math.Min(num1, Math.Min(num2, num3)));
            Console.WriteLine("The largest number is " + Math.Max(num1, Math.Max(num2, num3)));
            Console.WriteLine("Total is " + tot);
            Console.WriteLine("Average is " + avg);
            Console.ReadKey();
        }
    }
}
