namespace PHKlassenBibliothek;

internal class Feature6
{
    internal static void Feature_6()
    {
        bool exit = false;
        
        do
        {
            (int, int) cPosBM = Console.GetCursorPosition();
            Console.Clear();

            Console.WriteLine("Willkommen beim Rechner von Volumen von geometrischen Körpern!");

            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

            Console.WriteLine("Bitte wählen Sie ein geometrischen Körper:");
            Console.WriteLine("1. Würfel");
            Console.WriteLine("2. Quader");
            Console.WriteLine("3. Kegel");
            Console.WriteLine("4. Kugel");
            Console.WriteLine("5. Zylinder\n\n");

            Console.Write("Engabe:");
            string option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "1":
                    BerechneWuerfelVolumen();
                    break;
                case "2":
                    BerechneQuaderVolumen();
                    break;
                case "3":
                    BerechneKegelVolumen();
                    break;
                case "4":
                    BerechneKugelVolumen();
                    break;
                case "5":
                    BerechneZylinderVolumen();
                    break;
                case "exit":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                    break;
            }

            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
            Console.ReadKey();
        } while (!exit);
    }

    static void BerechneWuerfelVolumen()
    {
        Console.Write("Bitte geben Sie die Seitelänge des Würfels ein: ");
        if (double.TryParse(Console.ReadLine(), out double seitenlaenge))
        {
            double volumen = Math.Pow(seitenlaenge, 3);
            Console.WriteLine($"Das Volumen des Würfels beträgt: {volumen}");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
    }

    static void BerechneQuaderVolumen()
    {
        Console.Write("Länge des Quaders eingeben: ");
        if (double.TryParse(Console.ReadLine(), out double laenge))
        {
            Console.Write("Breite des Quaders eingeben: ");
            if (double.TryParse(Console.ReadLine(), out double breite))
            {
                Console.Write("Höhe des Quaders eingeben: ");
                if (double.TryParse(Console.ReadLine(), out double hoehe))
                {
                    double volumen = laenge * breite * hoehe;
                    Console.WriteLine($"Das Volumen des Quaders beträgt: {volumen}");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
    }

    static void BerechneKegelVolumen()
    {
        Console.Write("Radius des Kegels eingeben: ");
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            Console.Write("Höhe des Kegels eingeben: ");
            if (double.TryParse(Console.ReadLine(), out double hoehe))
            {
                double volumen = Math.PI * Math.Pow(radius, 2) * (hoehe / 3);
                Console.WriteLine($"Das Volumen des Kegels beträgt: {volumen}");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
    }

    static void BerechneKugelVolumen()
    {
        Console.Write("Radius der Kugel eingeben: ");
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            double volumen = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Das Volumen der Kugel beträgt: {volumen}");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
    }

    static void BerechneZylinderVolumen()
    {
        Console.Write("Radius des Zylinders eingeben: ");
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            Console.Write("Höhe des Zylinders eingeben: ");
            if (double.TryParse(Console.ReadLine(), out double hoehe))
            {
                double volumen = Math.PI * Math.Pow(radius, 2) * hoehe;
                Console.WriteLine($"Das Volumen des Zylinders beträgt: {volumen}");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
    }
}