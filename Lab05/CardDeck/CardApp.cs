using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your card rank (e.g. A for Ace): ");
            string rank = Console.ReadLine();
            Console.Write("Enter your card suit (e.g. S for Spades: ");
            string suit = Console.ReadLine();
            Card yourCard = new Card(rank, suit);
            Console.WriteLine(yourCard.ToString());
        }
    }
}
