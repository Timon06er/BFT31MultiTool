namespace ETKlassenBibliothek;
using Figgle;

public class ETMenue
{
    public static void ETSubMenue()
    {
        bool Exit = false;

        do
        {
            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("Elektrotechnik"));

            //Konsolentitel wird geändert.
            Console.Title = "BFTMultiTool";

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                "                              >>> ET-Submenue <<<\n" +
                                "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Eingabe: subexit\t->\tbeendet das Programm");

            //Beschreibung der Software.
            Console.WriteLine("\n\nWillkomen im Elektrotechnik Submenü\n");

            string HauptAusw;


            //Eingabeaufforderung 
            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Spannungsfall");
            Console.WriteLine("\t2 - Leitungsquerschnittberechnen");
            Console.WriteLine("\t3 - Widerstand/Spule");
            Console.WriteLine("\t4 - Kondensator/Ohmsches/Gesetz​/Leistungsgesetz");
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
                    //Hier das Mathematikmenü aufrufen
                    break;

                case "4":
                    Console.Clear();
                    //Hier Feature4 aufrufen 
                    Feature4.Feature_4();
                    break;
              
                    Console.WriteLine("Ungültige Eingabe");
                    Console.ReadKey();

                    (int, int) cPosAM = Console.GetCursorPosition();

                    KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                    break;
            }

        } while (!Exit);

    }

}
