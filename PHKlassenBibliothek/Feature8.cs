
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Timers;

namespace PHKlassenBibliothek;

internal class Feature8
{       
    internal static void Feature_8()

	{
		bool weiter = true;
		
		
			
        do{
			Console.WriteLine($"Willkommen bei Physik für Anfänger!");
			Console.ReadLine();
			Console.WriteLine("\n\nIm Bereich Physik bieten wir Funktionen wie: \n" +
					"1. Atom und Kernenergie\n" +
					"2. Astronomie\n" +
					"3. Radioaktivität\n" +
					"4. Quantenphysik\n" +
					"5. Atom- & Molekülphysik\n" +
					"6. Kern- & Teilchenphysik\n" +
					"7. Festkörperphysik\n" +
					"8. Röntgenphysik\n" +
					"9. Nanotechnologie\n" +
					"10. Elektrischer Strom\n" +
					"11. Elektrodynamik\n" +
					"12. Kernphysik\n" +
					"13. Temparatur\n" +
					"13. Kreisbewegungen\n" +
					"14. Dichte\n" +
					"15. Thermodynamik\n" +
					"16. Mechanik\n");

			Console.WriteLine($"Wenn Sie das Programm erneut starten möchten tippen Sie Exit ein!");
			
			Console.WriteLine($"Geben Sie ihr gewünschtes Thema ein:");
			string Physik_Lexikon = Console.ReadLine();

		
			
			
			if(Physik_Lexikon == "Atom und Kernenergie")
			{
				Console.WriteLine($"Atom und Kernenergie ausführung:");
				Console.WriteLine($"Definition: Das Atom ist die kleinste Einheit eines Elements, bestehend aus einem positiv geladenen Kern aus Protonen und neutralen Neutronen, umgeben von negativ geladenen Elektronen. Kernenergie bezieht sich auf die Freisetzung von Energie aus Kernreaktionen.");
				Console.WriteLine($"Aufbau: Im Atomkern befinden sich Protonen und Neutronen, wahrend Elektronen in Energieebenen um den Kern kreisen. Die Wechselwirkung zwischen diesen Bestandteilen bestimmt die Stabilität und chemischen Eigenschaften.");
				
			}
			else if(Physik_Lexikon == "Astronomie")
			{
				Console.WriteLine($"Astronomie ausführung:");
				Console.WriteLine($"Definition: Astronomie ist die wissenschaftliche Erforschung von Himmelskörpern wie Sternen, Planeten und Galaxien sowie ihrer Eigenschaften, Bewegungen und Entwicklungen.");
				Console.WriteLine($"Aufbau: Astronomie nutzt Teleskope und andere Instrumente, um elektromagnetische Strahlung zu erfassen. Dabei werden Methoden wie Spektroskopie und Fotometrie eingesetzt, um Informationen über die kosmischen Objekte zu gewinnen.");
			}
			else if(Physik_Lexikon == "Radioaktivität")
			{
				Console.WriteLine($"Radioaktivität ausführung:");
				Console.WriteLine($"Definition: Radioaktivität ist ein natürlicher Prozess, bei dem instabile Atomkerne zerfallen und dabei Energie in Form von Partikeln oder elektromagnetischer Strahlung freisetzen.");
				Console.WriteLine($"Aufbau: Instabile Kerne können Alpha- oder Beta-Zerfall erfahren, wobei Alpha- oder Beta-Teilchen emittiert werden. Dieser Zerfallsprozess führt zur Umwandlung des instabilen Kerns in einen stabilen Zustand.");
			}    
			else if(Physik_Lexikon == "Quantenphysik")
			{
				Console.WriteLine($"Quantenphysik ausführung:");
				Console.WriteLine($"Definition: Die Quantenphysik beschreibt das Verhalten von Teilchen auf subatomarer Ebene und verwendet quantisierte Größen wie Energie und Impuls");
				Console.WriteLine($"Aufbau: Schlüsselkonzepte umfassen Quantensprünge, Unschärferelation und den Wellen-Teilchen-Dualismus. Quantenmechanik beschreibt die Wahrscheinlichkeitsverteilung von Teilchenzuständen");
			}
			else if(Physik_Lexikon == "Atom- & Molekülphysik")
			{
				Console.WriteLine($"Atom- & Molekülphysik ausführung:");
				Console.WriteLine($"Definition: Atomphysik untersucht die Eigenschaften und Struktur von Atomen, während Molekülphysik die Wechselwirkungen zwischen Molekülen analysiert.");
				Console.WriteLine($"Aufbau: Atomphysik befasst sich mit Elektronenkonfigurationen und Energieniveaus in Atomen. Molekülphysik betrachtet Bindungen und geometrische Anordnungen von Atomen in Molekülen");
			}
			else if(Physik_Lexikon == "Kern- & Teilchenphysik")
			{
				Console.WriteLine($"Kern- & Teilchenphysik ausführung:");
				Console.WriteLine($"Definition: Kernphysik untersucht die Struktur und Dynamik von Atomker, während Teilchenphysik sich mit subatomaren Partikeln und ihren Wechselwirkungen befasst.");
				Console.WriteLine($"Aufbau: Kernphysik analysiert Kräfte in Atomkernen und Kernreaktionen. Teilchenphysik identifiziert und charakterisiert Elementarteilchen wie Quarks und Leptonen.");
			}
			else if(Physik_Lexikon == "Festkörperphysik")
			{
				Console.WriteLine($"Festkörperphysik ausführung:");
				Console.WriteLine($"Definition: Die Festkörperphysik erforscht die Eigenschaften von festen Materialien auf atomarer und molekularer Ebene sowie deren Verhalten unter verschiedenen Bedingungen");
				Console.WriteLine($"Aufbau: Themen in der Festkörperphysik umfassen die Kristallstruktur, elektronische Bandstruktur und magnetische Eigenschaften von Materialien. Sie spielt eine Schlüsselrolle in der Entwicklung neuer Technologien, wie z. B. Halbleiter in der Elektronik.");
			}
			else if(Physik_Lexikon == "Röntgenphysik")
			{   
				Console.WriteLine($"Röntgenphysik ausführung:");
				Console.WriteLine($"Definition: Rontgenphysik beschäftigt sich mit der Erzeugung und Anwendung von Rontgenstrahlen, insbesondere in der medizinischen Bildgebung und der Materialanalyse.");
				Console.WriteLine($"Aufbau: Röntgenquellen erzeugen hochenergetische Strahlen, die durch Materie hindurchgehen. Bei der Röntgenbildgebung werden durch die Wechselwirkung mit Gewebe oder Materialien Bilder erzeugt, die Strukturdetails offenbaren.");
			}
			else if(Physik_Lexikon == "Nanotechnologie")
			{	
				Console.WriteLine($"Nanotechnologie ausführung:");
				Console.WriteLine($"Definition: Nanotechnologie befasst sich mit der Manipulation von Materie auf der Nanoskala, typischerweise im Bereich von 1 bis 100 Nanometern.");
				Console.WriteLine($"Aufbau: In der Nanotechnologie werden Werkzeuge und Techniken auf atomarer und molekularer Ebene eingesetzt, um neue Materialien mit einzigartigen Eigenschaften zu schaffen. Anwendungen reichen von Medizin bis zu Elektronik.");
			}
			else if(Physik_Lexikon == "Elektrischer Strom")
			{
				Console.WriteLine($"Elektrischer Strom ausführung:");
				Console.WriteLine($"Definition: Elektrischer Strom ist der gerichtete Fluss von elektrisch geladenen Teilchen, insbesondere Elektronen, in einem elektrischen Leiter.");
				Console.WriteLine($"Aufbau: Elektrischer Strom entsteht durch Anlegen einer elektrischen Spannung. In einem geschlossenen Stromkreis bewegen sich Elektronen von einem negativen zu einem positiven Pol.");
			}
			else if(Physik_Lexikon == "Elektrodynamik")
			{
				Console.WriteLine($"Elektrodynamik ausführung: ");
				Console.WriteLine($"Definition: Elektrodynamik ist ein Teilgebiet der Physik, das die Wechselwirkung geladener Teilchen unter Einfluss von elektrischen und magnetischen Feldern untersucht.");
				Console.WriteLine($"Aufbau: Elektrodynamik integriert Elektrizität und Magnetismus. Maxwells Gleichungen beschreiben die Beziehung zwischen elektrischen Feldern, magnetischen Feldern und elektrischem Strom.");
			}
			else if(Physik_Lexikon == "Kernphysik")
			{
				Console.WriteLine($"Kernphysik ausführung:");
				Console.WriteLine($"Definition: Kernphysik erforscht Eigenschaften und Verhalten von Atomkernen, einschließlich ihrer Struktur, Stabilität und Reaktionen.");
				Console.WriteLine($"Aufbau: Der Atomkern besteht aus Protonen (positiv geladen) und Neutronen (neutral). Kernphysik analysiert Kernreaktionen, wie Fusion und Spaltung, die Energie freisetzen.");
			}
			else if(Physik_Lexikon == "Temperatur")
			{
				Console.WriteLine($"Temperatur ausführung: ");
				Console.WriteLine($"Definition: Temperatur ist eine Maßeinheit für die durchschnittliche kinetische Energie von Teilchen in einem System.");
				Console.WriteLine($"Aufbau: Sie wird gemessen mit Thermometern. Bei höherer Temperatur bewegen sich Teilchen schneller. Kelvin ist die absolute Temperaturskala, bei der 0 K der theoretische absolute Nullpunkt ist");
			}
			else if(Physik_Lexikon == "Kreisbewegungen")
			{
			Console.WriteLine($"Kreisbewegungen ausführung:");
			Console.WriteLine($"Definition: Kreisbewegungen beschreiben die Rotation eines Objekts um einen festen Punkt, den Mittelpunkt der Kreisbahn.");
			Console.WriteLine($"Aufbau: Der Aufbau umfasst Parameter wie Radius, Winkelgeschwindigkeit und Zentripetalkraft. Diese Bewegungen sind fundamental in vielen Bereichen, von Planetenbahnen bis zu technischen Anwendungen.");
			}
			else if (Physik_Lexikon == "Dichte")
			{
				Console.WriteLine($"Dichte ausführung:");
				Console.WriteLine($"Definition: Die Dichte ist eine physikalische Größe, die das Verhältnis von Masse zu Volumen eines Objekts beschreibt. Sie gibt an, wie viel Masse in einem bestimmten Raum vorhanden ist.");
				Console.WriteLine($"Aufbau: Die Dichte (p) wird durch die Formel p = m/V berechnet, wobei m die Masse und V das Volumen ist. Objekte mit höherer Dichte haben mehr Masse pro Volumeneinheit.");
			} 
			else if (Physik_Lexikon == "Thermodynamik")
			{
                Console.WriteLine($"Thermodynamik ausführung:");
				Console.WriteLine($"Definition: Definition: Thermodynamik beschäftigt sich mit der Untersuchung von Wärme und Energieumwandlungen sowie den physikalischen Gesetzen, die diese Phanomene regeln.");
				Console.WriteLine($"Aufbau: Aufbau: Grundlegende Konzepte umfassen die Zustandsänderungen von Materie, Wärmeübertragung und die Arbeit, die durch thermodynamische Prozesse verrichtet wird. Die Gesetze der Thermodynamik sind fundamentale Prinzipien.");
			}
			else if (Physik_Lexikon == "Mechanik")
			{
				Console.WriteLine($"Mechanik ausführug:");
				Console.WriteLine($"Definition: Mechanik beschäftigt sich mit den Gesetzen der Bewegung und Kräfte, die auf Körper wirken.");
				Console.WriteLine($"Aufbau: Klassische Mechanik behandelt makroskopische Objekte und ba t auf den Gesetzen von Newton. Quantenmechanik ist die Mechanik auf subatomar Ebene und beschreibt das Verhalten von Elementarteilchen.");  
			
			}
			else if (Physik_Lexikon == "exit")
			{
				return;
			}
			else
			{
				Console.WriteLine($"Fehler");
	
			}			
	
		} while (true);	
	} 
}       


              
            
		   
            

			