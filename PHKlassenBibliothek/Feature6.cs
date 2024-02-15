namespace PHKlassenBibliothek;

internal class Feature6
{
    internal static void Feature_6()
    { 
        double r = 0, breite = 0, laenge = 0, hoehe = 0;
        bool flag = false;

        kugel = (4.0/3.0)*Math.PI*Math.Pow(r, 3);
        kegel = (1.0/3.0)*Math.PI*Math.Pow(r, 3)*hoehe;
        wuerfel = Math.Pow(breite, 3);
        //pyramide = 
        quader = breite*laenge*hoehe;
        zylinder = Math.PI*Math.Pow(r, 3)*hoehe; 


        Console.WriteLine("Willkommen beim Rechner von Volumen von Polyedern!");
        
        Console.WriteLine("Wählen Sie ein Vieleck: \n" +
                            "1 Würfer\n" +
                            "2 \n" +
                            "3\n" +
                            "4\n" +
                            "\n" +
                            "\n" +
                            "\n" );


    }
}