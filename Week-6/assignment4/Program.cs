using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a text> ");
            string txt = Console.ReadLine();
            SearchText(txt, out int nrOfCommas, out int nrOfFullStops, out int nrOfSemiColons);

            Console.Write($"result: {nrOfFullStops} fullstops, {nrOfCommas} commas, {nrOfSemiColons} semicolons");
        }
        static void SearchText(string txt, out int nrOfCommas, out int nrOfFullStops, out int nrOfSemiColons)
        {
            nrOfCommas = 0;
            nrOfFullStops = 0;
            nrOfSemiColons = 0;


            foreach (char c in txt)
            {
                if (c == '.')
                {
                    nrOfFullStops++;
                }
                else if (c == ',')
                {
                    nrOfCommas++;
                }
                else if (c == ';')
                {
                    nrOfSemiColons++;
                }
            }
        }
    }
}
