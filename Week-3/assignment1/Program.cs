using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());


            if (number1 > number2)
            {
                Console.WriteLine("highest value is:" + number1);
                Console.WriteLine("lowest value is:" + number2);
            }
            else
            {
                Console.WriteLine("highest value is: " + number2);
                Console.WriteLine("lowest value is: " + number1);
            }
        }
    }
}
