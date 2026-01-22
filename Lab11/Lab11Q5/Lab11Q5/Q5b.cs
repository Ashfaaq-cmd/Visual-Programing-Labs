using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q5
{
    internal class Q5b
    {
        static void Q5bMain(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int min =  Minimum(num1, num2, num3);
            int max = Maximum(num1, num2, num3);
            int total = Total(num1, num2, num3);
            int average = Average(total, 3);

            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + average);

        }

        private static int Average(int total, int v)
        {
            return total / v;
        }

        private static int Total(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        private static int Maximum(int num1, int num2, int num3)
        {
            int firstmax = Math.Max(num1, num2);
            return Math.Max(firstmax, num3);
        }

        private static int Minimum(int num1, int num2, int num3)
        {
            int firstmin = Math.Min(num1, num2);
            return Math.Min(firstmin, num3);
        }
    }
}
