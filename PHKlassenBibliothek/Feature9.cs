namespace PHKlassenBibliothek;


public class Fragen
{
    public string Name { get; set; }
    public string Frage { get; set; }
    public double eingegeben { get; set; }
    public double lösung { get; set; }
}


internal class Feature9
{
    internal static void Feature_9()
    {

        name();

        Console.WriteLine("Willkommen in unserem Physik  Multitool.");
        Console.WriteLine("Hallo geben sie ihren Namen ein");
        string username = Console.ReadLine();
        Console.WriteLine("eingeloggt als {0,-10}", username);
        Thread.Sleep(1000);
        
        nextPage();


        Console.Write("Möchtest du wieder spielen? (J/N): ");
        string erneut = Console.ReadLine();
        if (erneut.ToUpper() == "J")
        {
            Console.Clear();
            nextPage();
        }
        else
        {
            nextPage();
        }
    }
    
    static void name()
    {
        string name = @"  ____  _   ___   ______ ___ _  __    ____  ____ ___ _____ _     _____ 
|  _ \| | | \ \ / / ___|_ _| |/ /   / ___||  _ \_ _| ____| |   | ____|
| |_) | |_| |\ V /\___ \| || ' /    \___ \| |_) | ||  _| | |   |  _|  
|  __/|  _  | | |  ___) | || . \     ___) |  __/| || |___| |___| |___ 
|_|   |_| |_| |_| |____/___|_|\_\   |____/|_|  |___|_____|_____|_____|
                                                                ";
        Console.WriteLine();
        Console.WriteLine();

    }

    static void schreiben(string number, string message)
    {
        Console.Write("[");
        Console.Write(number);
        Console.WriteLine("] " + message);
    }

    static void Spiel()
    {
        //In dieser Liste werden einzelne Wertde hinzugefügt die Später in einer For Schleife benutzt werden um den Code nicht oft Schreiben zu müssen sondern nur 1 mal und man Kann belibieb viele Fragen hinzufügen 
        List<Fragen> merkur = new List<Fragen>
{
                new Fragen {Name = "Graviations Rechnung Merkur Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Merkur im Vergleich zur Erde?", eingegeben = 0, lösung = 62},
                new Fragen {Name = "Graviations Rechnung Venus Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Venus im Vergleich zur Erde?", eingegeben = 0, lösung = 9},
                new Fragen {Name = "Graviation auf der Erde", Frage = "Wie hoch ist die Gravitationskraft auf der Erde?", eingegeben = 0, lösung = 100},
                new Fragen {Name = "Graviations Rechnung Mars Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Mars im Vergleich zur Erde?", eingegeben = 0, lösung = 62},
                new Fragen {Name = "Graviations Rechnung Jupiter Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Jupiter im Vergleich zur Erde?", eingegeben = 0, lösung = 154},
                new Fragen {Name = "Graviations Rechnung Saturn Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Saturn im Vergleich zur Erde?", eingegeben = 0, lösung = 7},
                new Fragen {Name = "Graviations Rechnung Uranus Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Uranus im Vergleich zur Erde?", eingegeben = 0, lösung = 11},
                new Fragen {Name = "Graviations Rechnung Neptun Vergleich Erde", Frage = "Wie hoch ist die Gravitationskraft auf Neptun im Vergleich zur Erde?", eingegeben = 0, lösung = 13},
};

        //In dieser For Schleife werden die Fragen gestellt und die Antwort aufgenommen und in dem einzelen Table in der Liste geändert

        for (int i = 0; i < merkur.Count; i++)
        {
            Console.WriteLine(merkur[i].Frage);
            double eingabe;
            bool gültigeEingabe = false;

            while (!gültigeEingabe)
            {
                Console.Write("Ihre Antwort (geben Sie 'exit' ein, um die Anwendung zu beenden): ");
                string eingabeString = Console.ReadLine();

                if (eingabeString.ToLower() == "exit")
                {
                    Environment.Exit(0); // Beendet die Anwendung
                }

                // Überprüfen, ob die Eingabe eine Zahl ist
                if (double.TryParse(eingabeString, out eingabe))
                {
                    gültigeEingabe = true;
                    merkur[i].eingegeben = eingabe;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Eingabe ist ungültig. Bitte geben Sie eine Zahl ein oder 'exit' zum Beenden.");
                    Console.ResetColor();
                }
            }

            Console.WriteLine();
        }



        //In dieser For Schleife werden die Antworten mit den Ergebnissen verglichen und auf die Richtigkeit geprüft

        for (int i = 0; i < merkur.Count; i++)
        {
            Thread.Sleep(500);
            if (merkur[i].lösung == merkur[i].eingegeben)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ergebnis {merkur[i].Name} : Richtig");
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ergebnis {merkur[i].Name} : Falsch");
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        // Abfrage ob man neu Spielen möchte
        Console.Write("Möchtest du wieder spielen? (J/N): ");
        string erneut = Console.ReadLine();
        if (erneut.ToUpper() == "J")
        {
            Console.Clear();
            Spiel();
        }
        else
        {
            nextPage();
        }
    }

    static void Winkelberechner()
    {
        double a = GetUserInput("Seite a");
        double b = GetUserInput("Seite b");
        double c = GetUserInput("Seite c");

        double angleA = CalculateAngle(a, b, c);
        double angleB = CalculateAngle(b, c, a);
        double angleC = CalculateAngle(c, a, b);

        Console.WriteLine($"Der Winkel A beträgt: {Math.Round(angleA, 2)} Grad");
        Console.WriteLine($"Der Winkel B beträgt: {Math.Round(angleB, 2)} Grad");
        Console.WriteLine($"Der Winkel C beträgt: {Math.Round(angleC, 2)} Grad");
    }

     static double GetUserInput(string sideName)
    {
        double side;
        Console.WriteLine($"Gib den Wert für {sideName} ein (exit zum Beenden): ");

        // Benutzereingabe verarbeiten
        string input = Console.ReadLine();

        if (input.ToLower() == "exit")
        {
            Environment.Exit(0);
        }

        // Versuchen, die Eingabe in eine Zahl zu konvertieren
        while (!double.TryParse(input, out side))
        {
            Console.WriteLine($"Ungültige Eingabe. Bitte gib eine numerische Wert für {sideName} ein (exit zum Beenden): ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Environment.Exit(0); 
            }
        }

        return side;
    }

    static double CalculateAngle(double side1, double side2, double side3)
    {
        double angle = Math.Acos((side2 * side2 + side3 * side3 - side1 * side1) / (2 * side2 * side3));
        return Math.Round(angle * (180 / Math.PI), 2);
    }
            
    public static void nextPage()
    {
        bool gültigeEingabe = false;

        while (!gültigeEingabe)
        {
            Console.Clear();
            name();
            schreiben("1", "Gravitaions Fragen");
            schreiben("2", "Winkel Berechner");
            Console.ForegroundColor = ConsoleColor.Red;
            schreiben("3", "Beenden");
            Console.ResetColor();
            string option = Console.ReadLine();
            gültigeEingabe = true;
            if (option == "1")
            {
                Spiel();
            }
            else if (option == "2")
            {
                Winkelberechner();
            }
            else if (option == "3")
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                gültigeEingabe = false;
                Console.WriteLine("Bitte gebe eine Richtige Nummer ein");
                Thread.Sleep(1000);
            }
        }
    }



}

          