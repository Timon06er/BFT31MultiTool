namespace PHKlassenBibliothek;
using Figgle;

public class PHMenue
{
    public static void PHSubMenue()
    {

            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Physik"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> PH-Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: subexit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nIm Bereich Physik bieten wir weitere Funktionen: \n" +
                                  "1. Berechnung des Volumens von Polyedern\n" +
                                  "2. Gewicht auf anderen Planeten berechnen\n" +
                                  "3. Infos zur Aufbau und Struktur der Materie\n" +
                                  "4. Vorsätze für Maßeinheiten umwandeln SI-Einheiten umrechen\n\n");

                string HauptAusw;
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        //Anastasiia
                        break;

                    case "2":
                        Console.Clear();
                        //Alex
                        break;

                    case "3":
                        Console.Clear();
                        //Ezgi
                        break;

                    case "4":
                        Console.Clear();
                        Feature9.Feature_9();
                        //Ender
                        break;
                    case "5":
                        Console.Clear();
                        //Jason
                        break;
                    case "subexit":
                        Console.Clear();
                        Exit=true;
                        //Jason
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);


        
    }
}
