using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using WIKlassenBibliothek;

namespace MultiTool
{
    internal class Hauptmenue
    {
        public static void HauptmenueAufruf()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> WI-Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool'finden Sie die berreiche Kreditrechner,Nebenkostenrechner,ein Aktien Spiel,Bestellverwaltungssystem und einen Zinsrechner.\n" +
                                  "Diese vereinfachen ihr privates Leben und mit dem Aktien Spiel können Sie einen Einblick rein werfen wie man in Aktien investiert. Diese Programme\n" +
                                  "stehen Ihnen kostenlos zur Verfügung.\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\te - Elektrotechnick");
                Console.WriteLine("\ti - Informatik");
                Console.WriteLine("\tm - Mathematik");
                Console.WriteLine("\tp - Physik");
                Console.WriteLine("\tw - Wirtschaft\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "e":
                        Console.Clear();
                        //Hier das Etechnikmenü aufrufen
                        break;

                    case "i":
                        Console.Clear();
                        //Hier das Informationstechnikmenü aufrufen
                        break;

                    case "m":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        break;

                    case "p":
                        Console.Clear();
                        //Hier das Physikmenü aufrufen
                        break;

                    case "w":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        WIMenue.WISubMenue();


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
}