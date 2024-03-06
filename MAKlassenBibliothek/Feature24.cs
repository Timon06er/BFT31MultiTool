namespace MAKlassenBibliothek;

internal class Feature24
{
    internal static void Feature_24()
    {
        Console.WriteLine("Test Feature 24"); 
       using System;
using System.Collections.Generic;
using System.Threading;

double stattkapital = 0;

Console.WriteLine("Welcome to Casino Halal");
Thread.Sleep(2000);
Console.WriteLine("Enter your initial capital: ");
stattkapital = Convert.ToDouble(Console.ReadLine());

do
{
    Console.Clear();
    Console.SetCursorPosition(Console.WindowWidth - stattkapital.ToString().Length - 14, 0);
    Console.Write($"Staatkapital: {stattkapital}");
    Console.WriteLine();
    Console.WriteLine("Choose a game:");
    Console.WriteLine("1. Roulette");
    Console.WriteLine("2. Blackjack");
    Console.WriteLine("3. Exit");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You selected Roulette");
            Console.WriteLine("Enter your bet: ");
            double bet1 = GetUserBet(stattkapital);
            RouletteGame(ref stattkapital, bet1);
            break;

        case "2":
            Console.WriteLine("You selected Blackjack");
            Console.WriteLine("Enter your bet: ");
            double bet2 = GetUserBet(stattkapital);
            BlackjackGame(ref stattkapital, bet2);
            break;

        case "3":
            Console.WriteLine("Exiting the program. Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine();

} while (true);

double GetUserBet(double stattkapital)
{
    double bet;
    do
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth - stattkapital.ToString().Length - 14, 0);
        Console.Write($"Staatkapital: {stattkapital}");

        Console.WriteLine($"Your current capital is {stattkapital}. Enter your bet: ");

        if (!double.TryParse(Console.ReadLine(), out bet))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            continue;
        }

        if (bet > stattkapital)
        {
            Console.WriteLine("Invalid bet. Bet cannot be greater than your capital.");
        }
        else if (bet <= 0)
        {
            Console.WriteLine("Invalid bet. Bet must be greater than zero.");
        }

    } while (bet > stattkapital || bet <= 0);

    return bet;
}

void RouletteGame(ref double stattkapital, double bet)
{
    bool exitRoulette = false;

    do
    {
        Console.Clear();
        Console.SetCursorPosition(Console.WindowWidth - stattkapital.ToString().Length - 14, 0);
        Console.Write($"Staatkapital: {stattkapital}");
        Console.WriteLine("Welcome to Roulette");
        Random rastgele = new Random();
        int randomzahl = rastgele.Next(1, 36);

        Console.WriteLine("Bet Range Menu:");
        Console.WriteLine("1. 1-12");
        Console.WriteLine("2. 13-24");
        Console.WriteLine("3. 25-36");
        Console.WriteLine("0. Back to Game Menu");

        Console.Write("Enter your choice: ");

        if (int.TryParse(Console.ReadLine(), out int betRangeChoice))
        {
            switch (betRangeChoice)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Bet accepted.");
                    Thread.Sleep(2000);
                    break;

                case 0:
                    Console.WriteLine("Returning to Game Menu");
                    exitRoulette = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            continue;
        }

        if (exitRoulette)
            break;

        int schritte = 4;
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(0, 37);
        int count = 0;

        for (int i = random; count <= schritte; i++)
        {
            count++;
            if (i > 36)
            {
                i = 1;
            }

            int time = 10 * count;

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Roulettezahl: {i}");

            Thread.Sleep(2000);
        }

        if ((betRangeChoice == 1 && randomzahl <= 12) ||
            (betRangeChoice == 2 && randomzahl > 12 && randomzahl <= 24) ||
            (betRangeChoice == 3 && randomzahl >= 25 && randomzahl <= 36))
        {
            Console.WriteLine("\n\nWin");
            stattkapital += bet * 3;
        }
        else
        {
            Console.WriteLine("\n\nLose");
            stattkapital -= bet;
        }

        Console.SetCursorPosition(Console.WindowWidth - stattkapital.ToString().Length - 14, 0);
        Console.Write($"Staatkapital: {stattkapital}");

    } while (!exitRoulette);
}

void BlackjackGame(ref double stattkapital, double bet)
{
    Console.WriteLine("Welcome to Blackjack!");

    while (true)
    {
        PlayBlackjack(ref stattkapital, bet);

        Console.Write("Do you want to play again? (Y/N): ");
        string answer = Console.ReadLine().ToUpper();
        if (answer != "Y")
            break;
    }

    Console.WriteLine("Thanks for playing!");
}

void PlayBlackjack(ref double stattkapital, double bet)
{
    Deck deck = new Deck();
    deck.Shuffle();

    List<Card> playerHand = new List<Card>();
    List<Card> dealerHand = new List<Card>();

    playerHand.Add(deck.DrawCard());
    dealerHand.Add(deck.DrawCard());
    playerHand.Add(deck.DrawCard());
    dealerHand.Add(deck.DrawCard());

    Console.WriteLine($"Your hand: {CardListToString(playerHand)}");
    Console.WriteLine($"Dealer's hand: {dealerHand[1]} and an unknown card.");

    PlayerTurn(deck, playerHand);
    DealerTurn(deck, dealerHand);

    DetermineWinner(playerHand, dealerHand, ref stattkapital, bet);
}

void PlayerTurn(Deck deck, List<Card> hand)
{
    while (GetHandValue(hand) < 21)
    {
        Console.Write("Willst du nehmen oder bleiben? (H/S): ");
        string choice = Console.ReadLine().ToUpper();

        if (choice == "H")
        {
            hand.Add(deck.DrawCard());
            Console.WriteLine($"Your hand: {CardListToString(hand)}");

            if (GetHandValue(hand) >= 21)
                break;
        }
        else if (choice == "S")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter H or S.");
        }
    }
}

void DealerTurn(Deck deck, List<Card> hand)
{
    Console.WriteLine($"Dealer's hand: {CardListToString(hand)}");

    while (GetHandValue(hand) < 17)
    {
        hand.Add(deck.DrawCard());
        Console.WriteLine($"Dealer hits: {hand[hand.Count - 1]}");
        Console.WriteLine($"Dealer's hand: {CardListToString(hand)}");
    }
}

void DetermineWinner(List<Card> playerHand, List<Card> dealerHand, ref double stattkapital, double bet)
{
    int playerValue = GetHandValue(playerHand);
    int dealerValue = GetHandValue(dealerHand);

    Console.WriteLine($"Your hand: {CardListToString(playerHand)} ({playerValue})");
    Console.WriteLine($"Dealer's hand: {CardListToString(dealerHand)} ({dealerValue})");

    if (playerValue > 21 || (dealerValue <= 21 && dealerValue >= playerValue))
    {
        Console.WriteLine("Dealer wins!");
        stattkapital -= bet;
    }
    else
    {
        Console.WriteLine("You win!");
        stattkapital += bet;
    }


    Console.Write($"Staatkapital: {stattkapital}");
}

int GetHandValue(List<Card> hand)
{
    int value = 0;
    int numberOfAces = 0;

    foreach (Card card in hand)
    {
        value += card.GetValue();
        if (card.Rank == Rank.Ace)
        {
            numberOfAces++;
        }
    }

    while (numberOfAces > 0 && value > 21)
    {
        value -= 10;
        numberOfAces--;
    }

    return value;
}

string CardListToString(List<Card> hand)
{
    List<string> cardStrings = new List<string>();
    foreach (Card card in hand)
    {
        cardStrings.Add(card.ToString());
    }
    return string.Join(", ", cardStrings);
}

enum Suit
{
    Herz,
    Karo,
    Pik,
    Kreuz,
}

enum Rank
{
    Zwei = 2,
    Drei,
    Vier,
    Fünf,
    Sechs,
    Sieben,
    Acht,
    Neun,
    Zehn,
    Jack,
    Queen,
    King,
    Ace
}

class Card
{
    public Suit Suit { get; set; }
    public Rank Rank { get; set; }

    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public int GetValue()
    {
        if (Rank == Rank.Ace)
        {
            return 11;
        }
        else if (Rank >= Rank.Zehn)
        {
            return 10;
        }
        else
        {
            return (int)Rank;
        }
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}

class Deck
{
    private List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        Random random = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public Card DrawCard()
    {
        Card drawnCard = cards[0];
        cards.RemoveAt(0);
        return drawnCard;
    }
}
