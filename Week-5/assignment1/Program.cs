using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int size = 20;
            int[] numbers = new int[size];

            double sum = 0;
            
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(201);

                Console.Write("Element " + i + " is " + numbers[i]);
                Console.Write("\n");

                sum += numbers[i];
            }
            double avrg = sum / size;

            Console.Write("\n");
            Console.Write($"The average is: {avrg:0.00}");
            Console.Write("\n");
            Console.Write("\n");


            for (int i = 0; i < size; i++)
            {
                double diff = avrg - numbers[i];

                Console.Write($"Difference between average and element {i} is {Math.Abs(diff):0.00}");
                Console.Write("\n");

            }

        }
    }
}
