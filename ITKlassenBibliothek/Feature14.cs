using System;

namespace ITKlassenBibliothek
{
    public class Feature14
    {
        public static void Feature_14()
        {
            Console.Clear(); 
            Console.WriteLine("Willkommen! Generiere einen zufälligen Benutzernamen.");
            AskForInput("Möchtest du einen zufälligen Benutzernamen generieren? (J/N)");
        }

        static void AskForInput(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine()?.Trim().ToUpper();

            if (input == "J")
            {
                GenerateAndDisplayUsername();
            }
            else if (input == "N")
            {
                Console.WriteLine("Du hast dich entschieden, keinen zufälligen Benutzernamen zu generieren.");
            }
            else if (input == "EXIT")
            {
                Environment.Exit(0); // Programm beenden
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib 'J' für Ja, 'N' für Nein oder 'EXIT' zum Beenden ein.");
                AskForInput(message); // Erneut nach Eingabe zu fragen
            }
        }

        static void GenerateAndDisplayUsername()
        {
            var randomUsername = new RandomUsernameGenerator().GenerateUsername();
            Console.WriteLine("Möchtest du einen weiteren zufälligen Benutzernamen generieren? (J/N)");
            AskForInput("");
        }
    }

    class RandomUsernameGenerator
    {
        private readonly string[] _adjectives = { "Blue", "Happy", "Sunny", "Clever", "Quick", "Mysterious", "Gentle", "Vibrant", "Charming", "Lively", "Radiant", "Silent", "Brilliant", "Dynamic", "Spirited" };
        private readonly string[] _nouns = { "Cat", "Dog", "Lion", "Eagle", "River", "Mountain", "Phoenix", "Whisper", "Penguin", "Cascade", "Enigma", "Harmony", "Jubilee", "Zenith", "Majesty" };

        public string GenerateUsername()
        {
            var random = new Random();
            var adjective = _adjectives[random.Next(_adjectives.Length)];
            var noun = _nouns[random.Next(_nouns.Length)];
            var randomNumber = random.Next(1000, 9999);

            var generatedUsername = $"{adjective}{noun}{randomNumber}";
            Console.WriteLine("Zufälliger Benutzername: " + generatedUsername);
            return generatedUsername;
        }
    }
}
