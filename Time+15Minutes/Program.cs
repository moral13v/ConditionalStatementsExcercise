using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            // Conditions

            if (minutes >= 45)
            {
                hour += 1;
                minutes += 15 - 60;
            }
            else
            {
                minutes += 15;
            }

            if (hour == 24)
            {
                hour = 0;
            }



            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
