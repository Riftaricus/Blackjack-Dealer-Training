using System;
using System.Collections.Generic;
using System.Text;
using static Blackjack_Dealer_Training.GameLogic.Player;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Character
    {

        public int currentBet = 0;

        public int placeRandomBet()
        {
            return 0;
        }

        public String name { get; set; }

        public Hand hand;

        public Card Hit(bool face = true)
        {
            return hand.hit();
        }
        public void Stand()
        {
            hand.stand();
        }

        public PlayerAction getAction()
        {
            if (hand.getValue() < 17)
            {
                return PlayerAction.Hit;
            }
            else
            {
                return PlayerAction.Stand;
            }
        }
    }
}
