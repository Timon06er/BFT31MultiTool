namespace ETKlassenBibliothek;

internal class Feature2
{
    internal static void Feature_2()
    {
        Console.WriteLine("Herzlich Willkommen zum Leitungsquerschnitt berechner :)");


        Console.WriteLine("Leitungsquerschnittsberechner");

        Console.Write("Geben sie die Stromstärke in Ampere ein:");
        double stromstaerke = Convert.ToDouble(Console.ReadLine());

        Console.Write("Geben sie die Spannung in Volt ein:");
        double Spannung = Convert.ToDouble(Console.ReadLine());
        
        double leitungsquerschnitt = stromstaerke / Spannung;

        Console.WriteLine($"Der Leitungsquerschnitt beträgt {leitungsquerschnitt}Quadratmilimeter.");


        




    }
}