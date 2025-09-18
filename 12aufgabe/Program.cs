using System;

class MethodenUeberladung
{
    // Überladung 1: Zwei ganze Zahlen
    static int Maximum(int a, int b)
    {
        Console.WriteLine($"Vergleiche zwei int-Werte: {a} und {b}");
        return a > b ? a : b;
    }

    // Überladung 2: Drei ganze Zahlen
    static int Maximum(int a, int b, int c)
    {
        Console.WriteLine($"Vergleiche drei int-Werte: {a}, {b} und {c}");
        int max = Maximum(a, b); // ruft Überladung 1 auf
        return Maximum(max, c);
    }

    // Überladung 3: Zwei Dezimalzahlen
    static double Maximum(double a, double b)
    {
        Console.WriteLine($"Vergleiche zwei double-Werte: {a} und {b}");
        return a > b ? a : b;
    }

    // Überladung 4: Array von ganzen Zahlen
    static int Maximum(int[] zahlen)
    {
        if (zahlen.Length == 0)
            throw new ArgumentException("Array darf nicht leer sein");

        Console.WriteLine($"Vergleiche {zahlen.Length} Werte im Array");
        int max = zahlen[0];
        for (int i = 1; i < zahlen.Length; i++)
        {
            if (zahlen[i] > max)
                max = zahlen[i];
        }
        return max;
    }

    // Begrüßungen (verschiedene Überladungen)
    static void Begruessen(string name)
    {
        Console.WriteLine($"Hallo, {name}!");
    }

    static void Begruessen(string vorname, string nachname)
    {
        Console.WriteLine($"Hallo, {vorname} {nachname}!");
    }

    static void Begruessen(string name, int alter)
    {
        Console.WriteLine($"Hallo, {name}! Sie sind {alter} Jahre alt.");
    }

    static void Begruessen(string name, string titel, bool formal)
    {
        if (formal)
            Console.WriteLine($"Guten Tag, {titel} {name}.");
        else
            Console.WriteLine($"Hi {name}, schön Sie zu sehen!");
    }

    static void Main()
    {
        Console.WriteLine("=== Methoden-Überladung Demo ===\n");

        // Maximum-Methoden testen
        Console.WriteLine("--- Maximum-Berechnungen ---");
        int max1 = Maximum(10, 25);
        Console.WriteLine($"Ergebnis: {max1}\n");

        int max2 = Maximum(10, 25, 15);
        Console.WriteLine($"Ergebnis: {max2}\n");

        double max3 = Maximum(10.7, 25.3);
        Console.WriteLine($"Ergebnis: {max3}\n");

        int[] zahlenArray = { 45, 12, 67, 23, 89, 34 };
        int max4 = Maximum(zahlenArray);
        Console.WriteLine($"Ergebnis: {max4}\n");

        // Begrüßungen testen
        Console.WriteLine("--- Begrüßungen ---");
        Begruessen("Anna");
        Begruessen("Max", "Mustermann");
        Begruessen("Lisa", 28);
        Begruessen("Schmidt", "Dr.", true);
        Begruessen("Tom", "Prof.", false);

        // Automatische Auswahl der passenden Methode
        Console.WriteLine("\n--- Automatische Typauswahl ---");
        Console.WriteLine($"Maximum(5, 10) → {Maximum(5, 10)}");
        Console.WriteLine($"Maximum(5.5, 10.2) → {Maximum(5.5, 10.2)}");

        Console.ReadKey();
    }
}
