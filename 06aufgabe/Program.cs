using System;

class WochentagInfo
{
    static void Main()
    {
        Console.WriteLine("=== Wochentag-Informationen ===");
        Console.WriteLine("Geben Sie eine Zahl von 1-7 ein (1=Montag, 7=Sonntag):");
        int tagNummer = Convert.ToInt32(Console.ReadLine());

        string tagName;
        string arbeitsTag;
        string besonderheit;

        switch (tagNummer)
        {
            case 1:
                tagName = "Montag";
                arbeitsTag = "Arbeitstag";
                besonderheit = "Start in die neue Woche - oft als 'Blue Monday' bezeichnet";
                break;
            case 2:
                tagName = "Dienstag";
                arbeitsTag = "Arbeitstag";
                besonderheit = "Oft der produktivste Tag der Woche";
                break;
            case 3:
                tagName = "Mittwoch";
                arbeitsTag = "Arbeitstag";
                besonderheit = "Bergfest - die Wochenmitte ist erreicht";
                break;
            case 4:
                tagName = "Donnerstag";
                arbeitsTag = "Arbeitstag";
                besonderheit = "Das Wochenende rückt näher";
                break;
            case 5:
                tagName = "Freitag";
                arbeitsTag = "Arbeitstag";
                besonderheit = "TGIF - Thank God It's Friday!";
                break;
            case 6:
                tagName = "Samstag";
                arbeitsTag = "Wochenende";
                besonderheit = "Zeit für Familie, Freunde und Hobbys";
                break;
            case 7:
                tagName = "Sonntag";
                arbeitsTag = "Wochenende";
                besonderheit = "Ruhetag und Vorbereitung auf die neue Woche";
                break;
            default:
                tagName = "Unbekannt";
                arbeitsTag = "Ungültig";
                besonderheit = "Bitte geben Sie eine Zahl zwischen 1 und 7 ein";
                break;
        }

        Console.WriteLine($"\nTag Nummer: {tagNummer}");
        Console.WriteLine($"Wochentag: {tagName}");
        Console.WriteLine($"Typ: {arbeitsTag}");
        Console.WriteLine($"Besonderheit: {besonderheit}");

        Console.ReadKey();
    }
}


