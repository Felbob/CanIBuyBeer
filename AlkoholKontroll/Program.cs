﻿using System;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace AlkoholKontroll
{
    class Program
    {
        static bool CanIBuyBeer(string legg, decimal promille, int age, string location)
        {
            var canIBuyBeer = false;

            if (legg == "j" && promille < 1.0m)
            {
                if (age > 17 && location == "krogen")
                    canIBuyBeer = true;
                else if (age > 19 && location == "systemet")
                    canIBuyBeer = true;
                else
                    canIBuyBeer = false;
            }

            return canIBuyBeer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ver 1.01");
            Console.WriteLine();
            
            Console.Write("Mata in din ålder: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Location (Systemet eller Krogen): ");
            var location = Console.ReadLine().ToLower().Trim();

            Console.Write("Har du legg med dig (j/n): ");
            var legg = Console.ReadLine().ToLower().Trim();

            Console.Write("Vilken promille halt har du? ");
            var promille = Convert.ToDecimal(Console.ReadLine());

            var canIBuyBeer = CanIBuyBeer(legg, promille, age, location);

            if (canIBuyBeer)
                Console.WriteLine("Du får köpa öl!");
            else
                Console.WriteLine("Du får inte köpa öl");

            Console.ReadLine();
        }
    }
}
