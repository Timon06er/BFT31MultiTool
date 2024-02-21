namespace PHKlassenBibliothek;
using Figgle;
using System.Collections.Generic;
using System.Formats.Asn1;

internal class Feature7


{
    internal static void Feature_7()
    {




        List<Planet> planeten = new List<Planet>
                    {

                        new Planet { Name = "Mars", Gravitation = 3.71 },
                        new Planet { Name = "Mars", Gravitation = 3.71 },
                        new Planet { Name = "Jupiter", Gravitation = 23.1 },
                        new Planet { Name = "Venus", Gravitation = 8.87 },
                        new Planet { Name = "Merkur", Gravitation = 3.7 },
                        new Planet { Name = "Saturn", Gravitation = 9.3 },
                        new Planet { Name = "Uranus", Gravitation = 8.69 },
                        new Planet { Name = "Neptun", Gravitation = 11.15 }
                    };
 




        do
        {
            // Console.Clear();
            double gewicht;
            double gewicht2;
            string Planet;
            Console.WriteLine
            (FiggleFonts.Slant.Render("Planeten"));
            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");
            Console.WriteLine("Willkommen beim rechner vom gewicht auf anderen planeten");
            Console.WriteLine("1. Benutzerdefiniert");
            Console.WriteLine("2. Gewicht berechnen");
            string eingabe_auswahl = Console.ReadLine();

            Console.WriteLine("Planetenliste");

            int num = 1;

            foreach(Planet planet in planeten)
            {
                Console.WriteLine($"{num} {planet.Name} {planet.Gravitation}");
                num++;
            }
            
            if(eingabe_auswahl=="1")
            {
                //Neuer Listeneintrag
                //   Console.WriteLine("Geben Sie den Namen des neuen Planeten ein:");
                //     string name_neu = Console.ReadLine();
                //     if(name_neu == "exit")
                //     {
                //         Console.Clear();
                //         return;
                //     }

                //     Console.WriteLine("Geben Sie die Gravitationskraft des neuen Planeten ein:");
                //     double gravitation_neu;
                //     if(gravitation_neu == "exit")
                //     {
                //         Console.Clear();
                //         return;
                //     }
                //     while (!double.TryParse(Console.ReadLine(), out gravitation_neu))
                //     {
                //         Console.WriteLine("Ungültige Eingabe für die Gravitationskraft. Bitte geben Sie eine Zahl ein:");
                //     }

                //     Planet neu_planet = new Planet
                //     {
                //         Name = name_neu,
                //         Gravitation = gravitation_neu
                //     };
                //     planeten.Add(neu_planet);

            }
            else if(eingabe_auswahl=="2")
            {
                //Gewicht berechnen
                bool flag_conv;


                Console.WriteLine("Wählen sie eine planeten nummer aus oder fügen sie einen planeten hinzu");
                Planet = Console.ReadLine();

                flag_conv = int.TryParse(Planet, out int planet_int);

                if(flag_conv ==true && planet_int<9 && planet_int>0 )
                {
                    Planet planet_ausw = planeten.ElementAt(planet_int-1);
                    Console.WriteLine(planet_ausw.Gravitation);
                    Console.ReadLine();
                }
                else if(Planet == "exit")
                {
                    Console.Clear();
                    return;
                }









                //Eingabe Gewicht
                 
                do{
                    (int, int) cPosBM = Console.GetCursorPosition();
                    Console.WriteLine("Bitte geben sie ihr Gewicht ein was sie auf anderen planeten wissen möchten(in kg und nur in zahlen )");

                    string gewicht_str = Console.ReadLine();

                    if(gewicht_str=="exit")
                    {
                        Console.Clear();
                        return;
                    }

                    flag_conv = double.TryParse(gewicht_str,out gewicht);

                    if(flag_conv == false)
                    {
                        Console.WriteLine("Sie haben eine falsche eingabe gemacht...");
                        Console.ReadLine();
                        (int, int) cPosAM = Console.GetCursorPosition();    
                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                    }
                }while(flag_conv == false);





            }
            else if(eingabe_auswahl=="exit")
            {
                 Console.Clear();
                    return;
            }
            else
            {
                 Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie 1, 2 oder exit.");
                    Console.ReadLine();
            }



            
            // bool flag_cond;
            
            // do{
            //     flag_cond = true;
            //     (int, int) cPosLM = Console.GetCursorPosition();
            //     Console.WriteLine("Wählen sie eine planeten nummer aus oder fügen sie einen planeten hinzu");
            //     Planet = Console.ReadLine();

              
            //     else if(Planet =="neu")
            //     {
            //         string name_neu = Console.ReadLine();

            //         Planet neu_planet  = new Planet {
            //             Name=name_neu,

            //             Gravitation = 9.81
            //         };
            //         planeten.Add(neu_planet);
            //     }
            //     else if(Planet <= planeten.Count)
            //     {
            //         //Berechnen
            //     }
            //     else
            //     {
            //             //Fehler
            //     }
                
                

            //     if (Planet == "Mars")
            //     {
            //         gewicht2 = gewicht/9.81*3.71;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Mars beträgt"}{gewicht2,10:F3} kg");


            //     }
            //     else if (Planet == "Jupiter")
            //     {
            //         gewicht2 = gewicht/9.81*23.1;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Jupiter beträgt"}{gewicht2,10:F3} kg");
                    
            //     }
            //     else if (Planet == "Venus")
            //     {
            //         gewicht2 = gewicht/9.81*8.87;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Venus beträgt"}{gewicht2,10:F3} kg");
            //     }
            //     else if (Planet == "Merkur")
            //     {
            //         gewicht2 = gewicht/9.81*3.7;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Merkur beträgt"}{gewicht2,10:F3} kg");
            //     }
            //     else if (Planet == "Saturn")
            //     {
            //         gewicht2 = gewicht/9.81*9.3;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Saturn beträgt"}{gewicht2,10:F3} kg");
            //     }
            //     else if (Planet == "Uranus")
            //     {
            //         gewicht2 = gewicht/9.81*8.69;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Uranus beträgt"}{gewicht2,10:F3} kg");
            //     }
            //     else if (Planet == "Neptun")
            //     {
            //         gewicht2 = gewicht/9.81*11.15;
            //         Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Neptun beträgt"}{gewicht2,10:F3} kg");
                    
            //     }
            //     else{
            //         Console.WriteLine("Du hast eine Falsche Ausgabe gemacht");
            //         Console .ReadLine();

            //         flag_cond = false;
            //         (int, int) cPosMM = Console.GetCursorPosition(); 
            //     KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosLM.Item2, cPosMM.Item2);
            //     }
            //     Console.ReadLine();
                
            //  }
            // while(flag_cond == false);

        }
        while(true);

            
    }
}

internal class Planet 
{
    public string? Name {get; set;}
    public double Gravitation {get; set;}

}