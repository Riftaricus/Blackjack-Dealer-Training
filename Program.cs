using Blackjack_Dealer_Training.GameLogic;

namespace Blackjack_Dealer_Training
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            GameController.initializeGame();
            Table table = GameController.table;

            table.addPlayer(new Player());
            table.addPlayer(new Player());
            table.addPlayer(new Player());
            table.addPlayer(new Player());

            table.startGame();

            table.shuffleDeck();

            GameController.dealer?.InitialDeal();

            GameController.initializeGame();
            Table table = GameController.table;

            table.addPlayer(new Player());
            table.addPlayer(new Player());
            table.addPlayer(new Player());
            table.addPlayer(new Player());

            table.startGame();

            table.shuffleDeck();

            GameController.dealer?.InitialDeal();

            GameController.initializeGame();

            GameController.table?.addPlayer(new Player());

            ApplicationConfiguration.Initialize();
            Application.Run(new BlackJackMenu());
        }
    }
}