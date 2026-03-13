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

        List<Card> cards { get; set; }
        bool hasPassed;

        public Hand()
        {
            canPlay = true;
            value = 0;
            cards = new List<Card>();
            hasPassed = false;
        }

        public void getValue()
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

        public void stand()
        {
            hasPassed = true;
        }

    }
}
