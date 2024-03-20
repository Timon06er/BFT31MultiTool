using System;

namespace MAKlassenBibliothek
{
    internal class Feature22
    {
        internal static void Feature_22()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Lineare Funktion: y = mx + b");

                double m, b, x;

                // Benutzereingabe für den Anstieg (m)
                Console.Write("Geben Sie den Anstieg (m) ein: ");
                while (!double.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine numerische Zahl ein.");
                    Console.Write("Geben Sie den Anstieg (m) ein: ");
                }

                // Benutzereingabe für den y-Achsenabschnitt (b)
                Console.Write("Geben Sie den y-Achsenabschnitt (b) ein: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine numerische Zahl ein.");
                    Console.Write("Geben Sie den y-Achsenabschnitt (b) ein: ");
                }

                // Benutzereingabe für den x-Wert
                Console.Write("Geben Sie den x-Wert ein: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine numerische Zahl ein.");
                    Console.Write("Geben Sie den x-Wert ein: ");
                }

                // Überprüfung auf "exit"
                if (IsExitCommand(x))
                {
                    repeat = false;
                    continue;
                }

                // Berechnung des y-Werts
                double y = CalculateLinearFunction(m, b, x);

                // Ausgabe des Ergebnisses
                Console.WriteLine($"Für x = {x}, y = {y}");

                // Abfrage, ob das Programm wiederholt werden soll
                Console.Write("Möchten Sie das Programm wiederholen? (ja/nein): ");
                string userInput = Console.ReadLine().ToLower();
                repeat = (userInput == "ja" || userInput == "yes");
            }
        }

        // Funktion zur Überprüfung auf "exit"
        private static bool IsExitCommand(double x)
        {
            return x == 0; // Ändere dies entsprechend deiner Anforderungen
        }

        // Funktion zur Berechnung des y-Werts einer linearen Funktion
        private static double CalculateLinearFunction(double m, double b, double x)
        {
            return m * x + b;
        }
    }
}
