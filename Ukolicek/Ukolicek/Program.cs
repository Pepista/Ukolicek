/*
using System;

class Program
{
    // Hlavní metoda programu
    static void Main()
    {
        Console.Write("Zadej svůj věk: ");
        int vek = int.Parse(Console.ReadLine());

        string vysledek = VyhodnotVek(vek); // volání funkce
        VypisZpravu(vysledek);              // volání procedury
    }

    // Funkce – vyhodnotí věk a vrátí text
    static string VyhodnotVek(int vek)
    {
        if (vek < 0)
            return "Věk nemůže být záporný.";
        else if (vek < 18)
            return "Jsi nezletilý.";
        else
            return "Jsi plnoletý.";
    }

    // Procedura – pouze vypíše text
    static void VypisZpravu(string text)
    {
        Console.WriteLine(text);
    }
}
*/

/*
 using System;

class Program
{
    // Hlavní metoda programu
    static void Main()
    {
        VypisText(); // volání procedury
    }

    // Procedura – vypíše text 5×
    static void VypisText()
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

class Program
{
    // Hlavní metoda programu
    static void Main()
    {
        int soucet = SpocitejSoucet(); // volání funkce
        VypisVysledek(soucet);         // volání procedury
    }

    // Funkce – načte 5 čísel a vrátí jejich součet
    static int SpocitejSoucet()
    {
        int soucet = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Zadej číslo: ");
            int cislo = int.Parse(Console.ReadLine());
            soucet += cislo;
        }

        return soucet;
    }

    // Procedura – vypíše konečný součet
    static void VypisVysledek(int soucet)
    {
        Console.WriteLine("Konečný součet je: " + soucet);
    }
}

 */

//------------------------------------------------------------------------------

/*
using System;

class Program
{
    static void Main()
    {
        VypisCisla(5); // volání procedury
    }

    // Procedura – vypíše čísla od 1 do n
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
        int vysledek = Nasob(3, 4);       // volání funkce
        Console.WriteLine("Součin je: " + vysledek);
    }

    // Funkce – vrátí součin dvou čísel
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

        ZvysHodnotou(cislo);              // předání hodnotou – nepřepíše původní proměnnou
        Console.WriteLine("Po předání hodnotou: " + cislo);

        ZvysOdkazem(ref cislo);            // předání odkazem – přepíše původní proměnnou
        Console.WriteLine("Po předání odkazem: " + cislo);
    }

    // Procedura – zvýší hodnotu lokálně (předání hodnotou)
    static void ZvysHodnotou(int x)
    {
        x += 10;
    }

    // Procedura – zvýší hodnotu přímo v původní proměnné (předání odkazem)
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

        string vysledek = PopisVeku(vek); // volání funkce
        Console.WriteLine("Výsledek: " + vysledek);
    }

    // Funkce – vrátí textový popis věku
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