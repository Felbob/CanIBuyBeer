using System;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace AlkoholKontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in din ålder: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Location (Systemet eller Krogen): ");
            var location = Console.ReadLine().ToLower().Trim();

            Console.Write("Har du legg med dig (j/n): ");
            var legg = Console.ReadLine().ToLower().Trim();

            Console.Write("Vilken promille halt har du? ");
            var promille = Convert.ToDecimal(Console.ReadLine());

            var canIBuyBeer = false;

            if (legg == "j" && promille < 1.0m)
            {
                if (age > 17 && location == "krogen")
                    canIBuyBeer = true;
                else if (age > 19 && location == "systemet")
                    canIBuyBeer = true;
            }

            if (canIBuyBeer)
                Console.WriteLine("Du får köpa öl!");
            else
                Console.WriteLine("Du får inte köpa öl");

            Console.ReadLine();
        }
    }
}
