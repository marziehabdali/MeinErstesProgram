using System;

class Aufgabe17
{
    static void Main()
    {
        Console.WriteLine("=== Aufgabe 17: Benutzerinteraktion & Fehlerbehandlung ===\n");

        // 1. Ganzzahl-Eingabe
        GanzzahlDemo();

        // 2. Kommazahlen-Eingabe
        KommazahlDemo();

        // 3. Auswahlmenü mit robustem Input
        MenueDemo();

        Console.WriteLine("\nAlles fertig!");
        Console.ReadKey();
    }

    // 1. Ganzzahl-Eingabe
    static void GanzzahlDemo()
    {
        Console.WriteLine("--- Ganzzahl Demo ---");
        while (true)
        {
            try
            {
                Console.Write("Bitte eine ganze Zahl eingeben: ");
                int zahl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Du hast {zahl} eingegeben.");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ungültige Eingabe! Bitte eine ganze Zahl eingeben.");
            }
        }
    }

    // 2. Kommazahlen-Eingabe
    static void KommazahlDemo()
    {
        Console.WriteLine("\n--- Kommazahl Demo ---");
        while (true)
        {
            try
            {
                Console.Write("Bitte eine Kommazahl eingeben: ");
                double wert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Du hast {wert:F2} eingegeben.");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ungültige Eingabe! Bitte eine gültige Zahl eingeben.");
            }
        }
    }

    // 3. Einfaches Menü
    static void MenueDemo()
    {
        Console.WriteLine("\n--- Menü Demo ---");
        while (true)
        {
            Console.WriteLine("\n1. Option A");
            Console.WriteLine("2. Option B");
            Console.WriteLine("0. Beenden");
            Console.Write("Wähle eine Option: ");

            try
            {
                int auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Du hast Option A gewählt!");
                        break;
                    case 2:
                        Console.WriteLine("Du hast Option B gewählt!");
                        break;
                    case 0:
                        Console.WriteLine("Beenden...");
                        return; // Schleife verlassen
                    default:
                        Console.WriteLine("Ungültige Auswahl!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Bitte eine ganze Zahl eingeben!");
            }
        }
    }
}

