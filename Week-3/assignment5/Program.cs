using System;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string number1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string number2 = Console.ReadLine();

            int first = int.Parse(number1);
            int second = int.Parse(number2);

            if (first % second == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (second % first == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
        }
    }
}
