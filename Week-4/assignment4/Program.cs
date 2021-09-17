using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int count = 0;

            Console.Write("1, 1");

            for (int i = 0; i != 18; i++)
            {

                int num3 = num1 + num2;
                Console.Write(", " + num3);

                num1 = num2;
                num2 = num3;
            }
            /*
            while (count != 18)
            {
                count++;
                int num3 = num1 + num2;
                Console.Write(num3 + ", ");

                num1 =  num2;
                num2 = num3;
            }
            */
        }
    }
}
