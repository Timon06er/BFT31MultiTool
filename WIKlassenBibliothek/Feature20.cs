namespace WIKlassenBibliothek;
using System;
using System.Threading;
internal class Feature20
{
    internal static void Feature_20()
    {
        Console.WriteLine("Willkommen bei der Bestellverwaltung");

        Produkt auto = new Produkt("Auto", new double[] { 25000.00 });
        Produkt haus = new Produkt("Haus", new double[] { 300000.00 });
        Produkt villa = new Produkt("Villa", new double[] { 500000.00 });
        Produkt wohnung = new Produkt("Wohnung", new double[] { 150000.00 });
        Produkt motorrad = new Produkt("Motorrad", new double[] { 10000.00 });
        Produkt computer = new Produkt("Computer", new double[] { 1500.00 });

        Bestellung bestellung = new Bestellung();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bitte wählen Sie ein Produkt:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Auto");
            Thread.Sleep(150);
            Console.WriteLine("2. Haus");
            Thread.Sleep(150);

            Console.WriteLine("3. Villa");
            Thread.Sleep(150);

            Console.WriteLine("4. Wohnung");
            Thread.Sleep(150);

            Console.WriteLine("5. Motorrad");
            Thread.Sleep(150);

            Console.WriteLine("6. Computer");
            Thread.Sleep(150);

            Console.WriteLine("7. Bestellung abschließen");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("8. Beendet das Programm");
            Console.ResetColor();

            int auswahl;
            if (!int.TryParse(Console.ReadLine(), out auswahl) || auswahl < 1 || auswahl > 8)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 8 ein.");
                continue;
            }

            Produkt ausgewähltesProdukt = null;
            switch (auswahl)
            {
                case 1:
                    ausgewähltesProdukt = auto;
                    break;
                case 2: ausgewähltesProdukt = haus; break;
                case 3: ausgewähltesProdukt = villa; break;
                case 4: ausgewähltesProdukt = wohnung; break;
                case 5: ausgewähltesProdukt = motorrad; break;
                case 6: ausgewähltesProdukt = computer; break;
                case 7:
                    bestellung.DruckeRechnung();
                    break;
                case 8:
                    Console.WriteLine("Tschüss");
                    Console.ReadLine();
                    return;
            }
            Console.Clear();
            int menge;
            while (true)
            {
                Console.Write($"Bitte geben Sie die Menge für '{ausgewähltesProdukt.Name}' ein (0 zum Abbrechen): ");
                if (int.TryParse(Console.ReadLine(), out menge) && menge >= 0)
                    break;
                else
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Ganzzahl ein.");
            }

            if (menge == 0)
                continue;

            bestellung.ProduktHinzufügen(ausgewähltesProdukt, menge);
        }
    }
}


class Produkt
{
    public string Name;
    public double[] Preisstufen;

    public Produkt(string name, double[] preisstufen)
    {
        Name = name;
        Preisstufen = preisstufen;
    }

    public double HolePreis(int menge)
    {
        return Preisstufen[Preisstufen.Length - 1] * menge; // Nehmen Sie den höchsten Preisstufenwert
    }
}

class Bestellung
{
    private double GesamtPreis;

    public void ProduktHinzufügen(Produkt produkt, int menge)
    {
        GesamtPreis += produkt.HolePreis(menge);
    }

    public void DruckeRechnung()
    {
        Console.WriteLine("Rechnung:");
        Console.WriteLine("==========");
        Console.WriteLine($"Gesamtpreis: {GesamtPreis:C}");
    }
}