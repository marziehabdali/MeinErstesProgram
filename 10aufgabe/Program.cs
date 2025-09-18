using System;
using System.Collections.Generic;

class EinkaufslistenManager
{
    static void Main()
    {
        List<string> einkaufsliste = new List<string>();

        Console.WriteLine("=== Einkaufslisten-Manager (einfach) ===");

        while (true)
        {
            Console.WriteLine("\n--- MENÜ ---");
            Console.WriteLine("1. Artikel hinzufügen");
            Console.WriteLine("2. Liste anzeigen");
            Console.WriteLine("0. Beenden");

            Console.Write("Option wählen: ");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                case 1:
                    Console.Write("Artikelname eingeben: ");
                    string artikel = Console.ReadLine();
                    einkaufsliste.Add(artikel);
                    Console.WriteLine($"'{artikel}' wurde hinzugefügt.");
                    break;

                case 2:
                    if (einkaufsliste.Count == 0)
                        Console.WriteLine("Die Einkaufsliste ist leer.");
                    else
                    {
                        Console.WriteLine("\nEINKAUFSLISTE:");
                        for (int i = 0; i < einkaufsliste.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {einkaufsliste[i]}");
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Auf Wiedersehen!");
                    return;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }
}
