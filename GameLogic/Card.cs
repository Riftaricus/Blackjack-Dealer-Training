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

        private Suit suit { get; }
        private Rank rank { get; }

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


        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }
}
