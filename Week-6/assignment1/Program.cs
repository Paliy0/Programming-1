using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            float price = float.Parse(Console.ReadLine());

            float vat = calcVat(price);

            float total = vat + price;

            Console.Write($"price: {price:0.00}, VAT: {vat:0.00}, total: {total:0.00}");
        }
        static float calcVat(float price)
        {
            float vat = 0.21f * price;

            return vat;
        }
    }
}
