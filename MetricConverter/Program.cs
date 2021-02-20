using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double lenght = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            // Conditions

            if (inputUnit == "m")
            {
                if (outputUnit == "mm")
                {
                    lenght = lenght * 1000;
                }
                else if (outputUnit == "cm")
                {
                    lenght = lenght * 100;
                }
            }

            else if (inputUnit == "cm")
            {
                if (outputUnit == "m")
                {
                    lenght = lenght / 100;
                }
                else if (outputUnit == "mm")
                {
                    lenght = lenght * 10;
                }
            }

            else if (inputUnit == "mm")
            {
                if (outputUnit == "cm")
                {
                    lenght = lenght / 10;
                }
                else if(outputUnit == "m")
                {
                    lenght = lenght / 1000;
                }
            }

            Console.WriteLine("{0:F3}", lenght);

        }
    }
}
