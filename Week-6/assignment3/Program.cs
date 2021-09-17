using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter year (0 is stop value): ");
                int year = int.Parse(Console.ReadLine());

                if (year == 0)
                {
                    break;
                }

                if (year < 0)
                {
                    Console.WriteLine("negative year entered");
                    continue;
                }

                if (IsLeapYear(year))
                {
                    Console.WriteLine(year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year.");
                }
            }
            Console.WriteLine("end of program");
        }
        static bool IsLeapYear(int year)
        {
            if (year % 100 != 0 && year % 4 == 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
