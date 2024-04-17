1. [Aufteilung](#projekt-und-branchaufteilung)
2. [Anforderungen](#anforderungen)
3. [Richtlinien](#richtlinien)  
4. [Mergekonflikte](#mergekonflikte-vermeiden)  
5. [Organisation](#organisation)  


# MultiTool
Die Schüler des Bildungsganges Berufsfachschule wurden damit beauftragt eine Multi-Tool Software zu erstellen, welche allen kommenden Berufsfachschülern aus dem Bereich Technik als Hilfsmittel dienen soll, um ihren Schulabschluss erfolgreich zu meistern. Hierbei sollen wiederkehrende oder besonders aufwendige Aufgaben aus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben ergeben sich aus den Problemstellungen der Unterrichtseinheiten der Berufsfachschule für Technik. 

Das Projekt ist in die Bereiche Mathematik, Elektrotechnik… aufgeteilt. Diese Bereiche orientieren Sich an den Naturwissenschaftlichen Unterrichtsfächern der Berufsfachschule. Die nachfolgende Tabelle zeigt welche Features in den einzelnen Bereichen umgesetzt werden.


***Die Teamkoordinatoren können direkt in die jeweilige Entwicklungs-Branch schreiben. Die Entwickler müssen ein Pull-Request bei den jeweiligen Koodrinatoren stellen*** 

---

## Anforderungen

Die Einhaltung der Anforderungen wird bei der Bewertung der Teilprogramme geprüft.

|Framework Anforderungen | Anforderungen an die Benutzerfreundlichkeit| Externe Anforderungen|
|----------|----------|----------|
|Programmiert in C#|Programm und einzelne Optionen sind beliebig oft wiederholbar.|Alle gesetzlichen vorgaben werden eingehalten.|
|Konsolenanwendung|Eine Fehleingabe führt zu einer erneuten Eingabeaufforderung.|Moralische und ethische Grundsätze sind einzuhalten.|
|.NET 6 |Eingabeaufforderungen können ohne gültige Eingabe verlassen werden. |-|
|Alle Features und Menüs sind in der Klassenbibliothek zu erstellen|Das Programm kann in jederzeit beendet werden.|-|
|-|Alle Eingaben werden über die Tastatur gemacht.|-|
|-|Die Konsole wird beim Verlassen des aktuellen Moduls gelöscht.|-|

---

## Projekt und Branchaufteilung

Alle Teilnehmer die noch kein Feature eingereicht haben, sind dazu angehalten, zeitnah eins vorzuschlagen. 

***Die Teamkoordinatoren können direkt in die jeweilige Entwicklungs-Branch schreiben. Die Entwickler müssen ein Pull-Request bei den jeweiligen Koordinatoren stellen*** 

| Bereich     	    | Feature 	|Rolle		        |Username	|Branch		             |
| --------------- 	| -------- 	|------		        |--------	|-----------	         |
|**Administration**	|Release    |Administrator		| @AI-Assistant |Release, main   |
|		                |	          |		              |      		|		                   |		
|**Elektrotechnik**	|Menü ET/Spannungsfall|Teamkoordinator  |@Timsolo0408|ETEntwicklung,Feature1|
|                   |Leitungsquerschnittberechnen|Entwickler       |@Ilkan827|Feature2              |
|                   |Widerstand/Spule|Entwickler       |@Dokihappy|Feature3              |
|                   |Kondensator/Ohmsches/Gesetz​/Leistungsgesetz|Entwickler       |@Salaabbad|Feature4              |
|                   |           |Entwickler       |         |Feature5              |
|		                |	          |              		|		      |		                   |		
|**Physik**	        |Menü PY6 Volumen Von Würfeln, Kugeln, Pyramiden, und Prismen 	  |Teamkoordinator  | @anastasiiakhalaim |PHEntwicklung	,Feature6 |
|		                | Gewicht auf anderen Planeten Berechnen           |Entwickler	      | @Alexknoppik       |Feature7 	 |	
|		                |	  Infos zur aufbau und struktur der Materie         |Entwickler	      | @yagmurergin        |Feature8  | 
|		                | Gravitation und Winkel berechnung          |Entwickler	      | @EnderK58        |Feature9     |  
|		                |Vorsätze Für Maßeinheiten umwandeln SI-Einheiten umrechnen           |Entwickler       | @Jason22669         |Feature10             |		
|		                |	          |                 |         |                      |				
|**Informatik**	    |Menü IT  ,Zahlengenerator  |Teamkoordinator  |    @zhiqiangc67     |ITEntwicklung,Feature11|				
|		                |	   Password Checker       |Entwickler       |		@Timon06er      |Feature12             |		
|		                |	          |Entwickler       |   @Speed-king      |Feature13             |	
|		                |	   Random User Generator       |Entwickler       |  @LucMey	      |Feature14             |			
|		                |	          |Entwickler       |         |Feature15             |			
|		                |	          |	                |		      |		                   |				
|**Wirtschaft**	    |Menü WI,Nebenkostenrechner   |Teamkoordinator  |@Amannat01|WIEntwicklung,Feature16|				
|		                |   Zinsrechner               |Entwickler       |@MuhammedTR38|Feature17         |		
|		                |	     Kreditrechner          |Entwickler       |@brianbmc16|Feature18           |		
|		                |Aktien Spiel                 |Entwickler       |@Mamedderficker|Feature19       |	
|		            Bestellverwaltungssymstem         |Entwickler       |@Salemweeyo|Feature20           |	
|		                |	          |	              	|		      |                   	 |					
|**Mathematik**	    |Menü MT    |Teamkoordinator  | @can827       |MAEntwicklung,Feature21|				
|		                |Linare Funktion           |Entwickler       | @aliaaalmustafa      |Feature22             |		
|		                |Einfache Statistik           |Entwickler       | @shabub1      |Feature23             |		
|		                |Casino           |Entwickler       | @yazilim12 	      |Feature24             |
|		                |Rechner           |Entwickler	      | @musabhox     	|Feature25             |


---

## Richtlinien

Die Richtlinien dienen dazu, die Zusammenarbeit geordnet und übersichtlich zu gestalten. 

Es ist von höchster Wichtigkeit, dass sich alle an diese Richtlinien halten, ansonsten kann es zu schweren Problemen bei der Zusammenführung der Bereiche kommen. 

### Mergekonflikte vermeiden

|||
| ----------- 	| ----------- 	|
|  | Default Projekte **nicht** verändern!!|
| ⚠️ |**MultiTool** |
| ⚠️  |**KonsolenExtrasBibliothek**  |

Einstellungen oder Dateien dieser bereits in den Branches existierenden Projekte dürfen von **keinem** geändert werden. Eine Missachtung kann dazu führen das 

1. Der Teamkoordinator euren Pull-Request nicht merged (Code des Entwicklers wird nicht in das Projekt eingebunden).
2. Der Admin euren Team-Pull-Request nicht merged (Code des Teams wird nicht in das Projekt eingebunden).

@GSO-SW/teamkoordinatorenbft12  achtet darauf das die Richtlinien eingehalten werden. 🦅 


### Organisation

Alle Teamkoordinatoren müssen eine neue Klassenbibliothek für ihren Bereich erstellen. Um das Untermenü aufzurufen wird eine .cs Datei erstell welche Bereichsspezifisch benannt wird. Das Untermenü soll anschließend in einer Methode realisiert werden. 

|Bereich|Name der Klassenbibliothek|Untermenü Klassenname/Dateiname|Methodenbezeichnung|
| ----------- 	| ----------- 	| ----------- 	| ----------- 	|
| Elektrotechnik | ETKlassenBibliothek|ETMenue/ETMenue.cs|ETSubMenue|
| Informatik|ITKlassenBibliothek |ITMenue/ITMenue.cs|ITSubMenue|
| Mathematik  |MAKlassenBibliothek |MAMenue.cs/MAMenue|MASubMenue|
|Physik|PHKlassenBibliothek|PHMenue/PHMenue.cs|PHSubMenue|
|Wirtschaft|WIKlassenBibliothek|WIMenue/WIMenue.cs|WISubMenue|

Die jeweiligen Bereiche und Ihre Mitglieder erstellen und verändern nur Dateien in ihren **eigenen** Klassenbibliotheken. ⚠️ 

### Branches

Jedes Projektmitglied sollte eine Branch erstellen in der das Feature Programmiert wird. In der [Projektübersicht](#projekt-und-branchaufteilung) können die dafür zu verwendenden Branch-Bezeichnungen entnommen werden. 

Wenn Branches gepusht werden, die selber erstellt worden sind, sind diese nicht schreibgeschützt. Aus diesem Grund ist darauf zu achten das nur in der eigenen Branch programmiert wird.
