using System;

namespace WIKlassenBibliothek
{
    internal class Feature16
    {
        internal static void Feature_16()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Willkommen zum Nebenkosten Rechner von Amannat");
            Console.ResetColor();

            double kaltmiete = 0;
            double warmmiete = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Bitte geben Sie die Kaltmiete ein (oder 'exit' zum Beenden):");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    return;
                }

                if (double.TryParse(input, out kaltmiete))
                {
                    validInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl ein.");
                    Console.ResetColor();
                }
            }

            validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Bitte geben Sie die Warmmiete ein (oder 'exit' zum Beenden):");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    return;
                }

                if (double.TryParse(input, out warmmiete))
                {
                    validInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl ein.");
                    Console.ResetColor();
                }
            }

            double nebenkosten = warmmiete - kaltmiete;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Die Nebenkosten betragen: {nebenkosten}");
            Console.ResetColor();

            bool validAnswer = false;

            while (!validAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMöchten Sie eine detaillierte Aufschlüsselung der Nebenkosten? (Ja/Nein oder 'exit' zum Beenden):");
                string antwort = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (antwort == "ja")
                {
                    Console.WriteLine("\n*** Detaillierte Aufschlüsselung der Nebenkosten ***");
                    Console.WriteLine($"Warmmiete: {warmmiete} €");
                    Console.WriteLine($"Kaltmiete: {kaltmiete} €");
                    Console.WriteLine($"Nebenkosten: {nebenkosten} €");
                    validAnswer = true;
                }
                else if (antwort == "nein")
                {
                    validAnswer = true;
                }
                else if (antwort == "exit")
                {
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Antwort! Bitte antworten Sie mit 'Ja' oder 'Nein' (oder 'exit' zum Beenden).");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nVielen Dank für die Nutzung des Rechners. Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
