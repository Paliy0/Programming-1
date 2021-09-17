using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 4:");
            string input = Console.ReadLine();
            int number = int.Parse(input);


            if (number > 0)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("clubs");
                        break;
                    case 2:
                        Console.WriteLine("diamonds");
                        break;
                    case 3:
                        Console.WriteLine("hearts");
                        break;
                    case 4:
                        Console.WriteLine("spades");
                        break;

                    default:
                        Console.WriteLine("Wrong number!");
                        break;
                }
            }
        }
    }
}
