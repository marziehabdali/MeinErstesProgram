using System;

class ZahlenRateSpiel
{
    static void Main()
    {
        Console.WriteLine("=== Zahlen-Rate-Spiel ===");
        Console.WriteLine("Ich denke an eine Zahl zwischen 1 und 100!");

        Random zufallsGenerator = new Random();
        int geheimeZahl = zufallsGenerator.Next(1, 101); // Zahl zwischen 1-100
        int versuche = 0;
        int maxVersuche = 7;
        bool erraten = false;

        Console.WriteLine($"Sie haben {maxVersuche} Versuche. Viel Glück!\n");

        while (!erraten && versuche < maxVersuche)
        {
            versuche++;
            Console.Write($"Versuch {versuche}: Ihre Vermutung (1-100): ");
            int vermutung = Convert.ToInt32(Console.ReadLine());

            if (vermutung == geheimeZahl)
            {
                erraten = true;
                Console.WriteLine($"Herzlichen Glückwunsch! Sie haben die Zahl {geheimeZahl} erraten.");
            }
            else if (vermutung < geheimeZahl)
            {
                Console.WriteLine("Die geheime Zahl ist größer.\n");
            }
            else
            {
                Console.WriteLine("Die geheime Zahl ist kleiner.\n");
            }
        }

        if (!erraten)
        {
            Console.WriteLine($"Leider nicht geschafft. Die Zahl war {geheimeZahl}.");
        }

        Console.ReadKey();
    }
}
