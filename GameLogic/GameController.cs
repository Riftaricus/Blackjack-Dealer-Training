using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public static class GameController
    {
        public static Table? table;
        public static Dealer? dealer;

        //public static Dictionary<char, int> actions = new Dictionary<char, int>()
        //{
        //    {'S', 0},
        //    {'D', 0},
        //    {'A', 0},
        //    {'P', 0},
        //    {'A', 0}
        //};

        public static void initializeGame()
        {
            dealer = new Dealer();
            table = new Table();

        }
    }
}
