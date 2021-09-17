using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int size = 20;
            int[] numbers = new int[size];

            int smallest = 0;
            int count = 0;

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(0,150);
                smallest = numbers[0];

                Console.Write("Element " + i + " = " + numbers[i]);
                Console.Write("\n");


            }
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                    
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (smallest == numbers[i])
                {
                    count++;
                }
            }

            Console.Write("smallest number = " + smallest);
            Console.Write("\n");
            Console.Write("number of occurence = " + count);


        }
    }
}
