using System;

namespace assigment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            while (true)
            {
                Console.Write("Enter a number (0 is stop value): ");
                number = int.Parse(Console.ReadLine());

                if (number == 0) break;

                if (number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                    continue;
                }

                if (IsPrimeNumber(number))
                {
                    Console.WriteLine(number + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime number.");
                }
            }
            Console.Write("end of program");
        }

        static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
