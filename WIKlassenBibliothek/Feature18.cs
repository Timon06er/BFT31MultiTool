using System;
 
internal class Feature18

{

    internal static void Feature_18()

    {

        bool exit = false;
 
        while (!exit)

        {

            Console.Clear();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Willkommen beim Kreditrechner vom Finanzamt!");

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(200);

            Console.WriteLine("Bitte geben Sie den Kreditbetrag ein:");

            decimal kreditbetrag = GetDecimalInput();

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(200);

            Console.WriteLine("Bitte geben Sie den Zinssatz in Prozent ein:");

            decimal zinssatz = GetDecimalInput();

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(200);

            Console.WriteLine("Bitte geben Sie die Laufzeit in Jahren ein:");

            int laufzeit = GetIntInput();
 
            decimal gesamtzahlung = kreditbetrag + (kreditbetrag * zinssatz / 100);

            decimal monatlicheRate = gesamtzahlung / (laufzeit * 12);

            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(200);

            Console.WriteLine("Die monatliche Rate beträgt: " + monatlicheRate.ToString("C"));

            Console.ForegroundColor = ConsoleColor.Magenta;

            Thread.Sleep(200);

            Console.WriteLine("Möchten Sie eine weitere Berechnung durchführen? (J/N)");

            string weiter = Console.ReadLine();
 
            if (weiter.ToUpper() != "J")

            {

                exit = true;

            }

        }

    }
 
    static decimal GetDecimalInput()

    {

        decimal result;

        while (!decimal.TryParse(Console.ReadLine(), out result))

        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Dezimalzahl ein:");

        }

        return result;

    }
 
    static int GetIntInput()

    {

        int result;

        while (!int.TryParse(Console.ReadLine(), out result))

        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Ganzzahl ein:");

        }

        return result;

    }

}