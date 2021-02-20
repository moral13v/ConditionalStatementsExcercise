﻿using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int number = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            // Conditions

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }

            if (number % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }

            // Output

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);

        }
    }
}
