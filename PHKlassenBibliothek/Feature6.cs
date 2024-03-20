using System.ComponentModel.Design;

namespace PHKlassenBibliothek;

internal class Feature6
{
    internal static void Feature_6()
    {
        
        
            Console.Clear();
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Willkommen beim Rechner von Volumen von geometrischen Körpern!");
                Console.WriteLine();
                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");
                Console.WriteLine();
                Console.WriteLine("Bitte wählen Sie ein geometrischen Körper:");
                Console.WriteLine("1. Würfel");
                Console.WriteLine("2. Quader");
                Console.WriteLine("3. Kegel");
                Console.WriteLine("4. Kugel");
                Console.WriteLine("5. Zylinder\n\n");


                Console.Write("Eingabe:");
                string option = Console.ReadLine().ToLower();
                Console.Clear();

                
                switch (option)
                {
                    case "1":
                        exit = BerechneWuerfelVolumen();
                        break;
                    case "2":
                        exit = BerechneQuaderVolumen();
                        break;
                    case "3":
                        exit = BerechneKegelVolumen();
                        break;
                    case "4":
                        exit = BerechneKugelVolumen();
                        break;
                    case "5":
                        exit = BerechneZylinderVolumen();
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                        break;
                }
                
            } while (!exit);
    
        
    }    
    static bool BerechneWuerfelVolumen()
    {

        Console.Write("Bitte geben Sie die Seitelänge des Würfels ein: ");

        string eingabe = Console.ReadLine();

        if (double.TryParse(eingabe, out double seitenlaenge))
        {
            double volumen = Math.Pow(seitenlaenge, 3);
            Console.WriteLine($"Das Volumen des Würfels beträgt: {volumen:F4}");
            Console.ReadLine();
        }
        else if(eingabe=="exit")
        {
            return true;
        }
        else
        {
           Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
        return false;
    }

    static bool BerechneQuaderVolumen()
    {
        Console.Write("Länge des Quaders eingeben: ");
        string eingabe1 = Console.ReadLine();
        if (double.TryParse(eingabe1, out double laenge))
        {
            Console.Write("Breite des Quaders eingeben: ");
            string eingabe2 = Console.ReadLine();
            if (double.TryParse(eingabe2, out double breite))
            {
                Console.Write("Höhe des Quaders eingeben: ");
                string eingabe3 = Console.ReadLine();
                if (double.TryParse(eingabe3, out double hoehe))
                {
                    double volumen = laenge * breite * hoehe;
                    Console.WriteLine($"Das Volumen des Quaders beträgt: {volumen:F4}");
                    Console.ReadLine();
                }
                else if (eingabe3=="exit")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                }
            }
            else if (eingabe2=="exit")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
            }
        }
        else if (eingabe1=="exit")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
        return false;
    }

    static bool BerechneKegelVolumen()
    {
        Console.Write("Radius des Kegels eingeben: ");
        string eingabe4 = Console.ReadLine();
        if (double.TryParse(eingabe4, out double radius))
        {
            Console.Write("Höhe des Kegels eingeben: ");
            string eingabe5 = Console.ReadLine();
            if (double.TryParse(eingabe5, out double hoehe))
            {
                double volumen = Math.PI * Math.Pow(radius, 2) * (hoehe / 3);
                Console.WriteLine($"Das Volumen des Kegels beträgt: {volumen:F4}");
                Console.ReadLine();
            }
            else if (eingabe5=="exit")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
            }
        }
        else if (eingabe4=="exit")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
        return false;
    }

    static bool BerechneKugelVolumen()
    {
        Console.Write("Radius der Kugel eingeben: ");
        string eingabe6 = Console.ReadLine();
        if (double.TryParse(eingabe6, out double radius))
        {
            double volumen = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Das Volumen der Kugel beträgt: {volumen:F4}");
            Console.ReadLine();
        }
        else if (eingabe6=="exit")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
        return false;
    }

    static bool BerechneZylinderVolumen()
    {
        Console.Write("Radius des Zylinders eingeben: ");
        string eingabe7 = Console.ReadLine();
        if (double.TryParse(eingabe7, out double radius))
        {
            Console.Write("Höhe des Zylinders eingeben: ");
            string eingabe8 = Console.ReadLine();
            if (double.TryParse(eingabe8, out double hoehe))
            {
                double volumen = Math.PI * Math.Pow(radius, 2) * hoehe;
                Console.WriteLine($"Das Volumen des Zylinders beträgt: {volumen:F4}");
                Console.ReadLine();
            }
            else if (eingabe8=="exit")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
            }
        }
        else if (eingabe7=="exit")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
        }
        return false;
    }
}