using System;
class Program
{
    static void Main()
    {
        // 
        string meinName = "Marzieh";
        int meinAlter = 32;
        double meinGehalt = 2500.90;
        bool istStudent = true;   
        char meinInitial = 'M';

        
        Console.WriteLine("Name: " + meinName);
        Console.WriteLine("Alter: " + meinAlter + " Jahre");
        Console.WriteLine("Gehalt: " + meinGehalt + " Euro");
        Console.WriteLine("Student: " + istStudent);
        Console.WriteLine("Initial: " + meinInitial);

        Console.ReadKey();
    }
}
