using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //assign variable 'result' the result of 'number + number'
            int result = number + number;

            // add 10 to result
            result = result + 10;

            //divide result by 2 
            result /= 2;


            //subtract original number from result 
            result -= number;

            Console.WriteLine($"The result is {result}");
        }
    }
}
