namespace ETKlassenBibliothek;
using Figgle;
internal class Feature2
{
    internal static void Feature_2()
    {
  
       do
       {   
            Console.Clear();
           
            static void schreiben(string number, string message)
            {
            Console.Write("[");
            Console.Write(number);
            Console.WriteLine("] " + message);
            }


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(FiggleFonts.Slant.Render("EYWA"));
            Console.Title = "EYWA";
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Willkommen zum Leitungsquerschnittsberechner");
            Console.ResetColor();

            Console.WriteLine("Wählen Sie eine Option:");

            schreiben("1", "Leitungsquerschnitt berechnen");
            Console.ForegroundColor = ConsoleColor.Red;
            schreiben("2", "Beenden");
            Console.ResetColor();
            char auswahl = Console.ReadKey().KeyChar;
            Console.WriteLine(); 
            switch (auswahl)
            {
                case '1':
                    BerechneLeitungsquerschnitt();
                    break;
                case '2':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie erneut.");
                    break;
            }
        } while (true);
   }
   static void BerechneLeitungsquerschnitt()
   {
       double stromstaerke, spannung;
       if (TryGetDoubleInput("Geben Sie die Stromstärke in Ampere ein: ", out stromstaerke) &&
           TryGetDoubleInput("Geben Sie die Spannung in Volt ein: ", out spannung))
       {
           double leitungsquerschnitt = stromstaerke / spannung;
           Console.WriteLine($"Der Leitungsquerschnitt beträgt {leitungsquerschnitt} Quadratmillimeter.");
       }
       else
       {
           Console.WriteLine("Ungültige Eingabe. Bitte geben Sie gültige Zahlen ein.");
       }
       Console.ReadLine();
   }
   static bool TryGetDoubleInput(string prompt, out double result)
   {
       Console.Write(prompt);
       string input = Console.ReadLine();
       return double.TryParse(input, out result);
   }
}
