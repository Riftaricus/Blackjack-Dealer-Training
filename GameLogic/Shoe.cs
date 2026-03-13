using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Shoe
    {
        Deck deck;

        public Shoe()
        {
            deck = new Deck();
        }

        public void shuffleDeck()
        {
            deck.shuffle();
        }

        public Card drawCard()
        {
            return deck.draw();
        }
    }
}
