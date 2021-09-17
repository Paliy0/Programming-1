using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            while (num != 0)
            {
                count++;
                if (count == 5 || count % 5 == 0)
                {
                    sum += num;
                }
                
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.Write("Sum of 5th, 10th, 15th, ... number is: " + sum);
        }
    }
}
