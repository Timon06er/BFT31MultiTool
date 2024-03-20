using System;

namespace ITKlassenBibliothek
{
    internal class Feature12
    {
        internal static void Feature_12()
        {
           PasswordChecker.Run();
        }
    }

    public class PasswordChecker
    {
        public static void Run()
        {
            Console.WriteLine("Willkommen beim Passwort Checker");
            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine("Geben Sie Ihr Passwort ein:");
                string password = Console.ReadLine();
                if (IsStrongPassword(password))
                {
                    Console.WriteLine("Das ist ein starkes Passwort.");
                }
                else if (IsMediumPassword(password))
                {
                    Console.WriteLine("Das ist ein standard Passwort.");
                }
                else if (IsWeakPassword(password))
                {
                    Console.WriteLine("Das ist ein schwaches Passwort.");
                }
                exitRequested = PromptForExit();
            }
            Console.WriteLine("Programm wurde beendet.");
        }

        static bool IsWeakPassword(string password)
        {
            // Check if the password is shorter than 6 characters
            return password.Length < 6;
        }

        static bool IsMediumPassword(string password)
        {
            // Check if the password contains both letters and numbers
            return ContainsLetters(password) && ContainsNumbers(password);
        }

        static bool IsStrongPassword(string password)
        {
            // Check if the password contains letters, numbers, and special characters
            return ContainsLetters(password) && ContainsNumbers(password) && ContainsSpecialCharacters(password);
        }

        static bool ContainsLetters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsNumbers(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsSpecialCharacters(string input)
        {
            // Implement this method to check for special characters
            // For example, you can use regular expressions or a predefined set of special characters
            // Return true if any special character is found, otherwise return false
            // You can customize this logic based on your requirements
            // Placeholder implementation:
            return input.Contains("!") || input.Contains("@") || input.Contains("#");
        }

        static bool PromptForExit()
        {
            // Implement this method to prompt the user if they want to exit
            // Return true if the user wants to exit, otherwise return false
            // Placeholder implementation:
            Console.WriteLine("Möchten Sie das Programm beenden? (y/n)");
            string response = Console.ReadLine();
            return response.ToLower() == "y";
        }
    }
}
