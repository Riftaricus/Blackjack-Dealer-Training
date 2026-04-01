using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Dealer : Character
    {
        public Dealer()
        {
            name = "Dealer";
            hand = new Hand();
        }

        public Card dealCard(Character character)
        {
            return character.Hit(false);
        }

        public void Reset()
        {
            GameController.table.stopGame();
        }
    }
}
