using System;
using System.Collections.Generic;

// Event-Argumente
public class NachrichtEventArgs : EventArgs
{
    public string Von { get; }
    public string An { get; }
    public string Inhalt { get; }
    public DateTime Zeitstempel { get; }

    public NachrichtEventArgs(string von, string an, string inhalt)
    {
        Von = von;
        An = an;
        Inhalt = inhalt;
        Zeitstempel = DateTime.Now;
    }
}

public class SystemEventArgs : EventArgs
{
    public string Status { get; }
    public string Details { get; }
    public DateTime Zeitstempel { get; }

    public SystemEventArgs(string status, string details)
    {
        Status = status;
        Details = details;
        Zeitstempel = DateTime.Now;
    }
}

// Nachrichtenzentrale (Publisher)
class Nachrichtenzentrale
{
    public event EventHandler<NachrichtEventArgs> NachrichtGesendet;
    public event EventHandler<NachrichtEventArgs> NachrichtEmpfangen;
    public event EventHandler<SystemEventArgs> SystemStatusGeaendert;

    private List<string> angemeldeteBenutzer;
    private Dictionary<string, List<string>> nachrichtenVerlauf;

    public Nachrichtenzentrale()
    {
        angemeldeteBenutzer = new List<string>();
        nachrichtenVerlauf = new Dictionary<string, List<string>>();
        SystemStatusAendern("Init", "Nachrichtenzentrale gestartet");
    }

    public void BenutzerAnmelden(string benutzer)
    {
        if (!angemeldeteBenutzer.Contains(benutzer))
        {
            angemeldeteBenutzer.Add(benutzer);
            nachrichtenVerlauf[benutzer] = new List<string>();
            SystemStatusAendern("Benutzer angemeldet", benutzer);
        }
    }

    public void NachrichtSenden(string von, string an, string inhalt)
    {
        if (!angemeldeteBenutzer.Contains(von) || !angemeldeteBenutzer.Contains(an))
        {
            SystemStatusAendern("Fehler", "Sender oder Empfänger nicht angemeldet");
            return;
        }

        string nachrichtMitZeit = $"[{DateTime.Now:HH:mm:ss}] Von {von}: {inhalt}";
        nachrichtenVerlauf[an].Add(nachrichtMitZeit);

        var args = new NachrichtEventArgs(von, an, inhalt);
        NachrichtGesendet?.Invoke(this, args);
        NachrichtEmpfangen?.Invoke(this, args);
    }

    private void SystemStatusAendern(string status, string details)
    {
        SystemStatusGeaendert?.Invoke(this, new SystemEventArgs(status, details));
    }

    public void NachrichtenVerlaufAnzeigen(string benutzer)
    {
        if (nachrichtenVerlauf.ContainsKey(benutzer))
        {
            Console.WriteLine($"\n--- Nachrichten für {benutzer} ---");
            foreach (var msg in nachrichtenVerlauf[benutzer])
            {
                Console.WriteLine(msg);
            }
        }
    }
}

// Subscriber (Handler)
class SystemLogger
{
    public void OnSystemStatusGeaendert(object sender, SystemEventArgs e)
    {
        Console.WriteLine($"[SystemLogger] {e.Zeitstempel:HH:mm:ss} Status: {e.Status}, Details: {e.Details}");
    }
}

class Programm
{
    static void Main()
    {
        Nachrichtenzentrale zentrale = new Nachrichtenzentrale();
        SystemLogger logger = new SystemLogger();

        zentrale.SystemStatusGeaendert += logger.OnSystemStatusGeaendert;

        // Benutzer anmelden
        zentrale.BenutzerAnmelden("Anna");
        zentrale.BenutzerAnmelden("Ben");

        // Nachrichten senden
        zentrale.NachrichtSenden("Anna", "Ben", "Hallo Ben!");
        zentrale.NachrichtSenden("Ben", "Anna", "Hi Anna!");

        // Nachrichten anzeigen
        zentrale.NachrichtenVerlaufAnzeigen("Anna");
        zentrale.NachrichtenVerlaufAnzeigen("Ben");

        Console.ReadKey();
    }
}

