namespace MAKlassenBibliothek;
using Figgle;
public class MAMenue
{
    public static void MASubMenue()
    {
        bool Exit = false;

        do
        {

            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("Mathematik"));

            //Konsolentitel wird geändert.
            Console.Title = "BFTMultiTool";

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                "                              >>> MA-SubMenue <<<\n" +
                                "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

            //Beschreibung der Software.
            // Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen verschiedene mathematische Aufgaben erleichtert\n
            // oder gelöst werden. Diese Aufgaben umfassen lineare Funktionen, einfache Statistik, Casinospiele sowie grundlegende\n
            //  Rechnerfunktionen. Das Tool richtet sich an Schüler und Lehrer, insbesondere im schulischen Kontext der Berufsfachschule\n
            //  für Technik. Durch die Integration dieser Funktionen wird das Lernen und Unterrichten von Mathematik erleichtert\n
            //  und effizienter gestaltet. Es bietet eine vielseitige Plattform, um mathematische Konzepte zu erforschen, zu üben und\n
            //   anzuwenden, um den Lernprozess zu verbessern\n\n");

            string HauptAusw;


            //Eingabeaufforderung 
            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Flaechenrechner");
            Console.WriteLine("\t2 - Taschenrechner");
            Console.WriteLine("\t3 - Casino App");
            Console.WriteLine("\t4 - Lineare Funktion");
            Console.WriteLine("\t5 - Einfache Statistik\n");
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
                    //Hier Feature1 aufrufen
                    Feature24.Feature_24();
                    break;

                case "4":
                    Console.Clear();
 
                    break;

                case "5":
                    Console.Clear();
                    //Hier das Wirtschaftsmenü aufrufen
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