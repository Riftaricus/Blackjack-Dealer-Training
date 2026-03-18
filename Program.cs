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
<<<<<<< Updated upstream
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
=======


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

>>>>>>> Stashed changes
            ApplicationConfiguration.Initialize();
            Application.Run(new BlackJackMenu());
        }
    }
}