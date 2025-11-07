using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Students: ");
            int numStuds = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Subjects: ");
            int numSubjects = int.Parse(Console.ReadLine());

            int[,] marks = new int[numStuds, numSubjects];

            for (int i = 0; i < numStuds; i++)
            {
                Console.WriteLine($"Entering marks for Student {i + 1}...");
                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"Enter marks for Subject {j + 1}: ");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nDisplaying the contents of the 2D Array...:");
            for (int i = 0; i < numStuds; i++)
            {
                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write(marks[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numStuds; i++)
            {
                int min = marks[i, 0];
                int max = marks[i, 0];
                int tot = 0;

                for (int j = 0; j < numSubjects; j++)
                {
                    int mark = marks[i, j];
                    tot += mark;
                    if (mark < min) min = mark;
                    if (mark > max) max = mark;

                }
                double avg = (double)tot / numSubjects;
                Console.WriteLine($"\nProcessed Marks for Student {i+1}...");
                Console.WriteLine($"Minimum Marks: {min}");
                Console.WriteLine($"Maximum Marks: {max}");
                Console.WriteLine($"Total Marks: {tot}");
                Console.WriteLine($"Average Marks: {avg:F2}");

                Console.ReadKey();
            }
        }
    }
}