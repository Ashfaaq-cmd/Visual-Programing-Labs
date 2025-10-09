using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Q1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance of a trip in KM");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the km per litre");
            double kmPerLitre = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the price per litre");
            double pricePerLitre = Convert.ToDouble(Console.ReadLine());

            double litresNeeded = distance / kmPerLitre;
            double totalCost = litresNeeded * pricePerLitre; 

            Console.WriteLine($"The total cost of the trip is {totalCost}");
            Console.WriteLine($"You will need {litresNeeded} litres of fuel for the trip");
        }
    }
}
