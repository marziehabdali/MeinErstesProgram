using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Alter { get; set; }
    public string Studiengang { get; set; }
    public double Notendurchschnitt { get; set; }
    public int Semester { get; set; }
    public string Stadt { get; set; }

    public Student(string name, int alter, string studiengang, double note, int semester, string stadt)
    {
        Name = name;
        Alter = alter;
        Studiengang = studiengang;
        Notendurchschnitt = note;
        Semester = semester;
        Stadt = stadt;
    }

    public override string ToString()
    {
        return $"{Name} ({Alter}J) - {Studiengang}, {Semester}. Sem., #{Notendurchschnitt:F1}, {Stadt}";
    }
}

class LINQDemoSimple
{
    static void Main()
    {
        Console.WriteLine("=== LINQ Demo: Studentendaten ===\n");

        // Testdaten
        List<Student> studenten = new List<Student>
        {
            new Student("Anna", 22, "Informatik", 1.7, 6, "Berlin"),
            new Student("Ben", 20, "Mathematik", 2.3, 4, "München"),
            new Student("Clara", 24, "Informatik", 1.2, 8, "Hamburg"),
            new Student("David", 19, "Physik", 2.8, 2, "Berlin"),
            new Student("Emma", 21, "Mathematik", 1.9, 4, "Köln")
        };

        Console.WriteLine($"Gesamtanzahl Studenten: {studenten.Count}\n");

        // 1. Filter: Informatik-Studenten
        var infoStudents = studenten.Where(s => s.Studiengang == "Informatik");
        Console.WriteLine("--- Informatik-Studenten ---");
        foreach (var s in infoStudents)
        {
            Console.WriteLine($" {s}");
        }

        // 2. Nur Namen mit SELECT
        var namen = studenten.Select(s => s.Name);
        Console.WriteLine("\n--- Alle Namen ---");
        Console.WriteLine(string.Join(", ", namen));

        // 3. Sortierung nach Notendurchschnitt
        var nachNoten = studenten.OrderBy(s => s.Notendurchschnitt);
        Console.WriteLine("\n--- Nach Noten sortiert ---");
        foreach (var s in nachNoten)
        {
            Console.WriteLine($" {s}");
        }

        // 4. Gruppierung nach Studiengang
        var gruppen = studenten.GroupBy(s => s.Studiengang);
        Console.WriteLine("\n--- Gruppierung nach Studiengang ---");
        foreach (var g in gruppen)
        {
            Console.WriteLine($"\n{g.Key} ({g.Count()} Studenten):");
            foreach (var s in g)
            {
                Console.WriteLine($" {s}");
            }
        }

        // 5. Durchschnittsnoten pro Stadt
        var nachStadt = studenten.GroupBy(s => s.Stadt)
                                 .Select(g => new { Stadt = g.Key, Durchschnitt = g.Average(s => s.Notendurchschnitt) });
        Console.WriteLine("\n--- Durchschnittsnoten pro Stadt ---");
        foreach (var s in nachStadt)
        {
            Console.WriteLine($" {s.Stadt}: {s.Durchschnitt:F2}");
        }

        Console.WriteLine("\n--- Fertig! ---");
        Console.ReadKey();
    }
}

