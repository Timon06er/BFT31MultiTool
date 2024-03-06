using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIKlassenBibliothek
{
    internal class Feature16
    {
        internal static void Feature_16()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Willkommen zum Nebenkosten Rechner von Amannat");
            Console.ResetColor();

            Console.WriteLine("Bitte geben Sie die Kaltmiete ein:");
            double kaltmiete = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Warmmiete ein:");
            double warmmiete = Convert.ToDouble(Console.ReadLine());

            double nebenkosten = warmmiete - kaltmiete;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Die Nebenkosten betragen: {nebenkosten}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMöchten Sie eine detaillierte Aufschlüsselung der Nebenkosten? (Ja/Nein):");
            string antwort = Console.ReadLine().ToLower();
            Console.ResetColor();

            if (antwort == "ja")
            {
                Console.WriteLine("\n*** Detaillierte Aufschlüsselung der Nebenkosten ***");
                Console.WriteLine($"Warmmiete: {warmmiete} €");
                Console.WriteLine($"Kaltmiete: {kaltmiete} €");
                Console.WriteLine($"Nebenkosten: {nebenkosten} €");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nVielen Dank für die Nutzung des Rechners. Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
