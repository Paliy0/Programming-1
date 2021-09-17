using System;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of working hours ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of failures: ");
            int failures = int.Parse(Console.ReadLine());

            if ((hours > 10000) || (years >= 7) || (failures > 25))
            {
                Console.Write("Machine needs to be replaced.");
            }
            else
            {
                Console.Write("Machine does not need to be replaced.");
            }
        }
    }
}
