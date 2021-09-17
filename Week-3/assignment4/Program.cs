using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            int highest = number1;
            int lowest = number1;

            if (number2 > highest)
            {
                highest = number2;
            }
            else if (number3 > highest)
            {
                highest = number3;
            }

            if (number2 < lowest)
            {
                lowest = number2;
            }
            else if (number3 < lowest)
            {
                lowest = number3;
            }

            double sum = number1 + number2 + number3;
            double avrg = sum / 3;
            double product = number1 * number2 * number3;

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {avrg:0.00}");
            Console.WriteLine($"product = {product}");
            Console.WriteLine($"Highest = {highest}");
            Console.WriteLine($"Lowest = {lowest}");

            /*
            if (first > second && first > third)
            {
                Console.WriteLine("highest = " + first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("highest = " + second);
            }
            else if (third > first && third > second)
            {
                Console.WriteLine("highest = " + third);
            }
            if (first < second && first < third)
            {
                Console.WriteLine("lowest = " + first);
            }
            else if (second < first && second < third)
            {
                Console.WriteLine("lowest = " + second);
            }
            else if (third < first && third < second)
            {
                Console.WriteLine("lowest = " + third);
            }

            */


        }
    }
}
