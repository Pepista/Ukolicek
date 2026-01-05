/*
using System;

class Program //Funkce (zkontroluje a odpoví)
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Zadej svůj věk (nebo 0 pro ukončení): ");

            if (!int.TryParse(Console.ReadLine(), out int vek))
            {
                Console.WriteLine("Neplatný vstup!");
                continue;
            }

            if (vek == 0)
                break;

            if (vek < 0)
                Console.WriteLine("Věk nemůže být záporný.");
            else if (vek < 18)
                Console.WriteLine("Jsi nezletilý.");
            else
                Console.WriteLine("Jsi plnoletý.");

            Console.WriteLine();
        }

        Console.WriteLine("Program ukončen.");
    }
}
*/
/*
using System;

class Program //Procedura (jen vypíše text)
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Tento text se vypíše opakovaně.");
        }
    }
}
*/
/*
using System;

class Program //Funkce (Vypočítá a vrátí)
{
    static void Main()
    {
        int soucet = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Zadej číslo:");
            int cislo = int.Parse(Console.ReadLine());

            soucet += cislo;
            Console.WriteLine("Aktuální součet je: " + soucet);
            Console.WriteLine();
        }

        Console.WriteLine("Konečný součet všech čísel je: " + soucet);
    }
}
*/