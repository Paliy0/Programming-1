using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Number: ");
            string input1 = Console.ReadLine();
            float number1 = float.Parse(input1);

            Console.WriteLine("2nd Number: ");
            string input2 = Console.ReadLine();
            float number2 = float.Parse(input2);

            Console.WriteLine("3rd Number: ");
            string input3 = Console.ReadLine();
            float number3 = float.Parse(input3);

            float avrg = (number1 + number2 + number3) / 3;
            Console.WriteLine($"The Average is: {avrg}");
        }
    }
}
