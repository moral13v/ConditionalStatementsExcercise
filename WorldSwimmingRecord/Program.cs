using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            // Calculations

            double timeNeeded = distance * secondsPerMeter;

            timeNeeded += Math.Floor(distance / 15) * 12.5;



            

            // Conditions

            if (timeNeeded < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeNeeded:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {timeNeeded - worldRecord :f2} seconds slower.");
            }
        }
    }
}
