namespace PHKlassenBibliothek;

internal class Feature10
{
    internal static void Feature_10()
    {
        Console.WriteLine("Willkommen zum Einheitenkonverter!");

        while (true)
        {
            Console.WriteLine("\nWelche Art von Konvertierung möchten Sie durchführen?");
            Console.WriteLine("1. Längenkonvertierung");
            Console.WriteLine("2. Massenkonvertierung");
            Console.WriteLine("3. Beenden");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LengthConversion();
                    break;
                case 2:
                    MassConversion();
                    break;
                case 3:
                    Console.WriteLine("Das Programm wird beendet.");
                    return;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine Zahl von 1 bis 3.");
                    break;
            }
        }
    }


      static void LengthConversion()
    {
        Console.WriteLine("\nBitte geben Sie die Länge ein:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nWählen Sie die Ausgangseinheit der Länge aus:");
        Console.WriteLine("1. Millimeter");
        Console.WriteLine("2. Zentimeter");
        Console.WriteLine("3. Meter");
        Console.WriteLine("4. Kilometer");
        Console.WriteLine("5. Meilen");
        Console.WriteLine("6. Fuß");
        Console.WriteLine("7. Yard");

        int fromUnit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWählen Sie die Ziel-Einheit der Länge aus:");
        Console.WriteLine("1. Millimeter");
        Console.WriteLine("2. Zentimeter");
        Console.WriteLine("3. Meter");
        Console.WriteLine("4. Kilometer");
        Console.WriteLine("5. Meilen");
        Console.WriteLine("6. Fuß");
        Console.WriteLine("7. Yard");

        int toUnit = Convert.ToInt32(Console.ReadLine());

        double result = ConvertLength(length, fromUnit, toUnit);

        Console.WriteLine("\nDas Ergebnis der Konvertierung beträgt: {0}", result);
    }

    static void MassConversion()
    {
        Console.WriteLine("\nBitte geben Sie das Gewicht ein:");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nWählen Sie die Ausgangseinheit des Gewichts aus:");
        Console.WriteLine("1. Kilogramm");
        Console.WriteLine("2. Gramm");

        int fromUnit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWählen Sie die Ziel-Einheit des Gewichts aus:");
        Console.WriteLine("1. Kilogramm");
        Console.WriteLine("2. Gramm");

        int toUnit = Convert.ToInt32(Console.ReadLine());

        double result = ConvertWeight(weight, fromUnit, toUnit);

        Console.WriteLine("\nDas Ergebnis der Konvertierung beträgt: {0}", result);
    }

    static double ConvertLength(double value, int fromUnit, int toUnit)
    {
        double result = 0;

        switch (fromUnit)
        {
            case 1: // Millimeter
                result = value / 1000;
                break;
            case 2: // Zentimeter
                result = value / 100;
                break;
            case 3: // Meter
                result = value;
                break;
            case 4: // Kilometer
                result = value * 1000;
                break;
            case 5: // Meilen
                result = value * 1609.34;
                break;
            case 6: // Fuß
                result = value * 0.3048;
                break;
            case 7: // Yard
                result = value * 0.9144;
                break;
            default:
                Console.WriteLine("Ungültige Ausgangseinheit.");
                break;
        }

        switch (toUnit)
        {
            case 1: // Millimeter
                result *= 1000;
                break;
            case 2: // Zentimeter
                result *= 100;
                break;
            case 3: // Meter
                break;
            case 4: // Kilometer
                result /= 1000;
                break;
            case 5: // Meilen
                result /= 1609.34;
                break;
            case 6: // Fuß
                result /= 0.3048;
                break;
            case 7: // Yard
                result /= 0.9144;
                break;
            default:
                Console.WriteLine("Ungültige Ziel-Einheit.");
                break;
        }

        return result;
    }

    static double ConvertWeight(double value, int fromUnit, int toUnit)
    {
        double result = 0;

        switch (fromUnit)
        {
            case 1: // Kilogramm
                result = value;
                break;
            case 2: // Gramm
                result = value / 1000;
                break;
            default:
                Console.WriteLine("Ungültige Ausgangseinheit.");
                break;
        }

        switch (toUnit)
        {
            case 1: // Kilogramm
                break;
            case 2: // Gramm
                result *= 1000;
                break;
            default:
                Console.WriteLine("Ungültige Ziel-Einheit.");
                break;
        }

        return result;
    }

    
}