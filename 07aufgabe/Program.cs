using System;

class ForSchleifenDemo
{
    static void Main()
    {
        Console.WriteLine("=== For-Schleifen Demonstration ===\n");

        // 1. Einfache Zählung
        Console.WriteLine("1. Zahlen von 1 bis 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 2. Rückwärts zählen
        Console.WriteLine("2. Countdown von 10 bis 1:");
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 3. Nur gerade Zahlen
        Console.WriteLine("3. Gerade Zahlen von 2 bis 20:");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 4. Multiplikationstabelle
        Console.Write("Für welche Zahl möchten Sie die Multiplikationstabelle? ");
        int zahl = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nMultiplikationstabelle für {zahl}:");

        for (int i = 1; i <= 10; i++)
        {
            int ergebnis = zahl * i;
            Console.WriteLine($"{zahl} x {i} = {ergebnis}");
        }

        // 5. Verschachtelte Schleifen - Muster
        Console.WriteLine("\n5. Stern-Muster:");
        for (int zeile = 1; zeile <= 5; zeile++)
        {
            for (int stern = 1; stern <= zeile; stern++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
