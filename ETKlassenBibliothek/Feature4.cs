namespace ETKlassenBibliothek;

internal class Feature4
{
    internal static void Feature_4()
    {
        Console.WriteLine("Test Feature 4"); 


        Console.WriteLine("Ohmsches Gesetz: Berechnung des Stroms");

        while (true)
        {
            DisplayMenu();

            
            Console.Write("Bitte wählen Sie eine Option: ");
            string option = Console.ReadLine();

            
            if (option.ToLower() == "exit")
            {
                Console.WriteLine("Das Programm wurde beendet.");
                break;
            }

            
            switch (option)
            {
                case "1":
                    CalculateCurrent();
                    break;
                case "2":
                    DisplayOhmsLaw();
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine gültige Option.");
                    break;
            }

            
            Console.WriteLine(new string('-', 30));
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMenü:");
        Console.WriteLine("1. Strom berechnen");
        Console.WriteLine("2. Ohmsches Gesetz anzeigen");
        Console.WriteLine("exit. Beenden");
    }

    static void CalculateCurrent()
    {
        Console.WriteLine("Stromberechnung:");

        
        Console.Write("Geben Sie die Spannung in Volt ein: ");
        string inputVoltage = Console.ReadLine();

        
        if (inputVoltage.ToLower() == "exit")
        {
            Console.WriteLine("Das Programm wurde beendet.");
            Environment.Exit(0);
        }

        
        if (double.TryParse(inputVoltage, out double voltage))
        {
            
            Console.Write("Geben Sie den Widerstand in Ohm ein: ");
            string inputResistance = Console.ReadLine();

            
            if (inputResistance.ToLower() == "exit")
            {
                Console.WriteLine("Das Programm wurde beendet.");
                Environment.Exit(0);
            }

            
            if (double.TryParse(inputResistance, out double resistance))
            {
                
                double current = voltage / resistance;

                
                Console.WriteLine($"Der Strom beträgt {current} Ampere.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe für den Widerstand. Bitte geben Sie eine gültige Zahl ein.");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe für die Spannung. Bitte geben Sie eine gültige Zahl ein.");
        }
    }

    static void DisplayOhmsLaw()
    {
        Console.WriteLine("Ohmsches Gesetz:");
        Console.WriteLine("Das Ohmsche Gesetz beschreibt die Beziehung zwischen Spannung, Strom und Widerstand.");
        Console.WriteLine("Es lautet: U = I * R (Spannung = Strom * Widerstand)");
    }
}

    
