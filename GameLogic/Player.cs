using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Player
    {
        public static Random rng = new Random();

        Hand hand;

        int money;

        public Player() { 
            hand = new Hand();
        }

        public Player(Hand hand)
        {
            this.hand = hand;
        }

    }
}
