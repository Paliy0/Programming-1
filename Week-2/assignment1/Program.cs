using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price: ");
            string input = Console.ReadLine();
            double price = double.Parse(input);

            double vat = price * 0.21;
            double total = price + vat;

            Console.WriteLine($"price: {price:0.00}, vat: {vat:0.00}, total: {total:0.00}");
            

            //Console.WriteLine("Price: {0:0.00}", price, "VAT: {0:0.00}", vat, "Total: {0:0.00}", total);
  

        }
    }
}
