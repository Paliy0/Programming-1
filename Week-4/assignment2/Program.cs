using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target number: ");
            int targetNum = int.Parse(Console.ReadLine());
            
            int count = 0;

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number == targetNum)
                {
                    count++;
                }
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.Write($"Count of numbers equal to target number: {count}");

        }
    }
}
