namespace MAKlassenBibliothek
{
    internal class Feature23
    {
        private static ConsoleState consoleState; // Klasse zum Speichern des Konsolenzustands

        internal static void Feature_23()
        {
            while (true)
            {
                ClearConsole(); // Konsolenbildschirm löschen und Zustand speichern

                List<double> data = GetInputData();

                if (data.Count > 0)
                {
                    Console.WriteLine($"Mittelwert: {CalculateMean(data)}");
                    Console.WriteLine($"Median: {CalculateMedian(data)}");
                    Console.WriteLine($"Standardabweichung: {CalculateStandardDeviation(data)}");
                }

                Console.WriteLine("Geben Sie 'exit' ein, um das Programm zu verlassen, oder drücken Sie eine beliebige Taste, um fortzufahren.");

                if (Console.ReadLine().ToLower() == "exit")
                    break; // Die Schleife wird verlassen und das Programm endet nicht.

                // Hier könnte auch eine Pause oder ein Hinweis für den Benutzer eingefügt werden, bevor die Schleife erneut beginnt.
            }
        }

        static void ClearConsole()
        {
            consoleState = new ConsoleState(); // Zustand speichern
            Console.Clear();
        }

        static List<double> GetInputData()
        {
            Console.WriteLine("Guten Tag, geben Sie bitte Ihren Namen ein:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Willkommen, {userName}, bei Can's Multirechnungsapp! Hier können Sie einfache Statistik berechnen lassen.");
            Console.WriteLine("!!!!!WENN SIE DIE SEITE SCHLIESEN WOLLEN, DRÜCKEN SIE EXIT!!!!!");

            Console.WriteLine("Bitte geben Sie Zahlen durch Kommas getrennt ein:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    return new List<double>(); // Leere Liste zurückgeben, um die Berechnungen zu überspringen und zur Eingabeaufforderung zurückzukehren.

                try
                {
                    return ParseInput(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie gültige Zahlen durch Kommas getrennt ein.");
                }
            }
        }

        static List<double> ParseInput(string input)
        {
            return input.Split(',').Select(double.Parse).ToList();
        }

        static double CalculateMean(List<double> data)
        {
            return data.Any() ? data.Average() : 0;
        }

        static double CalculateMedian(List<double> data)
        {
            data.Sort();
            int n = data.Count;
            return (n % 2 == 0) ? (data[n / 2 - 1] + data[n / 2]) / 2 : data[n / 2];
        }

        static double CalculateStandardDeviation(List<double> data)
        {
            double mean = CalculateMean(data);
            double variance = data.Any() ? data.Sum(x => Math.Pow(x - mean, 2)) / data.Count : 0;
            return Math.Sqrt(variance);
        }

        // Klasse zum Speichern des Konsolenzustands
        private class ConsoleState
        {
            public int CursorTop { get; private set; }
            public int CursorLeft { get; private set; }

            public ConsoleState()
            {
                CursorTop = Console.CursorTop;
                CursorLeft = Console.CursorLeft;
            }
        }
    }
}