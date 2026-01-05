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
/*
using System;

class Program
{
    static void Main()
    {
        VypisCisla(5);
    }

    static void VypisCisla(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int vysledek = Nasob(3, 4);
        Console.WriteLine("Součin je: " + vysledek);
    }

    static int Nasob(int a, int b)
    {
        return a * b;
    }
}

*/
/*
 using System;

class Program
{
    static void Main()
    {
        int cislo = 20;

        ZvysHodnotou(cislo);
        Console.WriteLine("Po předání hodnotou: " + cislo);

        ZvysOdkazem(ref cislo);
        Console.WriteLine("Po předání odkazem: " + cislo);
    }

    static void ZvysHodnotou(int x)
    {
        x += 10;
    }

    static void ZvysOdkazem(ref int x)
    {
        x += 10;
    }
}

 */
/*
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej svůj věk: ");
        int vek = int.Parse(Console.ReadLine());

        string vysledek = PopisVeku(vek);
        Console.WriteLine("Výsledek: " + vysledek);
    }

    static string PopisVeku(int vek)
    {
        if (vek < 10)
            return "Dítě";
        else if (vek <= 17)
            return "Školák";
        else
            return "Dospělý";
    }
}
 */