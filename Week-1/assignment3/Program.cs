using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            Console.WriteLine($"Your full name is {firstName} {lastName}");

            //wait for the user to enter a key
            Console.ReadKey();
        }
    }
}
