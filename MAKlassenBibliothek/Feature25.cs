using System;

namespace MAKlassenBibliothek
{
    internal class Feature25
    {
        internal static void Feature_25()
        {
            SimpleCalculator.Main();
        }
    }

    internal class SimpleCalculator
    {
        internal static void Main()
        {
            Console.WriteLine("Willkommen zum einfachen Taschenrechner!");

            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformCalculation();
                        break;

                    case "2":
                        Console.WriteLine("Auf Wiedersehen!");
                        return;

                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wähle erneut.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Menü:");
            Console.WriteLine("1. Berechnen");
            Console.WriteLine("2. Beenden");
            Console.Write("Deine Auswahl: ");
        }

        static void PerformCalculation()
        {
            double num1, num2, result;
            string operand;

            Console.Write("Eingabe Nummer 1: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
            }

            Console.Write("Eingabe Operator (+, -, *, /): ");
            operand = Console.ReadLine();

            while (operand != "+" && operand != "-" && operand != "*" && operand != "/")
            {
                Console.Write("Ungültiger Operator. Bitte einen gültigen Operator eingeben (+, -, *, /): ");
                operand = Console.ReadLine();
            }

            Console.Write("Eingabe Nummer 2: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
            }

            switch (operand)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Ergebnis: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Ergebnis: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Ergebnis: " + result);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Ergebnis: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt.");
                    }
                    break;

                default:
                    Console.WriteLine("Ungültiger Operator.");
                    break;
            }
        }
    }
}
