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
                                  "                              >>> WI-Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");


            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");


                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool'finden Sie die berreiche Kreditrechner,Nebenkostenrechner,ein Aktien Spiel,Bestellverwaltungssystem und einen Zinsrechner.\n" +
                                  "Diese vereinfachen ihr privates Leben und mit dem Aktien Spiel können Sie einen Einblick rein werfen wie man in Aktien investiert. Diese Aufgaben\n" +
                                  "stehen Ihnen kostenlos zur Verfügung.\n\n");


            string HauptAusw;



                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");


                Console.WriteLine("\t1 - Nebenkostenrechner");
                Console.WriteLine("\t2 - Zinsrechner");
                Console.WriteLine("\t3 - Kreditrechner");
                Console.WriteLine("\t4 - Aktienspiel");
                Console.WriteLine("\t5 - Bestellverwaltungssystem \n");
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
                    Feature17.Feature_17();
                    //Hier das Informationstechnikmenü aufrufen
                    break;

                case "3":
                    Console.Clear();
                    Feature18.Feature_18();
                    //Hier das Mathematikmenü aufrufenc
                    break;


                    case "4":
                        Console.Clear();
                        //Hier das Physikmenü aufrufen
                        Feature19.Feature_19();
                        break;
                
                    case "5":
                    Console.Clear();
                    //Hier Feature20 aufrufen
                    Feature20.Feature_20();
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