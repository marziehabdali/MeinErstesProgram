
// Datei: Program.cs
using System;

namespace EinfacherTaschenrechner
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Einfacher Taschenrechner ===\n");

            // Erste Zahl eingeben
            Console.Write("Erste Zahl eingeben: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            // Zweite Zahl eingeben
            Console.Write("Zweite Zahl eingeben: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            // Berechnungen durchführen
            double addition = zahl1 + zahl2;
            double subtraktion = zahl1 - zahl2;
            double multiplikation = zahl1 * zahl2;
            double division = zahl2 != 0 ? zahl1 / zahl2 : double.NaN;
            double modulo = zahl2 != 0 ? zahl1 % zahl2 : double.NaN;

            // Ergebnisse ausgeben
            Console.WriteLine("\n=== ERGEBNISSE ===");
            Console.WriteLine($"{zahl1} + {zahl2} = {addition}");
            Console.WriteLine($"{zahl1} - {zahl2} = {subtraktion}");
            Console.WriteLine($"{zahl1} * {zahl2} = {multiplikation}");
            if (zahl2 != 0)
            {
                Console.WriteLine($"{zahl1} / {zahl2} = {division:F2}");
                Console.WriteLine($"{zahl1} % {zahl2} = {modulo}");
            }
            else
            {
                Console.WriteLine("Division und Modulo durch 0 sind nicht definiert!");
            }

            Console.WriteLine("\nDrücken Sie eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
