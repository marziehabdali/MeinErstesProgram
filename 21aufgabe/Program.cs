using System;
using System.Threading.Tasks;

class AsyncDemo
{
    // Simulierte zeitaufwändige Datenbankabfrage
    static async Task<string> DatenAusDatenbank(string benutzerId)
    {
        Console.WriteLine($"Starte Datenbankabfrage für Benutzer {benutzerId}...");
        await Task.Delay(2000); // Simuliere 2 Sekunden Wartezeit
        return $"Daten für {benutzerId} sind geladen!";
    }

    // Simulierte Dateioperation
    static async Task<string> DateiLesenAsync(string dateiname)
    {
        Console.WriteLine($"Lese Datei {dateiname}...");
        await Task.Delay(1500); // Simuliere 1,5 Sekunden Wartezeit
        return $"Inhalt von {dateiname} ist gelesen!";
    }

    // Hauptmethode
    static async Task Main()
    {
        Console.WriteLine("=== Async/Await Demo ===");

        // Zwei Tasks gleichzeitig starten
        Task<string> datenTask = DatenAusDatenbank("Anna");
        Task<string> dateiTask = DateiLesenAsync("text.txt");

        // Hier kann der Hauptthread andere Dinge machen
        Console.WriteLine("Hauptprogramm arbeitet während Tasks laufen...");

        // Auf Ergebnisse warten
        string datenErgebnis = await datenTask;
        string dateiErgebnis = await dateiTask;

        // Ergebnisse ausgeben
        Console.WriteLine(datenErgebnis);
        Console.WriteLine(dateiErgebnis);

        Console.WriteLine("Alle Tasks sind abgeschlossen.");
    }
}
