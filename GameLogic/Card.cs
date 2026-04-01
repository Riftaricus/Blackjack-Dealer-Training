using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public enum Rank
    {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
    }

    public enum Suit
    {
        HEARTS,
        CLUBS,
        DIAMONDS,
        SPADES,
    }

    public class Card
    {
        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public Suit suit { get; }
        public Rank rank { get; }

        public int value
        {
            get
            {
                return rank switch
                {
                    Rank.ACE => 11,
                    Rank.JACK or Rank.QUEEN or Rank.KING => 10,
                    _ => (int)rank
                };
            }
        }

        private bool faceUp { get; set; }

        public void flip()
        {
            faceUp = !faceUp;
        }

        private String getNumberFromString(Enum rank)
        {
            switch (rank)
            {
                case Rank.TWO:
                    return "2";
                    break;
                case Rank.THREE:
                    return "3";
                    break;
                case Rank.FOUR:
                    return "4";
                    break;
                case Rank.FIVE:
                    return "5";
                    break;
                case Rank.SIX:
                    return "6";
                    break;
                case Rank.SEVEN:
                    return "7";
                    break;
                case Rank.EIGHT:
                    return "8";
                    break;
                case Rank.NINE:
                    return "9";
                    break;

            }

            return rank.ToString();
        }


        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
        public string ToIntString()
        {
            return $"{getNumberFromString(rank)} of {suit}";
        }
    }
}
