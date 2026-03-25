using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public static class GameController
    {
        public static Table? table;
        public static Dealer? dealer;
        public static GameOrder currentGameOrder = GameOrder.Inactive;

        public enum GameOrder
        {
            Shuffle,
            DealingCards,
            PlayerTurns,
            DealerTurn,
            RoundOver,
            Inactive
        }

        public static void switchGameOrder()
        {
            int gameOrder = (int)currentGameOrder + 1;

            if (gameOrder > 5)
            {
                gameOrder = 0;
            }

            currentGameOrder = (GameOrder)gameOrder;
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
