using System;
using System.Collections.Specialized;

namespace assignment4
{
    class Program
    {
        const int maxInput = 20;
        static void Main(string[] args)
        {
            int[] numbers = new int[maxInput];

            int count = 0;

            Console.Write("Enter a number (0=stop): ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; input != 0; i++)
            {
                count++;

                if (count < maxInput)
                {
                    numbers[i] = input;
                }
                Console.Write("Enter a number (0=stop): ");
                input = int.Parse(Console.ReadLine());
            }

            Console.Write("\n");
            Console.Write("Enter a search value: ");
            int searchVal = int.Parse(Console.ReadLine());

            count = 0;
            
            for (int i = 0; i < maxInput; i++)
            {
                if (searchVal == numbers[i])
                {
                    count++;
                }
            }
            Console.Write("Number of occurences of searchvalue (" + searchVal + ") is: " + count);




        }
    }
}
