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

            ApplicationConfiguration.Initialize();
            Application.Run(new BlackJackMenu());
        }
    }
}