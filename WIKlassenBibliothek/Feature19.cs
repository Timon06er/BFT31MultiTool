namespace WIKlassenBibliothek;
using System;
using System.Collections.Generic;
using System.Threading;

class LuxuryItem
    {
        public string Name;
        public double Price;

        public LuxuryItem(string name, double initialPrice)
        {
            Name = name;
            Price = initialPrice;
        }
    }

class Stock
    {
        public string Name;
        public double Price;
        public int Menge;


        public Stock(string name, double initialPrice)
        {
            Name = name;
            Price = initialPrice;
            Menge = 0;
        }
    }

internal class Feature19
{
    static double AnzahldergüterImmobilie0 = 0;
    static double AnzahldergüterImmobilie1 = 0;
    static double AnzahldergüterImmobilie2 = 0;
    static double AnzahldergüterImmobilie3 = 0;
    static double AnzahldergüterImmobilie4 = 0;
    static double AnzahlderWertgegenstände0 = 0;
    static double AnzahlderWertgegenstände1 = 0;
    static double AnzahlderWertgegenstände2 = 0;
    static double AnzahlderWertgegenstände3 = 0;
    static double AnzahlderWertgegenstände4 = 0;
    static double AnzahlderWertgegenstände5 = 0;
    static double AnzahlderWertgegenstände6 = 0;
    static double AnzahlderWertgegenstände7 = 0;
    static double AnzahlderWertgegenstände8 = 0;





    static double kapital = 10000000.0;
    static List<Stock> stocks = new List<Stock>();
    static List<LuxuryItem> luxuryItems = new List<LuxuryItem>();


    static void Feature_19()
    {

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Willkommen zur Aktien-Wirtschaftssimulation!");

        Console.ForegroundColor = ConsoleColor.Blue;
        stocks.Add(new Stock("TechCorp", 50.0));
        stocks.Add(new Stock("PharmaCare", 30.0));
        stocks.Add(new Stock("GreenEnergy", 40.0));
        stocks.Add(new Stock("AutoMotive", 60.0));
        Console.ResetColor();
        while (true)
        {
            PrintStatus();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Aktien kaufen");
            Thread.Sleep(200);
            Console.WriteLine("2. Aktien verkaufen");
            Thread.Sleep(200);
            Console.WriteLine("3. Luxusgüter kaufen");
            Thread.Sleep(200);
            Console.WriteLine("4. Luxusgüter verkaufen");
            Thread.Sleep(200);
            Console.WriteLine("5. Luxusgüter anzeigen");
            Thread.Sleep(200);
            Console.WriteLine("6. Info");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("7. Simulation beenden");
            Console.ResetColor();

            string eingabe = Console.ReadLine();
            switch (eingabe)
            {
                case "1":
                    Console.Clear();
                    BuyStock();
                    break;

                case "2":
                    Console.Clear();
                    SellStock();
                    break;

                case "3":
                    Console.Clear();
                    LuxuryItemMenu();
                    break;

                case "4":
                    Console.Clear();
                    SellLuxuryItemMenu();

                    break;

                case "5":
                    Console.Clear();
                    PrintLuxuryItemsStatus();
                    break;

                case "6":
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Info");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("" +
                        "Mach so viel Profit wie es möglich ist indem du Aktien günstig kaufst und teurer verkaufst. Obendrauf kannst du noch Immobielen , Wertgegenstände und  Materialien kaufen um Geld zu erwirtschaften. ");
                    Console.ResetColor();
                    Thread.Sleep(300);
                    break;

                case "7":
                    Console.WriteLine("Simulation beendet.");
                    Environment.Exit(0);
                    break;

                default:

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                    Console.ResetColor();

                    break;
            }

            Thread.Sleep(500);
        }
    }

    static void PrintStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Kapital: {kapital:C2}");
        Console.ResetColor();

        foreach (var stock in stocks)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{stock.Name}: Preis {stock.Price:C2} | Menge {stock.Menge}");
        }
    }

    static void BuyStock()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Verfügbare Aktien zum Kauf:");
            Console.ResetColor();

            for (int i = 0; i < stocks.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i + 1}. {stocks[i].Name} - {stocks[i].Price:C2}");
            }

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{stocks.Count + 1}. Zurück zum Hauptmenü");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Wähle eine Option aus (1 - {0}): ", stocks.Count + 1);
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > stocks.Count + 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Auswahl! Bitte geben Sie eine gültige Nummer ein.");
                Console.ResetColor();
                Console.Write("Wähle eine Option aus (1 - {0}): ", stocks.Count + 1);
            }

            if (option == stocks.Count + 1)
            {
                Console.Clear();
                return;
            }

            int indexToBuy = option - 1;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Anzahl der zu kaufenden {stocks[indexToBuy].Name}-Aktien: ");
            int quantityToBuy;

            while (!int.TryParse(Console.ReadLine(), out quantityToBuy) || quantityToBuy <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige positive Zahl ein.");
                Console.ResetColor();
                Console.Write($"Anzahl der zu kaufenden {stocks[indexToBuy].Name}-Aktien: ");
            }

            double totalCost = stocks[indexToBuy].Price * quantityToBuy;

            if (totalCost > kapital)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nicht genügend Kapital!");
            }
            else
            {
                kapital -= totalCost;
                stocks[indexToBuy].Menge += quantityToBuy;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine($"Gekauft {quantityToBuy} {stocks[indexToBuy].Name}-Aktien für {totalCost:C2}");
            }

            UpdateStockPrices();
            UpdateLuxuryItemsValue();
            return;
        }
    }





    static void SellStock()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Deine Aktien zum Verkauf:");
        Console.ResetColor();

        for (int i = 0; i < stocks.Count; i++)
        {
            if (stocks[i].Menge > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i + 1}. {stocks[i].Name} - {stocks[i].Price:C2} | Menge {stocks[i].Menge}");
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("5. Hauptmenü");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Wähle eine Aktie zum Verkauf aus (1 - {0}): ", stocks.Count);
        string userInput = Console.ReadLine();

        if (userInput == "5")
        {
            Console.Clear(); // Lösche die Konsolenausgabe
            return; // Zurück zum Hauptmenü
        }

        int indexToSell;
        if (!int.TryParse(userInput, out indexToSell) || indexToSell < 1 || indexToSell > stocks.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ungültige Auswahl! Bitte geben Sie eine gültige Nummer ein");
            return;
        }

        indexToSell--;

        if (stocks[indexToSell].Menge <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Keine Aktien zum Verkauf!");
            return;
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Anzahl der zu verkaufenden {stocks[indexToSell].Name}-Aktien: ");
        userInput = Console.ReadLine();
        int quantityToSell;

        if (!int.TryParse(userInput, out quantityToSell) || quantityToSell <= 0 || quantityToSell > stocks[indexToSell].Menge)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ungültige Auswahl! Bitte geben Sie eine gültige Nummer ein!");
            return;
        }

        double totalEarnings = stocks[indexToSell].Price * quantityToSell;
        kapital += totalEarnings;
        stocks[indexToSell].Menge -= quantityToSell;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine($"Verkauft {quantityToSell} {stocks[indexToSell].Name}-Aktien für {totalEarnings:C2}");
        UpdateStockPrices();
    }





    static void LuxuryItemMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Verfügbare Option:");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[1] Immobilien");
        Console.WriteLine("[2] Wertgegenstände");
        Console.WriteLine("[3] Materialien");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("[4] Info");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[5] Hauptmenü");
        Console.ResetColor();


        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":
                Console.Clear();
                BuyLuxuryItemImmobilien();
                break;

            case "2":
                Console.Clear();
                BuyLuxuryItemWertgegenstände();
                break;

            case "3":
                Console.Clear();
                BuyLuxuryItemRessourcen();
                break;
            case "4":
                Console.Clear();
                Infos();
                break;
            case "5":
                Console.Clear();
                return;
            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige positive Zahl ein");
                break;

        }
    }

    static void BuyLuxuryItemImmobilien()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Immobillien:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Landwirtschaftliche Immobilie  - 30.000");
        Thread.Sleep(200);
        Console.WriteLine("2. Grundstück  - 60.000");
        Thread.Sleep(200);
        Console.WriteLine("3. Wohnimmobilie  - 150.000");
        Thread.Sleep(200);
        Console.WriteLine("4. Ferienimmobilie  - 300.000");
        Thread.Sleep(200);
        Console.WriteLine("5. Luxusimmobilie  - 3.000.000");
        Thread.Sleep(200);
        Console.WriteLine("5. Palast  - 12.000.000");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(200);
        Console.WriteLine("6. Zurück zum Hauptmenü");
        Console.ResetColor();

        string luxusGutEingabe = Console.ReadLine();
        switch (luxusGutEingabe)
        {
            case "1":
                if (AnzahldergüterImmobilie0 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Landwirtschaftliche Immobilie", 30000);
                    AnzahldergüterImmobilie0 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "2":
                if (AnzahldergüterImmobilie1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Grundstück", 60000);
                    AnzahldergüterImmobilie1 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "3":
                if (AnzahldergüterImmobilie2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Wohnimmobilie", 150000);
                    AnzahldergüterImmobilie2 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "4":
                if (AnzahldergüterImmobilie3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Ferienimmobilie", 300000);
                    AnzahldergüterImmobilie3 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }

            case "5":
                if (AnzahldergüterImmobilie4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Luxusimmobilie", 2000000);
                    AnzahldergüterImmobilie4 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }



                break;

            case "6":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zurück zum Hauptmenü");
                PrintStatus();
                break;


            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                BuyLuxuryItemImmobilien();
                break;
        }
    }
    static void BuyLuxuryItemWertgegenstände()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Wertgegenstände:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Bmw 320D  - 2.000");
        Thread.Sleep(200);
        Console.WriteLine("2. Mercedess S-Classe  - 15.000");
        Thread.Sleep(200);
        Console.WriteLine("3. Auti R8  - 55.000");
        Thread.Sleep(200);
        Console.WriteLine("4. Porsche 911  - 122.000");
        Thread.Sleep(200);
        Console.WriteLine("5. Lamborgini  - 240.000");
        Thread.Sleep(200);
        Console.WriteLine("6. Ferrari  - 450.000");
        Thread.Sleep(200);
        Console.WriteLine("7. Aston Marten  - 900.000");
        Thread.Sleep(200);
        Console.WriteLine("8. Königsegg  - 1.200.000");
        Thread.Sleep(200);
        Console.WriteLine("9. Bugatti  - 3.600.000");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(200);
        Console.WriteLine("11. Zurück zum Hauptmenü");
        Console.ResetColor();

        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":
                if (AnzahlderWertgegenstände0 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Bmw 320D", 2000);
                    AnzahlderWertgegenstände0 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }

            case "2":
                if (AnzahlderWertgegenstände1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Mercedess S-Classe", 15000);
                    AnzahlderWertgegenstände1 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "3":
                if (AnzahlderWertgegenstände2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Auti R8", 55000);
                    AnzahlderWertgegenstände2 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "4":
                if (AnzahlderWertgegenstände3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Porsche 911", 122000);
                    AnzahlderWertgegenstände3 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "5":
                if (AnzahlderWertgegenstände4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Lamborgini", 240000);
                    AnzahlderWertgegenstände4 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "6":
                if (AnzahlderWertgegenstände5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Ferrari", 450000);
                    AnzahlderWertgegenstände5 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "7":
                if (AnzahlderWertgegenstände6 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Aston Marten", 900000);
                    AnzahlderWertgegenstände6 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "8":
                if (AnzahlderWertgegenstände7 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Königsegg", 1200000);
                    AnzahlderWertgegenstände7 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }
            case "9":
                if (AnzahlderWertgegenstände8 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    BuyLuxuryItem("Bugatti", 3600000);
                    AnzahlderWertgegenstände8 = +1;
                    break;
                }
                else
                {
                    Fehlerausgabe();
                    Console.ResetColor();
                    break;
                }

            case "10":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zurück zum Hauptmenü");
                PrintStatus();
                break;


            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                BuyLuxuryItemImmobilien();
                break;


        }

    }




    static void BuyLuxuryItem(string itemName, double price)
    {
        if (kapital >= price)
        {
            kapital -= price;
            luxuryItems.Add(new LuxuryItem(itemName, price));
            Console.Clear();
            Console.WriteLine($"{itemName} gekauft für {price}");
            Thread.Sleep(1000);

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nicht genügend Kapital ");
            Thread.Sleep(1000);
        }
    }
    static void PrintLuxuryItemsStatus()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Deine Luxusgüter:");
        foreach (var luxuryItem in luxuryItems)
        {
            Console.WriteLine($"{luxuryItem.Name} - Wert: {luxuryItem.Price:C2}");
        }
        Console.ResetColor();
    }
    static void UpdateLuxuryItemsValue()
    {

        foreach (var luxuryItem in luxuryItems)
        {
            double valueChange = luxuryItem.Price * 0.08;
            luxuryItem.Price += valueChange;
            Thread.Sleep(300);
        }
    }
    static void SellLuxuryItemMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Verfügbare Optionen zum verkaufen");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[1] Immobilien");
        Console.WriteLine("[2] Wertgegenstände");
        Console.WriteLine("[3] Materialien");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[4] Zurück zum Hauptmenü");
        Console.ResetColor();

        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":
                Console.Clear();
                SellLuxuryItemImmobilien();
                break;

            case "2":
                Console.Clear();
                SellLuxuryItemWertgegenstände();
                break;

            case "3":
                Console.Clear();
                SellLuxuryItemRessourcen();
                break;

            case "4":
                Console.Clear();
                return;

            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                SellLuxuryItemMenu();
                break;
        }



    }



    static void SellLuxuryItem(string itemName, double initialPrice)
    {
        LuxuryItem luxuryItem = luxuryItems.Find(item => item.Name == itemName);

        if (luxuryItem != null)
        {
            Console.ForegroundColor = ConsoleColor.White;
            kapital += luxuryItem.Price;
            Console.Clear();
            Console.WriteLine($"{itemName} verkauft für {luxuryItem.Price:C2}");
            luxuryItems.Remove(luxuryItem);
            Thread.Sleep(200);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Du besitzt keine {itemName} !");
            Thread.Sleep(200);
        }
    }

    static void SellLuxuryItemImmobilien()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Immobillien zu verkaufen:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Landwirtschaftliche Immobilie ");
        Thread.Sleep(200);
        Console.WriteLine("2. Grundstück ");
        Thread.Sleep(200);
        Console.WriteLine("3. Wohnimmobilie  ");
        Thread.Sleep(200);
        Console.WriteLine("4. Ferienimmobilie  ");
        Thread.Sleep(200);
        Console.WriteLine("5. Luxusimmobilie  ");
        Thread.Sleep(200);
        Console.WriteLine("5. Palast ");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(200);
        Console.WriteLine("6. Zurück zum Hauptmenü");
        Console.ResetColor();

        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":
                SellLuxuryItem("Landwirtschaftliche Immobilie", 1);

                break;

            case "2":
                SellLuxuryItem("Grundstück", 1);

                break;

            case "3":
                SellLuxuryItem("Ferienimmobilie", 1);

                break;

            case "4":
                SellLuxuryItem("Luxusimmobilie", 1);
                break;
            case "5":
                SellLuxuryItem("Palast", 1);
                break;

            case "6":
                Console.Clear();
                Console.WriteLine("Zurück zum Hauptmenü");
                PrintStatus();
                break;

            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                SellLuxuryItemImmobilien();
                break;
        }
    }

    static void SellLuxuryItemWertgegenstände()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Wertgegenstände zu verkaufen:");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Bmw 320D ");
        Thread.Sleep(200);
        Console.WriteLine("2. Mercedess S-Classe ");
        Thread.Sleep(200);
        Console.WriteLine("3. Auti R8  ");
        Thread.Sleep(200);
        Console.WriteLine("4. Porsche 911  ");
        Thread.Sleep(200);
        Console.WriteLine("5. Lamborgini ");
        Thread.Sleep(200);
        Console.WriteLine("6. Ferrari  ");
        Thread.Sleep(200);
        Console.WriteLine("7. Aston Marten  ");
        Thread.Sleep(200);
        Console.WriteLine("8. Königsegg  ");
        Thread.Sleep(200);
        Console.WriteLine("9. Bugatti  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(200);
        Console.WriteLine("10. Zurück zum Hauptmenü");
        Console.ResetColor();

        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":
                SellLuxuryItem("Bmw 320D", 1);
                break;
            case "2":
                SellLuxuryItem("Mercedess S-Classe", 1);
                break;
            case "3":
                SellLuxuryItem("Audi R8", 1);
                break;
            case "4":
                SellLuxuryItem("Porsche 911", 1);
                break;
            case "5":
                SellLuxuryItem("Lamborgini", 1);
                break;
            case "6":
                SellLuxuryItem("Ferrari", 1);
                break;
            case "7":
                SellLuxuryItem("Aston Marten", 1);
                break;
            case "8":
                SellLuxuryItem("Königsegg", 1);
                break;
            case "9":
                SellLuxuryItem("Bugatti", 1);
                break;
            case "10":
                Console.Clear();
                Console.WriteLine("Zurück zum Hauptmenü");
                PrintStatus();
                break;

            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                SellLuxuryItemWertgegenstände();
                break;
        }


    }
    static void BuyLuxuryItemRessourcen()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Materialien zum kaufen:");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Cohle - 20 ");
        Thread.Sleep(200);
        Console.WriteLine("2. Eisen - 50");
        Thread.Sleep(200);
        Console.WriteLine("3. Gold - 800");
        Thread.Sleep(200);
        Console.WriteLine("4. Kupfer - 70");
        Thread.Sleep(200);
        Console.WriteLine("5. Zink - 40");
        Thread.Sleep(200);
        Console.WriteLine("6. Cobolt - 5000");
        Thread.Sleep(200);
        Console.WriteLine("7. Lizium  - 100");
        Thread.Sleep(200);
        Console.WriteLine("8. Diamanten - 6000");
        Thread.Sleep(200);
        Console.WriteLine("9. Rubine  - 3000");
        Thread.Sleep(200);
        Console.WriteLine("10. Emeralds - 2500 ");
        Thread.Sleep(200);
        Console.WriteLine("11.Saphier - 1000 ");
        Console.ResetColor();
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("12. Zurück zum Hauptmenü");
        Console.ResetColor();
        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":

                NachMengeFragenUndKaugen("Cohle", 20);
                break;
            case "2":
                NachMengeFragenUndKaugen("Eisen", 50);
                break;
            case "3":
                NachMengeFragenUndKaugen("Gold", 800);
                break;
            case "4":
                NachMengeFragenUndKaugen("Kupfer", 70);
                break;
            case "5":
                NachMengeFragenUndKaugen("Zink", 40);
                break;
            case "6":
                NachMengeFragenUndKaugen("Cobalt", 5000);
                break;
            case "7":
                NachMengeFragenUndKaugen("Lizium", 100);
                break;
            case "8":
                NachMengeFragenUndKaugen("Diamanten", 6000);
                break;
            case "9":
                NachMengeFragenUndKaugen("Rubine", 3000);
                break;
            case "10":
                NachMengeFragenUndKaugen("Emeralds", 2500);
                break;
            case "11":

                NachMengeFragenUndKaugen("Saphier", 1000);
                break;
            case "12":
                Console.Clear();
                Console.WriteLine("10. Zurück zum Hauptmenü");
                Console.ResetColor();
                break;
            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                BuyLuxuryItemRessourcen();
                break;

        }

    }
    static void SellLuxuryItemRessourcen()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Materialien zum kaufen:");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Cohle - 20 ");
        Thread.Sleep(200);
        Console.WriteLine("2. Eisen - 50");
        Thread.Sleep(200);
        Console.WriteLine("3. Gold - 800");
        Thread.Sleep(200);
        Console.WriteLine("4. Kupfer - 70");
        Thread.Sleep(200);
        Console.WriteLine("5. Zink - 40");
        Thread.Sleep(200);
        Console.WriteLine("6. Cobolt - 5000");
        Thread.Sleep(200);
        Console.WriteLine("7. Lizium  - 100");
        Thread.Sleep(200);
        Console.WriteLine("8. Diamanten - 6000");
        Thread.Sleep(200);
        Console.WriteLine("9. Rubine  - 3000");
        Thread.Sleep(200);
        Console.WriteLine("10. Emeralds - 2500 ");
        Thread.Sleep(200);
        Console.WriteLine("11.Saphier - 1000 ");
        Console.ResetColor();
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("12. Zurück zum Hauptmenü");
        Console.ResetColor();

        string eingabe = Console.ReadLine();
        switch (eingabe)
        {
            case "1":
                Console.Clear();
                SellLuxuryItem("Cohle", 1);
                break;
            case "2":
                Console.Clear();
                SellLuxuryItem("Eisen", 1);
                break;
            case "3":
                Console.Clear();
                SellLuxuryItem("Gold", 1);
                break;
            case "4":
                Console.Clear();
                SellLuxuryItem("Kupfer", 1);
                break;
            case "5":
                Console.Clear();
                SellLuxuryItem("Zink", 1);
                break;
            case "6":
                Console.Clear();
                SellLuxuryItem("Cobolt", 1);
                break;
            case "7":
                Console.Clear();
                SellLuxuryItem("Lizium", 1);
                break;
            case "8":
                Console.Clear();
                SellLuxuryItem("Diamanten", 1);
                break;
            case "9":
                Console.Clear();
                SellLuxuryItem("Rubine", 1);
                break;
            case "10":
                Console.Clear();
                SellLuxuryItem("Emeralds", 1);
                break;
            case "11":
                Console.Clear();
                SellLuxuryItem("Saphier", 1);
                break;

            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der verfügbaren Optionen.");
                BuyLuxuryItemRessourcen();
                break;
        }
    }
    static void NachMengeFragenUndKaugen(string itemName, double price)
    {
        Console.WriteLine("Gib die Menge der zu Kaufenden Materialien an: ");
        double Anzahl = double.Parse(Console.ReadLine());
        double totalPrice = Anzahl * price;

        if (kapital >= totalPrice)
        {
            kapital -= totalPrice;
            luxuryItems.Add(new LuxuryItem(itemName, totalPrice));
            Console.Clear();
            Console.WriteLine($"{Anzahl} {itemName} gekauft für insgesamt {totalPrice}");
            Thread.Sleep(1000);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nicht genügend Kapital ");
            Thread.Sleep(1000);
        }
    }



    static void UpdateStockPrices()
    {
        Random random = new Random();

        foreach (var stock in stocks)
        {
            double priceChange = (random.NextDouble() - 0.5) * 8;
            stock.Price += priceChange;
        }
    }

    static void Fehlerausgabe()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Du Kannst nicht 2 Luxusgüter  gleichzeitig besitzen");
        Console.ResetColor();
        Console.Clear();
    }
    static void Infos()
    {
        Console.WriteLine("Wertgegenstände´,Immobilien und Materialien steigen bekanntlich manchmal an Wert , mache es dir zu nutze und investiere in Wertgegenstände und verkaufe sie anschließlich für Profit");
    }

}


