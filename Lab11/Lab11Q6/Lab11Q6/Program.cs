using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours worked:");
            double hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter pay rate:");
            double payRate = Convert.ToDouble(Console.ReadLine());

            double result = CalcGrossPay(hoursWorked, payRate);
            Console.WriteLine("Gross Pay: " + result.ToString("C2"));
        }

        private static double CalcGrossPay(double hoursWorked, double payRate)
        {
           if (hoursWorked <= 40)
            {
                return hoursWorked * payRate;
            }
            else
            {
                double overtimeHours = hoursWorked - 40;
                double overtimePay = overtimeHours * payRate * 1.5;
                double regularPay = 40 * payRate;
                return regularPay + overtimePay;
            }
        }
    }
}
