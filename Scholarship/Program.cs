using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            double socialScholarship = minimalWage * 0.35;
            double gradeScholarship = grade * 25;


            if (income < minimalWage && grade > 4.5 && grade < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }

            else if (income < minimalWage && grade >= 5.5)
            {
                if (socialScholarship > gradeScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }

                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
                }
            }


            else if (grade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
            }


            else
            {
                Console.WriteLine("You cannot get a scholarship!");

            }
        }
    }
}
