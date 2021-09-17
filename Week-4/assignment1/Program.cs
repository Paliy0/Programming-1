using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int count = 0;
            double sum = 0;

            if (number == 0)
            {
                Console.WriteLine($"Average of all positive numbers is: {number:0.00}");
            }
            else
            {
                while (number != 0)
                {
                    if (number > 0)
                    {
                        count++;
                        sum = sum + number;
                    }

                    Console.Write("Enter a number: ");
                    number = int.Parse(Console.ReadLine());
                }
                double avrg = sum / count;
                Console.WriteLine($"Average of all positive numbers is: {avrg:0.00}");
            }

        }
    }
}
