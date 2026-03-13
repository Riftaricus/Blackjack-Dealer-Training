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

        public void hit()
        {
            
        }


    }
}
