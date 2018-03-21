using System;

namespace BodyMassIndex
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var isValid = false;
            BodyMassIndexReport report = null;
            while (!isValid)
            {
                /* Impure */
                Console.WriteLine("Please enter a height in meters: ");
                var height = Console.ReadLine();

                Console.WriteLine("Please enter a weight in kilograms: ");
                var weight = Console.ReadLine();

                /* pure */
                report = new BodyMassIndexReport(height, weight);

                isValid = report.IsValid;

                if (!isValid)
                {
                    Console.Clear();
                    Console.WriteLine($"Inputs height={height} and weight={weight} must be valid decimals");
                }
            }

            var designation = report.GetReport() ?? "Null";

            Console.WriteLine(designation);
        }
    }   
}
