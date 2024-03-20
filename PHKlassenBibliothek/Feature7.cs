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
                        new Planet { Name = "Jupiter", Gravitation = 23.1 },
                        new Planet { Name = "Venus", Gravitation = 8.87 },
                        new Planet { Name = "Merkur", Gravitation = 3.7 },
                        new Planet { Name = "Saturn", Gravitation = 9.3 },
                        new Planet { Name = "Uranus", Gravitation = 8.69 },
                        new Planet { Name = "Neptun", Gravitation = 11.15 }
                    };
 




        do
        {
             Console.Clear();
            double gewicht;
            double gewicht2;
            string Planet;
            Console.WriteLine
            (FiggleFonts.Slant.Render("Planeten"));
            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");
            Console.WriteLine("Willkommen beim rechner vom gewicht auf anderen planeten");
            Console.WriteLine("1. Benutzerdefiniert");
            Console.WriteLine("2. Gewicht berechnen");

            int num = 1;

            foreach(Planet planet in planeten)
            {
                Console.WriteLine($"{num} {planet.Name} {planet.Gravitation}");
                num++;
            }

            string eingabe_auswahl = Console.ReadLine();

            Console.WriteLine("Planetenliste");

            
            if(eingabe_auswahl=="1")
            {
               
                Console.WriteLine("Geben Sie den Namen des neuen Planeten ein:");
                string name_neu = Console.ReadLine();
                if (name_neu == "exit")
                {
                    Console.Clear();
                    return;
                }

                Console.WriteLine("Geben Sie die Gravitationskraft des neuen Planeten ein:");
                string gravitationseingabe = Console.ReadLine();
                

                if (gravitationseingabe == "exit")
                {
                    Console.Clear();
                    return;
                }
                double gravitation_neu;

                while (!double.TryParse(gravitationseingabe, out gravitation_neu))
                 {
                    Console.WriteLine("Ungültige Eingabe für die Gravitationskraft. Bitte geben Sie eine Zahl ein:");
                    gravitationseingabe = Console.ReadLine();

                    if (gravitationseingabe == "exit")
                    {
                       Console.Clear();
                        return;
                    }
                
                 }
                
                Planet neu_planet = new Planet 
                { 
                    Name = name_neu, 
                    Gravitation = gravitation_neu 
                };
                planeten.Add(neu_planet);
            }
            else if(eingabe_auswahl=="2")
            {
              
                bool flag_conv;


               
                 Planet planet_ausw = new Planet();
                do
                {  
                  (int, int) cPosXM = Console.GetCursorPosition();
                 Console.WriteLine("Wählen sie eine planeten nummer aus");
                 Planet = Console.ReadLine();
                
                 if (Planet == "exit")
                 {
                    Console.Clear();
                    return;
                 }
            
                 flag_conv = int.TryParse(Planet, out int planet_int);
                 if (flag_conv == true && planet_int >= 1 && planet_int <= planeten.Count)
                 {
                    planet_ausw = planeten.ElementAt(planet_int-1);
                    Console.WriteLine(planet_ausw.Gravitation);
                    Console.ReadLine();
                   
                 }
                 else
                 {
                    Console.WriteLine("Falsche eingabe");
                    (int, int) cPosZM = Console.GetCursorPosition();    
                    KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosXM.Item2, cPosZM.Item2);
                   flag_conv=false;
                   Console.ReadLine();
                 }
                }while(flag_conv == false);
                
                
                 









            
                 
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
                     gewicht2 = gewicht/9.81*planet_ausw.Gravitation;
                Console.WriteLine($"Das Gewicht auf {planet_ausw.Name} beträgt: {gewicht2:F4} kg");
                Console.ReadLine();





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
   



            
           

        }
        while(true);

            
    }
}

internal class Planet 
{
    public string? Name {get; set;}
    public double Gravitation {get; set;}

}