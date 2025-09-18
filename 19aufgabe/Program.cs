using System;
using System.Collections.Generic;

// Generische Stapel-Klasse
class MeinStapel<T> where T : IComparable<T>
{
    private List<T> elemente;
    private int maxGroesse;

    public MeinStapel(int maxGroesse = 100)
    {
        elemente = new List<T>();
        this.maxGroesse = maxGroesse;
    }

    public int Anzahl { get { return elemente.Count; } }
    public bool IstLeer { get { return elemente.Count == 0; } }
    public bool IstVoll { get { return elemente.Count >= maxGroesse; } }

    // Element auf den Stapel legen
    public bool Push(T element)
    {
        if (IstVoll)
        {
            Console.WriteLine("Staple ist voll, Element konnte nicht hinzugefügt werden.");
            return false;
        }
        elemente.Add(element);
        Console.WriteLine($"Element '{element}' wurde auf den Stapel gelegt.");
        return true;
    }

    // Element vom Stapel entfernen
    public T Pop()
    {
        if (IstLeer)
        {
            Console.WriteLine("Staple ist leer, kein Element zum Entfernen.");
            return default(T);
        }
        T oberstes = elemente[elemente.Count - 1];
        elemente.RemoveAt(elemente.Count - 1);
        Console.WriteLine($"Element '{oberstes}' wurde vom Stapel entfernt.");
        return oberstes;
    }

    // Oberstes Element ansehen
    public T Peek()
    {
        if (IstLeer)
        {
            Console.WriteLine("Staple ist leer, kein Element oben.");
            return default(T);
        }
        return elemente[elemente.Count - 1];
    }

    // Stapel anzeigen
    public void ZeigeStapel()
    {
        Console.WriteLine("\n--- Stapelinhalt ---");
        if (IstLeer)
        {
            Console.WriteLine("Der Stapel ist leer.");
        }
        else
        {
            for (int i = elemente.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(elemente[i]);
            }
        }
    }
}

class GenericStackDemo
{
    static void Main()
    {
        Console.WriteLine("=== Generische Stapel-Demo ===\n");

        MeinStapel<int> stapel = new MeinStapel<int>(5);

        stapel.Push(10);
        stapel.Push(20);
        stapel.Push(30);

        stapel.ZeigeStapel();

        Console.WriteLine($"\nOberstes Element: {stapel.Peek()}");

        stapel.Pop();
        stapel.ZeigeStapel();

        stapel.Pop();
        stapel.Pop();
        stapel.Pop(); // leerer Stapel

        Console.ReadKey();
    }
}
