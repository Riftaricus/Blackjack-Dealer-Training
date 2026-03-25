using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Hand
    {
        bool canPlay;
        int value;

        public List<Card> cards { get; set; }
        bool hasPassed;

        public Hand()
        {
            canPlay = true;
            value = 0;
            cards = new List<Card>();
            hasPassed = false;
        }

        public int getValue()
        {
            int value = 0;
            int aceAmount = 0;

            foreach (Card card in cards)
            {
                value += card.value;
                if (value == 11)
                {
                    aceAmount++;
                }
            }
            while (value > 21 && aceAmount > 0)
            {
                value -= 10;
                aceAmount--;
            }

            return value;
        }

        public void addCard(Card card)
        {
            cards.Add(card);
        }

        public void hit()
        {
            Card? drawnCard = GameController.table?.deck.draw();

            if (drawnCard != null)
            {
                addCard(drawnCard);
            } 
        }

        public string getCards()
        {
            string formattedCards = "";

            foreach (Card card in cards)
            {
                formattedCards += $"{card.rank} of {card.suit}, ";
            }

            return formattedCards;
        }

        public void stand()
        {
            hasPassed = true;
        }

    }
}
