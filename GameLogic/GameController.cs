using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public static class GameController
    {
        public static Table? table;

        public static void initializeGame()
        {
            table = new Table();
        }
    }
}
