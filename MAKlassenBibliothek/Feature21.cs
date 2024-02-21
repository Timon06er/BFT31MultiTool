namespace MAKlassenBibliothek;

internal class Feature21
{
    internal static void Feature_21()
    {
        using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("************************************");
            Console.WriteLine("*                                  *");
            Console.WriteLine("*   Willkommen beim               *");
            Console.WriteLine("*   Flächenrechner von Can        *");
            Console.WriteLine("*                                  *");
            Console.WriteLine("************************************");

            Console.WriteLine("1. Rechteck");
            Console.WriteLine("2. Quadrat");
            Console.WriteLine("3. Kreis");
            Console.WriteLine("4. Dreieck");
            Console.WriteLine("5. Trapez");
            Console.WriteLine("6. Support");
            Console.WriteLine("7. Beenden");

            Console.Write("Bitte wählen Sie eine Option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BerechneRechteckFläche();
                    break;
                case "2":
                    BerechneQuadratFläche();
                    break;
                case "3":
                    BerechneKreisFläche();
                    break;
                case "4":
                    BerechneDreieckFläche();
                    break;
                case "5":
                    BerechneTrapezFläche();
                    break;
                case "6":
                    Support();
                    break;
                case "7":
                    Console.WriteLine("Das Programm wird beendet.");
                    return;
                default:
                    Console.WriteLine("Ungültige Option. Bitte wählen Sie eine der verfügbaren Optionen aus.");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine();
        }
    }

    static void BerechneRechteckFläche()
    {
        bool flag_error;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Um ins Menü zu kommen exit schreiben");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formel für Rechteck:");
            Console.WriteLine("Länge * Breite");
            Console.WriteLine("------------------------------------");
            flag_error = false;
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie die Länge des Rechtecks ein: ");

            string laenge_str = Console.ReadLine();

            if (laenge_str.ToLower() == "exit")
                return;

            if (double.TryParse(laenge_str, out double length))
            {
                Console.WriteLine("");
                Console.WriteLine("Bitte geben Sie die Breite des Rechtecks ein: ");
                if (double.TryParse(Console.ReadLine(), out double width))
                {
                    double area = length * width;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"Die Fläche des Rechtecks beträgt: {area}");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Drücken Sie eine beliebige Taste, um ins Menü zu kommen...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe für Breite.");
                    flag_error = true;
                    Console.ReadLine();
                }
            }
            else
            {
                flag_error = true;
                Console.WriteLine("Ungültige Eingabe für Länge.");
                Console.ReadLine();
            }

        } while (flag_error == true);
    }

    static void BerechneQuadratFläche()
    {
        bool flag_error;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Um ins Menü zu kommen exit schreiben");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formel für Quadrat:");
            Console.WriteLine("Seite * Seite");
            Console.WriteLine("------------------------------------");
            flag_error = false;
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie die Seitenlänge des Quadrats ein: ");

            string side_str = Console.ReadLine();

            if (side_str.ToLower() == "exit")
                return;

            if (double.TryParse(side_str, out double side))
            {
                double area = side * side;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Die Fläche des Quadrats beträgt: {area}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Drücken Sie eine beliebige Taste, um ins Menü zu kommen...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                flag_error = true;
                Console.WriteLine("Ungültige Eingabe für Seitenlänge.");
                Console.ReadLine();
            }

        } while (flag_error == true);
    }

    static void BerechneKreisFläche()
    {
        bool flag_error;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Um ins Menü zu kommen exit schreiben");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formel für Kreis:");
            Console.WriteLine("Pi * Radius * Radius");
            Console.WriteLine("------------------------------------");
            flag_error = false;
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie den Radius des Kreises ein: ");

            string radius_str = Console.ReadLine();

            if (radius_str.ToLower() == "exit")
                return;

            if (double.TryParse(radius_str, out double radius))
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Die Fläche des Kreises beträgt: {area}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Drücken Sie eine beliebige Taste, um ins Menü zu kommen...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                flag_error = true;
                Console.WriteLine("Ungültige Eingabe für Radius.");
                Console.ReadLine();
            }

        } while (flag_error == true);
    }

    static void BerechneDreieckFläche()
    {
        bool flag_error;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Um ins Menü zu kommen exit schreiben");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formel für Dreieck:");
            Console.WriteLine("0.5 * Basis * Höhe");
            Console.WriteLine("------------------------------------");
            flag_error = false;
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie die Basis des Dreiecks ein: ");

            string basis_str = Console.ReadLine();

            if (basis_str.ToLower() == "exit")
                return;

            if (double.TryParse(basis_str, out double basis))
            {
                Console.Write("Bitte geben Sie die Höhe des Dreiecks ein: ");
                if (double.TryParse(Console.ReadLine(), out double height))
                {
                    double area = 0.5 * basis * height;
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"Die Fläche des Dreiecks beträgt: {area}");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Drücken Sie eine beliebige Taste, um ins Menü zu kommen...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    flag_error = true;
                    Console.WriteLine("Ungültige Eingabe für Höhe.");
                    Console.ReadLine();
                }
            }
            else
            {
                flag_error = true;
                Console.WriteLine("Ungültige Eingabe für Basis.");
                Console.ReadLine();
            }

        } while (flag_error == true);
    }

    static void BerechneTrapezFläche()
    {
        bool flag_error;

        do
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Um ins Menü zu kommen exit schreiben");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formel für Trapez:");
            Console.WriteLine("0.5 * (obere Seite + untere Seite) * Höhe");
            Console.WriteLine("------------------------------------");
            flag_error = false;
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie die Länge der oberen Seite des Trapezes ein: ");

            string upperSide_str = Console.ReadLine();

            if (upperSide_str.ToLower() == "exit")
                return;

            if (double.TryParse(upperSide_str, out double upperSide))
            {
                Console.WriteLine("");
                Console.Write("Bitte geben Sie die Länge der unteren Seite des Trapezes ein: ");
                if (double.TryParse(Console.ReadLine(), out double lowerSide))
                {
                    Console.WriteLine("");
                    Console.Write("Bitte geben Sie die Höhe des Trapezes ein: ");
                    if (double.TryParse(Console.ReadLine(), out double height))
                    {
                        double area = 0.5 * (upperSide + lowerSide) * height;
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine($"Die Fläche des Trapezes beträgt: {area}");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um ins Menü zu kommen...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        flag_error = true;
                        Console.WriteLine("Ungültige Eingabe für Höhe.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    flag_error = true;
                    Console.WriteLine("Ungültige Eingabe für untere Seite.");
                    Console.ReadLine();
                }
            }
            else
            {
                flag_error = true;
                Console.WriteLine("Ungültige Eingabe für obere Seite.");
                Console.ReadLine();
            }

        } while (flag_error == true);
    }

    static void Support()
    {
        Console.Clear();
        Console.WriteLine("*************************************");
        Console.WriteLine("*  Willkommen beim Support          *");
        Console.WriteLine("*  Haben Sie Fragen? Kontaktieren   *");
        Console.WriteLine("*  Sie uns per E-Mail oder Telefon: *");
        Console.WriteLine("*                                   *");
        Console.WriteLine("*  E-Mail: can.duman1@outlook.de    *");
        Console.WriteLine("*  Telefonnummer: +49 176 21582787  *");
        Console.WriteLine("*************************************");

        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
        Console.ReadKey();

        Console.Clear();
    }
}

    }
}