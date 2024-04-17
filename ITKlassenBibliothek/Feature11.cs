using System;

namespace ITKlassenBibliothek
{
    public class Feature11
    {
        public static void Feature_11()
        {
            Zufallszahlengenerator.Run();
            
        }
    }

    public static class Zufallszahlengenerator
    {
        public static void Run()
        {
            bool restart = true;
            while (restart)
            {
                Console.Clear();
                GenerateRandomNumber();
                Console.WriteLine("Möchten Sie das Programm neu starten? (Ja/Nein)");
                string restartInput = Console.ReadLine().Trim().ToLower();
                restart = restartInput == "ja";
            }
            Console.WriteLine("Auf Wiedersehen!");
        }

        private static void GenerateRandomNumber()
        {
            Console.WriteLine("Willkommen zum Zufallszahlengenerator!");
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Bitte wählen Sie die Länge der generierten Zahl(Maximal 9 stellig):");
                Console.WriteLine("1. 1-10");
                Console.WriteLine("2. 1-100");
                Console.WriteLine("3. 1-200");
                Console.WriteLine("4. Benutzerdefiniert");
                Console.WriteLine("5. Beenden");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine der verfügbaren Optionen.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        GenerateRandomNumberInRange(1, 10);
                        break;
                    case 2:
                        GenerateRandomNumberInRange(1, 100);
                        break;
                    case 3:
                        GenerateRandomNumberInRange(1, 200);
                        break;
                    case 4:
                        Console.WriteLine("Bitte geben Sie die minimale Zahl ein:");
                        int min = ReadIntegerInput();
                        Console.WriteLine("Bitte geben Sie die maximale Zahl ein:");
                        int max = ReadIntegerInput();
                        if (min > max)
                        {
                            Console.WriteLine("Die minimale Zahl darf nicht größer als die maximale Zahl sein.");
                            continue;
                        }
                        GenerateRandomNumberInRange(min, max);
                        break;
                    case 5:
                        repeat = false;
                        break;
                }
            }
            Console.WriteLine("Vielen Dank für die Nutzung des Zufallszahlengenerators." + Environment.NewLine);
        }

        private static void GenerateRandomNumberInRange(int min, int max)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(min, max + 1);
            Console.WriteLine($"Generierte Zahl: {randomNumber}" + Environment.NewLine);
        }

        private static int ReadIntegerInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine kleinere Zahl ein:");
            }
            return input;
        }
    }

    class Program
    {
        static void Main()
        {
            Feature11.Feature_11();
        }
    }
}
