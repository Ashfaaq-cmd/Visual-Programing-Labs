using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade: ");
            double mark = Convert.ToDouble(Console.ReadLine());

            char grade = Grade(mark);
            Console.WriteLine("The grade is: " + grade);

        }

        private static char Grade(double mark)
        {
            switch (mark)
            {
               case var m when (m >= 80):
                return 'A';
            case var m when (m >= 60):
                return 'B';
            case var m when (m >= 40):
                return 'C';
            default:
                return 'D';
            }
        }
    }
}