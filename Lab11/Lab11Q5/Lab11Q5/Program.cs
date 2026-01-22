using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Compute(num1, num2, num3);

        }

        private static void Compute(int num1, int num2, int num3)
        {
            int firstmin, finalmin, firstmax, finalmax,tot,avg;

           firstmin= Math.Min(num1, num2);
           finalmin= Math.Min(firstmin, num3);

           firstmax= Math.Max(num1, num2);
           finalmax= Math.Max(firstmax, num3);

            tot = num1 + num2 + num3;
            avg = tot / 3;

            Console.WriteLine("Minimum: " + finalmin);
            Console.WriteLine("Maximum: " + finalmax);
            Console.WriteLine("Total: " + tot);
            Console.WriteLine("Average: " + avg);
        }
    }
}
