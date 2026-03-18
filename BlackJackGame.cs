using Blackjack_Dealer_Training.GameLogic;
using System.Numerics;


namespace Blackjack_Dealer_Training
{
    public partial class BlackJackGame : Form
    {
        public BlackJackGame(int playerCount)
        {


            for (int i = 0; i < playerCount; i++)
            {
                Player player = new Player();

                GameController.table.addPlayer(player);
            }

            InitializeComponent();
        }

        private void shuffleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.table.shuffleDeck();
        }

    }
}
