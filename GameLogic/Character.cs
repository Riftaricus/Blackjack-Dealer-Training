using System;
using System.Collections.Generic;
using System.Text;
using static Blackjack_Dealer_Training.GameLogic.Player;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Character
    {
        public PlayerAction action = PlayerAction.Undecided;

        public int currentBet = 0;

        public bool hasWon = false;
        public bool hasActuallyWon = false;

        public bool checkWin()
        {
            if (hand.getValue() > GameController.dealer.hand.getValue())
            {
                return true;
            } else if (hasBlackjack() && !GameController.dealer.hasBlackjack())
            {
                return true;
            }
            return false;
        }

        public bool hasBlackjack()
        {
            if (hand.getValue() == 21 && hand.getCards().Length == 2)
            {
                return true;
            }
            return false;
        }

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

        public virtual PlayerAction getAction()
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
