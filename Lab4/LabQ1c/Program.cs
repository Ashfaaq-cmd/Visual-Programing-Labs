using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabQ1c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter depth of earth");
            double depth = Convert.ToDouble(Console.ReadLine());
            double celsius = 10 * (depth) + 20;
            double fahrenheit = 1.8 * celsius + 32;
            Console.WriteLine($"Temperature at depth {depth} km is {celsius}c and in fahrenheit {fahrenheit} F");

        }
    }
}
