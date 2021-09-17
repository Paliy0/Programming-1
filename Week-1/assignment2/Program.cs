using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //red age of user
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            //convert txt to an integer value
            int age = int.Parse(input);

            age = age + 1;

            string output = age.ToString();

            Console.WriteLine("Next year you will be " + output + " years old.");

            Console.ReadKey();
        }
    }
}
