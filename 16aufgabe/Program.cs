using System;
using System.Collections.Generic;

// Interface für abspielbare Medien
interface IAbspielbar
{
    string Titel { get; }
    void Abspielen();
    void Pausieren();
    void Stoppen();
    bool IstAmAbspielen { get; }
}

// Interface für bewertbare Inhalte
interface IBewertbar
{
    void Bewerten(double bewertung);
    double DurchschnittsBewertung { get; }
}

// Basisklasse Medium
abstract class Medium
{
    protected string titel;
    protected string kuenstler;

    public Medium(string titel, string kuenstler)
    {
        this.titel = titel;
        this.kuenstler = kuenstler;
    }

    public string TitelName => titel;
    public string Kuenstler => kuenstler;
}

// Musikdatei implementiert Interfaces
class Musikdatei : Medium, IAbspielbar, IBewertbar
{
    private bool amAbspielen;
    private bool pausiert;
    private List<double> bewertungen;

    public Musikdatei(string titel, string kuenstler) : base(titel, kuenstler)
    {
        amAbspielen = false;
        pausiert = false;
        bewertungen = new List<double>();
    }

    // IAbspielbar
    public string Titel => titel;
    public bool IstAmAbspielen => amAbspielen && !pausiert;

    public void Abspielen()
    {
        amAbspielen = true;
        pausiert = false;
        Console.WriteLine($"'{titel}' wird abgespielt!");
    }

    public void Pausieren()
    {
        if (amAbspielen)
        {
            pausiert = true;
            Console.WriteLine($"'{titel}' pausiert.");
        }
    }

    public void Stoppen()
    {
        amAbspielen = false;
        pausiert = false;
        Console.WriteLine($"'{titel}' gestoppt.");
    }

    // IBewertbar
    public void Bewerten(double bewertung)
    {
        bewertungen.Add(bewertung);
        Console.WriteLine($"'{titel}' wurde mit {bewertung} bewertet.");
    }

    public double DurchschnittsBewertung
    {
        get
        {
            if (bewertungen.Count == 0) return 0;
            double sum = 0;
            foreach (var b in bewertungen) sum += b;
            return sum / bewertungen.Count;
        }
    }
}

// Hauptprogramm
class Program
{
    static void Main()
    {
        Musikdatei song = new Musikdatei("Mein Song", "Max Mustermann");

        song.Abspielen();
        song.Pausieren();
        song.Abspielen();
        song.Stoppen();

        song.Bewerten(4.5);
        song.Bewerten(5.0);
        Console.WriteLine($"Durchschnittsbewertung: {song.DurchschnittsBewertung:F1}");

        Console.ReadKey();
    }
}

