using System;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            string weight = Console.ReadLine();

            Console.Write("Enter height (cm): ");
            string height = Console.ReadLine();

            Console.Write("Enter gender (male/female: ");
            string gender = Console.ReadLine();

            double kg = double.Parse(weight);
            double cm = double.Parse(height) / 100;
            double bmi = kg / (cm * cm);
            double maxMale = 25 * (cm * cm);
            double minMale = 20 * (cm * cm);
            double maxFemale = 24 * (cm * cm);
            double minFemale = 19 * (cm * cm);

            if (gender == "male")
            {
                Console.WriteLine($"bmi-value: {bmi:0.0}");
                Console.WriteLine("normal bmi-values (min..max): 20..25");
                Console.WriteLine($"healthy weight range: {minMale:0.0}..{maxMale:0.0}");
            }
            else
            {
                Console.WriteLine($"bmi-value: {bmi:0.0}");
                Console.WriteLine("normal bmi-values (min..max): 19..24");
                Console.WriteLine($"healthy weight range: {minFemale:0.0}..{maxFemale:0.0}");
            }

        }
    }
}
