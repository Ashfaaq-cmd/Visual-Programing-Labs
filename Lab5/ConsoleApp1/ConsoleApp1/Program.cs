using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");

            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            else
            {
                Console.WriteLine(num2 + " is greater than " + num1);
            }
        }
    }
}
