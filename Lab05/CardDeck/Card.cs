using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Card
    {
        private string rank;
        private string suit;
        
        public string Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }     
        }

        public string Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }

        public Card()
        {

        }

        public Card(string rank, string suit)
        {
            switch (rank.ToUpper())
            {
                case "2":
                    this.rank = "Two";
                    break;
                case "3":
                    this.rank = "Three";
                    break;
                case "4":
                    this.rank = "Four";
                    break;
                case "5":
                    this.rank = "Five";
                    break;
                case "6":
                    this.rank = "Six";
                    break;
                case "7":
                    this.rank = "Seven";
                    break;
                case "8":
                    this.rank = "Eight";
                    break;
                case "9":
                    this.rank = "Nine";
                    break;
                case "10":
                    this.rank = "Ten";
                    break;
                case "J":
                    this.rank = "Jack";
                    break;
                case "Q":
                    this.rank = "King";
                    break;
                case "K":
                    this.rank = "Queen";
                    break;
                case "A":
                    this.rank = "Ace";
                    break;
                default:
                    this.rank = "Unknown";
                    break;
            }

            switch (suit.ToUpper())
            {
                case "S":
                    this.suit = "♠️";
                    break;
                case "H":
                    this.suit = "♥️";
                    break;
                case "D":
                    this.suit = "♦️";
                    break;
                case "C":
                    this.suit = "♣️";
                    break;
                default:
                    this.suit = "Unknown";
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("Your card is the {0} of {1}",rank ,suit);
        }
    }
}
