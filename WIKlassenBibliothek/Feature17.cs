namespace WIKlassenBibliothek;

internal class Feature17
{
    internal static void Feature_17()
    {
         bool beenden = false;

    do
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Willkommen beim Zinsrechner von Muhammed!");
        Console.WriteLine("Optionen:");
        Console.WriteLine("1. Die Zinsen berechnen");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("2. Das Programm beenden");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Wählen Sie bitte eine Option aus: ");
        Console.ResetColor();

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                ZinsenBerechnen();
                break;
            case "2":
                beenden = true;
                break;
            default:
                Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine der angegebenen Optionen.");
                Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
                break;
        }

    } while (!beenden);
}
    public static void ZinsenBerechnen()
    {
        double startkapital, zinssatz;
        int jahre;
        string eingabe_str = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Zinsen berechnen");
            Console.Write("Geben Sie das Startkapital bitte ein ");
            Console.Write("oder exit zum verlassen: ");
            eingabe_str = Console.ReadLine();
            if(eingabe_str=="exit")
            {
                return;
            }
        } while (!double.TryParse(eingabe_str, out startkapital));

        do
        {
            Console.WriteLine("");
            Console.Write("Geben Sie den Zinssatz in Prozent ein ");
            Console.Write("oder exit um zu verlassen: ");
            eingabe_str = Console.ReadLine();
            if (eingabe_str == "exit")
            {
                return;
            }
        } while (!double.TryParse(eingabe_str, out zinssatz));

        do
        {
            Console.WriteLine("");
            Console.Write("Geben Sie die Anzahl der Jahre ein ");
            Console.Write("oder exit um zu verlassen: ");
            eingabe_str = Console.ReadLine();
            if (eingabe_str == "exit")
            {
                return;
            }
        } while (!int.TryParse(eingabe_str, out jahre));
        Console.Clear() ;

        double endkapital = startkapital * Math.Pow((1 + zinssatz / 100), jahre);
        double zinsen = endkapital - startkapital;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Das Endkapital nach {jahre} Jahren beträgt {endkapital:F2} Euro.");
        Console.WriteLine();
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine($"Die Zinsen nach {jahre} Jahren betragen {zinsen:F2} Euro.");
        Console.WriteLine() ;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
        Console.ReadKey();
       
    }
}
        


