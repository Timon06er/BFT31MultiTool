namespace PHKlassenBibliothek;

internal class Feature7
{
    internal static void Feature_7()
    {
        bool flag = false;
        do
        {
            Console.Clear();
            double gewicht;
            double gewicht2;
            string Planet;
            Console.WriteLine("Willkommen beim rechner vom gewicht auf anderen planeten");
            bool flag_conv = false; 
            do{
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine("Bitte geben sie ihr Gewicht ein was sie auf anderen planeten wissen möchten(in kg und nur in zahlen )");

                string gewicht_str = Console.ReadLine();

                if(gewicht_str=="exit")
                {
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
            bool flag_cond = true;
            do{
                (int, int) cPosLM = Console.GetCursorPosition();
                Console.WriteLine("Bitte geben sie denn planeten an Mars,Jupiter,Venus,Merkur,Saturn,Uranus,Neptun");
                Planet = Console.ReadLine();

                if(Planet == "exit")
                {
                    return;
                }

                if (Planet == "Mars")
                {
                    gewicht2 = gewicht/9.81*3.71;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Mars beträgt"}{gewicht2,10:F3} kg");


                }
                else if (Planet == "Jupiter")
                {
                    gewicht2 = gewicht/9.81*23.1;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Jupiter beträgt"}{gewicht2,10:F3} kg");
                    
                }
                else if (Planet == "Venus")
                {
                    gewicht2 = gewicht/9.81*8.87;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Venus beträgt"}{gewicht2,10:F3} kg");
                }
                else if (Planet == "Merkur")
                {
                    gewicht2 = gewicht/9.81*3.7;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Merkur beträgt"}{gewicht2,10:F3} kg");
                }
                else if (Planet == "Saturn")
                {
                    gewicht2 = gewicht/9.81*9.3;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Saturn beträgt"}{gewicht2,10:F3} kg");
                }
                else if (Planet == "Uranus")
                {
                    gewicht2 = gewicht/9.81*8.69;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Uranus beträgt"}{gewicht2,10:F3} kg");
                }
                else if (Planet == "Neptun")
                {
                    gewicht2 = gewicht/9.81*11.15;
                    Console.WriteLine($"{"Ihr eingegebenes gewicht auf dem Neptun beträgt"}{gewicht2,10:F3} kg");
                    
                }
                else{
                    Console.WriteLine("Du hast eine Falsche Ausgabe gemacht");
                    Console .ReadLine();

                    flag_cond = false;
                }
                (int, int) cPosMM = Console.GetCursorPosition(); 
                KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosLM.Item2, cPosMM.Item2);
            }while(flag_cond == false);


           
            Console.WriteLine("Möchtest du denn code wiederholen? Wenn ja bitte gib true ein, falls nein bitte gib false ein?!");
            flag = Convert.ToBoolean(Console.ReadLine());
        }
        while( flag == true);

    }
}