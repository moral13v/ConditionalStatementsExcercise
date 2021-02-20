using System;

namespace GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double costumePricePerExtra = double.Parse(Console.ReadLine());

            // Calculations

            budget -= budget * 0.1;
            double warderobePrice = numberOfExtras * costumePricePerExtra;
            


            // Conditions

            if (numberOfExtras > 150)
            {
                warderobePrice -= warderobePrice * 0.1;
            }

            budget -= warderobePrice;

            if (budget >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:F2} leva left.");
            }

            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget):F2} leva more.");
            }
        }
    }
}
