using System;

// Definition der Auto-Klasse
class Auto
{
    // Eigenschaften (Properties)
    public string Marke { get; set; }
    public string Modell { get; set; }
    public int Baujahr { get; set; }
    public double Kilometerstand { get; private set; }
    public bool IstGestartet { get; private set; }

    // Konstruktor
    public Auto(string marke, string modell, int baujahr)
    {
        Marke = marke;
        Modell = modell;
        Baujahr = baujahr;
        Kilometerstand = 0;
        IstGestartet = false;

        Console.WriteLine($"Neues Auto erstellt: {Marke} {Modell} ({Baujahr})");
    }

    // Methoden
    public void Starten()
    {
        IstGestartet = true;
        Console.WriteLine($"{Marke} {Modell} wurde gestartet.");
    }

    public void Fahren(double kilometer)
    {
        if (!IstGestartet)
        {
            Console.WriteLine("Auto ist nicht gestartet!");
            return;
        }

        Kilometerstand += kilometer;
        Console.WriteLine($"{Marke} {Modell} fuhr {kilometer} km. Gesamt: {Kilometerstand} km.");
    }
}


    

