using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public static class GameController
    {
        public static Table? table;
        public static Dealer? dealer;
        public static GameOrder currentGameOrder = GameOrder.INACTIVE;

        public static List<GameOrder> correctGameOrder =
            new List<GameOrder>() { GameOrder.SETUP, GameOrder.START, GameOrder.ROUND };
        public enum GameOrder
        {
            INACTIVE,
            SETUP,
            START,
            ROUND,

        }

        public static void switchGameOrder()
        {
            int gameOrder = correctGameOrder.IndexOf(currentGameOrder) + 1;

            if (gameOrder > correctGameOrder.Count)
            {
                gameOrder = 0;
            }

            currentGameOrder = correctGameOrder[gameOrder];
        }

        public static bool checkAction(GameOrder gameOrder)
        {
            if (currentGameOrder == gameOrder)
            {
                switchGameOrder();
                return true;
            }
            return false;
        }

        public static void initializeGame()
        {
            dealer = new Dealer();
            table = new Table();
        }
    }
}
