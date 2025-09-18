using System;

class MathematischeMethoden
{
    // Methode für Addition
    static double Addieren(double a, double b)
    {
        return a + b;
    }

    // Methode für Kreisflächenberechnung
    static double Kreisflaeche(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        Console.WriteLine("=== Einfache Methoden Demo ===");

        // Addition testen
        double summe = Addieren(10, 20);
        Console.WriteLine($"10 + 20 = {summe}");

        // Kreisfläche berechnen
        double flaeche = Kreisflaeche(5);
        Console.WriteLine($"Kreisfläche (r=5) = {flaeche:F2}");

        Console.ReadKey();
    }
}

