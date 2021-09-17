using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of seconds: ");
            string input = Console.ReadLine();
            int sec = int.Parse(input);

            int hours = sec / 3600;
            sec = sec % 3600;

            int min = sec / 60;
            sec = sec % 60;

            Console.WriteLine($"{hours:00}:{min:00}:{sec:00}");
        }
    }
}
