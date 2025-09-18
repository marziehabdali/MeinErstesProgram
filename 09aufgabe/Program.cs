using System;

class NotenVerwaltung
{
    static void Main()
    {
        Console.WriteLine("=== Notenverwaltungs-System ===");

        // Array für Studentennamen
        string[] studenten = { "Anna", "Ben", "Clara", "David", "Emma" };

        // Array für Noten (gleiche Reihenfolge wie Studenten)
        double[] noten = new double[studenten.Length];

        // Noten eingeben
        Console.WriteLine("Bitte geben Sie die Noten ein (1.0 - 6.0):");
        for (int i = 0; i < studenten.Length; i++)
        {
            Console.Write($"Note für {studenten[i]}: ");
            noten[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Berechnungen durchführen
        double summe = 0;
        double beste = noten[0];
        double schlechteste = noten[0];
        string besterStudent = studenten[0];
        string schlechtesterStudent = studenten[0];

        for (int i = 0; i < noten.Length; i++)
        {
            summe += noten[i];

            if (noten[i] < beste) // Niedrigere Note = besser
            {
                beste = noten[i];
                besterStudent = studenten[i];
            }

            if (noten[i] > schlechteste) // Höhere Note = schlechter
            {
                schlechteste = noten[i];
                schlechtesterStudent = studenten[i];
            }
        }

        double durchschnitt = summe / noten.Length;

        // Ergebnisse ausgeben
        Console.WriteLine("\n=== AUSWERTUNG ===");
        Console.WriteLine("Alle Noten im Überblick:");
        for (int i = 0; i < studenten.Length; i++)
        {
            Console.WriteLine($"{studenten[i]}: {noten[i]:F1}");
        }

        Console.WriteLine($"\nStatistiken:");
        Console.WriteLine($"Durchschnittsnote: {durchschnitt:F2}");
        Console.WriteLine($"Beste Note: {beste:F1} ({besterStudent})");
        Console.WriteLine($"Schlechteste Note: {schlechteste:F1} ({schlechtesterStudent})");

        // Bestanden/Durchgefallen
        Console.WriteLine($"\nStatus der Studenten:");
        for (int i = 0; i < studenten.Length; i++)
        {
            string status = noten[i] <= 4.0 ? "BESTANDEN" : "DURCHGEFALLEN";
            Console.WriteLine($"{studenten[i]}: {status}");
        }

        Console.ReadKey();
    }
}
