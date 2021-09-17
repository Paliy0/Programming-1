using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            while (year != 0)
            {
                if (year % 100 != 0 && year % 4 == 0 || year % 400 == 0)
                {
                    Console.Write(year + " is a leap year. \n");
                }
                else if (year < 0)
                { 
                    Console.Write("Year must be positive! \n"); 
                }
                else
                {
                    Console.Write(year + " is not a leap year. \n");
                }

                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());
            }
        }
    }
}
