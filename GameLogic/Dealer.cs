using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Dealer
    {
        Hand hand = new Hand();

        public void Hit(bool face = true)
        {
            hand.hit();
        }
        public void Stand()
        {
            hand.stand();
        }

        public void dealCard(Player player)
        {
            player.hit();
        }

        public void InitialDeal()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (Player player in GameController.table.players)
                    player.hit();
            }

            Hit();
            Hit(true);
        }

        public void Reset()
        {
            GameController.table.stopGame();
        }
    }
}
