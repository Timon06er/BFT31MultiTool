namespace WIKlassenBibliothek;

internal class Feature17
{
    internal static void Feature_17()
    {
        bool beenden = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Willkommen beim Zinsrechner!");
            Console.WriteLine("Optionen:");
            Console.WriteLine("1. Die Zinsen berechnen");
            Console.WriteLine("2. Das Programm beenden");
            Console.Write("Wählen Sie bitte eine Option aus: ");

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

        do
        {
            Console.Clear();
            Console.WriteLine("Zinsen berechnen");
            Console.Write("Geben Sie das Startkapital bitte ein: ");
        } while (!double.TryParse(Console.ReadLine(), out startkapital));

        do
        {
            Console.Write("Geben Sie den Zinssatz in Prozent ein: ");
        } while (!double.TryParse(Console.ReadLine(), out zinssatz));

        do
        {
            Console.Write("Geben Sie die Anzahl der Jahre ein: ");
        } while (!int.TryParse(Console.ReadLine(), out jahre));

        double endkapital = startkapital * Math.Pow((1 + zinssatz / 100), jahre);
        double zinsen = endkapital - startkapital;

        Console.WriteLine($"Das Endkapital nach {jahre} Jahren beträgt {endkapital:F2} Euro.");
        Console.WriteLine($"Die Zinsen nach {jahre} Jahren betragen {zinsen:F2} Euro.");

        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
        Console.ReadKey();
    }
}


