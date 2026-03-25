using Blackjack_Dealer_Training.GameLogic;
using System.Numerics;
using static Blackjack_Dealer_Training.GameLogic.Player;


namespace Blackjack_Dealer_Training
{
    public partial class BlackJackGame : Form
    {
        Player selectedPlayer;
        int index = 0;

        public BlackJackGame(int playerCount)
        {


            for (int i = 0; i < playerCount; i++)
            {
                Player player = new Player();
                
                GameController.table.addPlayer(player);
            }
            InitializeComponent();

            selectedPlayer = GameController.table.players[0];

            update_label();

            foreach (Player player in GameController.table.players)
            {
                player.placeRandomBet();
            }

            update_label();


        }

        private void shuffleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.table.shuffleDeck();
        }

        private void deal_Click(object sender, EventArgs e)
        {
            GameController.dealer.dealCard(selectedPlayer);
            update_label();
        }

        private void left_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = GameController.table.players.Count - 1;
            }

            selectedPlayer = GameController.table.players[index];

            update_label();
        }

        private void right_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= GameController.table.players.Count)
            {
                index = 0;
            }

            selectedPlayer = GameController.table.players[index];

            update_label();
        }

        private void update_label()
        {
            int betAmount = 0;
            foreach (Player player in GameController.table.players)
            { betAmount += player.currentBet; }

            bet.Text = "Bet: " + betAmount + "$";
            cards.Text = selectedPlayer.hand.getCards();
            player.Text = selectedPlayer.name + " - " + selectedPlayer.hand.cards.Count + " cards (" + selectedPlayer.hand.getValue() + ")";
        }

        private void shuffleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GameController.table.shuffleDeck();
        }

        private void ask_Click(object sender, EventArgs e)
        {
            PlayerAction action = selectedPlayer.getAction();

            switch (action)
            {
                case PlayerAction.Hit:
                    actionAsk.Text = selectedPlayer.name + " wants to hit";
                    break;
                case PlayerAction.Stand:
                    actionAsk.Text = selectedPlayer.name + " wants to stand";
                    break;
            }
        }

        private void BlackJackGame_Load(object sender, EventArgs e)
        {

        }
    }
}
