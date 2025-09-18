using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

// Klasse für JSON/XML Serialisierung
[Serializable]
public class Person
{
    public string Name { get; set; } = "";
    public int Alter { get; set; }
    public string Email { get; set; } = "";
    public List<string> Hobbys { get; set; } = new List<string>();
    public DateTime RegistrierungsDatum { get; set; }

    public Person() { } // Für Serialisierung nötig

    public Person(string name, int alter, string email)
    {
        Name = name;
        Alter = alter;
        Email = email;
        RegistrierungsDatum = DateTime.Now;
    }

    public void HobbyHinzufuegen(string hobby)
    {
        if (!Hobbys.Contains(hobby))
            Hobbys.Add(hobby);
    }

    public override string ToString()
    {
        return $"{Name} ({Alter}J) - {Email} | Hobbys: {string.Join(", ", Hobbys)}";
    }
}

// Personen-Verwaltung mit Datei-Operationen
public class PersonenVerwaltung
{
    private List<Person> personen;
    private string basisPfad;

    public PersonenVerwaltung(string basisPfad = "PersonenDaten")
    {
        this.basisPfad = basisPfad;
        this.personen = new List<Person>();

        // Verzeichnis erstellen, falls nicht vorhanden
        if (!Directory.Exists(basisPfad))
        {
            Directory.CreateDirectory(basisPfad);
            Console.WriteLine($"Ordner '{basisPfad}' erstellt.");
        }
    }

    // Person hinzufügen
    public void PersonHinzufuegen(Person p)
    {
        personen.Add(p);
        Console.WriteLine($"Person {p.Name} hinzugefügt.");
    }

    // In JSON speichern
    public void SpeichernAlsJson(string dateiName)
    {
        string pfad = Path.Combine(basisPfad, dateiName);
        string json = JsonSerializer.Serialize(personen, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(pfad, json);
        Console.WriteLine($"Daten als JSON gespeichert: {pfad}");
    }

    // Aus JSON laden
    public void LadenAusJson(string dateiName)
    {
        string pfad = Path.Combine(basisPfad, dateiName);
        if (File.Exists(pfad))
        {
            string json = File.ReadAllText(pfad);
            personen = JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
            Console.WriteLine($"Daten aus JSON geladen: {pfad}");
        }
        else
        {
            Console.WriteLine($"Datei existiert nicht: {pfad}");
        }
    }

    // Anzeige aller Personen
    public void AllePersonenAnzeigen()
    {
        Console.WriteLine("\n=== Personenliste ===");
        foreach (var p in personen)
        {
            Console.WriteLine(p);
        }
    }
}

// Demo-Programm
class DateiIODemo
{
    static void Main()
    {
        var verwaltung = new PersonenVerwaltung();

        // Neue Personen erstellen
        var anna = new Person("Anna", 25, "anna@mail.de");
        anna.HobbyHinzufuegen("Lesen");
        anna.HobbyHinzufuegen("Reisen");

        var max = new Person("Max", 30, "max@mail.de");
        max.HobbyHinzufuegen("Fußball");

        // Hinzufügen
        verwaltung.PersonHinzufuegen(anna);
        verwaltung.PersonHinzufuegen(max);

        // Anzeige
        verwaltung.AllePersonenAnzeigen();

        // Speichern
        verwaltung.SpeichernAlsJson("personen.json");

        // Leeren und wieder Laden
        Console.WriteLine("\nListe leeren und wieder aus JSON laden...");
        verwaltung = new PersonenVerwaltung();
        verwaltung.LadenAusJson("personen.json");
        verwaltung.AllePersonenAnzeigen();

        Console.ReadKey();
    }
}

