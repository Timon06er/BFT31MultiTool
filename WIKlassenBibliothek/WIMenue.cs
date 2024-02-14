using Figgle;
namespace WIKlassenBibliothek;
public class WIMenue
{
    public static void WISubMenue()
    {
 bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Wirtschaft"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Wirtschaft Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' findet man 5 verschiedene spiele/rechner.\n" +
                                  "Damit kann man die jeweiligen Sachen berechnen und spaß am spielen haben. Dies Vereinfacht Ihnen das Rechnen.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Nebenkostenrechner");
                Console.WriteLine("\t2 - Zinsrechner");
                Console.WriteLine("\t3 - Kreditrechner");
                Console.WriteLine("\t4 - Aktien Spiel");
                Console.WriteLine("\t5 - Bestellverwaltungssymstem \n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        //Hier das Etechnikmenü aufrufen
                        break;

                    case "2":
                        Console.Clear();
                        //Hier das Informationstechnikmenü aufrufen
                        break;

                    case "3":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufenc
                        break;

                    case "4":
                        Console.Clear();
                        //Hier das Physikmenü aufrufen
                        break;

                    case "5":
                        Console.Clear();
                        //Hier das Wirtschaftsmenü aufrufen
                        //Aufruf Feature20
                        break;

                    case "exit":
                        Exit = true;
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