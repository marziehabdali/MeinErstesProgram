using System;


class PersonalisierteBegruessung
{
    static void Main()
    {
        Console.WriteLine("=== Personalisierte Begrüßung ===\n");

        Console.Write("Wie ist Ihr Vorname? ");
        string vorname = Console.ReadLine();

        Console.Write("Wie ist Ihr Nachname? ");
        string nachname = Console.ReadLine();

        Console.Write("In welcher Stadt wohnen Sie? ");
        string stadt = Console.ReadLine();

        Console.Write("Was ist Ihr Lieblingshobby? ");
        string hobby = Console.ReadLine();

        Console.WriteLine("\n===== IHRE INFORMATIONEN =====");
        Console.WriteLine($"Hallo {vorname} {nachname}!");
        Console.WriteLine($"Schön, dass Sie aus {stadt} kommen.");
        Console.WriteLine($"Ihr Hobby '{hobby}' klingt sehr interessant!");
        Console.WriteLine("\nVielen Dank für Ihre Teilnahme!");

        Console.ReadKey();
    }
}
