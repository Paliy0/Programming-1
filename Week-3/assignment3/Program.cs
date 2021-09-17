using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string number2 = Console.ReadLine();

            Console.WriteLine("Enter third number: ");
            string number3 = Console.ReadLine();

            int first = int.Parse(number1);
            int second = int.Parse(number2);
            int third = int.Parse(number3);

            if (first > third && second > third)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }
        }
    }
}
