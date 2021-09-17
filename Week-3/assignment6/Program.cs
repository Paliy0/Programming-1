using System;
using System.Net.Sockets;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score: ");
            double score = double.Parse(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("grade: A");
                Console.WriteLine("course passed");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("grade: B");
                Console.WriteLine("course passed");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("grade: C");
                Console.WriteLine("course passed");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("grade: D");
                Console.WriteLine("course not passed");
            }
            else if (score < 60 && score >= 0)
            {
                Console.WriteLine("grade: F ");
                Console.WriteLine("course not passed");
            }
            else
            {
                Console.WriteLine("Enter a valid grade");
            }
        }
    }
}
