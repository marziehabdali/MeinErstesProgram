
using System;

class AltersKategorisierung
{
    static void Main()
    {
        Console.WriteLine("=== Alters-Kategorisierung ===");
        Console.Write("Bitte geben Sie Ihr Alter ein: ");

        int alter = Convert.ToInt32(Console.ReadLine());
        string kategorie;
        string beschreibung;

        if (alter < 0)
        {
            kategorie = "Ungültiges Alter";
            beschreibung = "Das Alter kann nicht negativ sein.";
        }
        else if (alter <= 12)
        {
            kategorie = "Kind";
            beschreibung = "Sie befinden sich in der Kindheit und entdecken die Welt.";
        }
        else if (alter <= 17)
        {
            kategorie = "Jugendlicher";
            beschreibung = "Die Teenage-Jahre sind eine Zeit des Wachstums und der Veränderung.";
        }
        else if (alter <= 64)
        {
            kategorie = "Erwachsener";
            beschreibung = "Sie sind in der produktivsten Phase Ihres Lebens.";
        }
        else if (alter <= 120)
        {
            kategorie = "Senior";
            beschreibung = "Sie haben viel Lebenserfahrung und Weisheit gesammelt.";
        }
        else
        {
            kategorie = "Ungewöhnliches Alter";
            beschreibung = "Bitte überprüfen Sie Ihre Eingabe.";
        }

        Console.WriteLine($"\nIhr Alter: {alter} Jahre");
        Console.WriteLine($"Kategorie: {kategorie}");
        Console.WriteLine($"Beschreibung: {beschreibung}");

        if (alter >= 18)
        {
            Console.WriteLine("Sie sind volljährig und dürfen wählen.");
        }

        if (alter >= 21)
        {
            Console.WriteLine("In den USA dürften Sie Alkohol kaufen.");
        }

        Console.ReadKey();
    }
}
