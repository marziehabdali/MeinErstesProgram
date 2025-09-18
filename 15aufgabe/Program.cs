using System;

// Basisklasse Fahrzeug
abstract class Fahrzeug
{
    public string Marke { get; set; }
    public string Modell { get; set; }
    public bool IstGestartet { get; private set; }
    public double Geschwindigkeit { get; private set; }

    public Fahrzeug(string marke, string modell)
    {
        Marke = marke;
        Modell = modell;
        Geschwindigkeit = 0;
        IstGestartet = false;
    }

    public virtual void Starten()
    {
        IstGestartet = true;
        Console.WriteLine($"{Marke} {Modell} gestartet!");
    }

    public virtual void Anhalten()
    {
        IstGestartet = false;
        Geschwindigkeit = 0;
        Console.WriteLine($"{Marke} {Modell} angehalten!");
    }

    public abstract void Beschleunigen(double kmh);

    public void StatusAnzeigen()
    {
        Console.WriteLine($"{Marke} {Modell} - Status: {(IstGestartet ? "Gestartet" : "Gestoppt")}, Geschwindigkeit: {Geschwindigkeit} km/h");
    }

    protected void SetGeschwindigkeit(double kmh)
    {
        Geschwindigkeit = kmh;
    }
}

// Abgeleitete Klasse Auto
class Auto : Fahrzeug
{
    public Auto(string marke, string modell) : base(marke, modell) { }

    public override void Beschleunigen(double kmh)
    {
        if (!IstGestartet)
        {
            Console.WriteLine("Auto muss zuerst gestartet werden!");
            return;
        }
        SetGeschwindigkeit(kmh);
        Console.WriteLine($"{Marke} {Modell} beschleunigt auf {kmh} km/h");
    }

    public void Hupen()
    {
        Console.WriteLine($"{Marke} {Modell} hupt: Huuup!");
    }
}

// Abgeleitete Klasse Motorrad
class Motorrad : Fahrzeug
{
    public Motorrad(string marke, string modell) : base(marke, modell) { }

    public override void Beschleunigen(double kmh)
    {
        if (!IstGestartet)
        {
            Console.WriteLine("Motorrad muss zuerst gestartet werden!");
            return;
        }
        SetGeschwindigkeit(kmh);
        Console.WriteLine($"{Marke} {Modell} rast auf {kmh} km/h");
    }

    public void Wheelie()
    {
        Console.WriteLine($"{Marke} {Modell} macht einen Wheelie! 🏍️");
    }
}

// Hauptprogramm
class Program
{
    static void Main()
    {
        // Polymorphismus: beide Fahrzeuge als Fahrzeug-Objekte
        Fahrzeug auto = new Auto("VW", "Golf");
        Fahrzeug motorrad = new Motorrad("KTM", "Duke");

        auto.Starten();
        auto.Beschleunigen(100);
        ((Auto)auto).Hupen();
        auto.StatusAnzeigen();

        motorrad.Starten();
        motorrad.Beschleunigen(120);
        ((Motorrad)motorrad).Wheelie();
        motorrad.StatusAnzeigen();

        Console.ReadKey();
    }
}


