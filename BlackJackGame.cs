using Blackjack_Dealer_Training.GameLogic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Numerics;
using static Blackjack_Dealer_Training.GameLogic.Player;
using static System.Net.Mime.MediaTypeNames;


namespace Blackjack_Dealer_Training
{
    public partial class BlackJackGame : Form
    {
        Character selectedPlayer;
        int index = 0;
        Card lastCard;

        public void notify(String action)
        {
            didWrong.Text = action + " (" + GameController.currentGameOrder + ")";
        }

        public BlackJackGame(int playerCount)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Player player = new Player();

                GameController.table.addPlayer(player);
            }

            GameController.table.addPlayer(GameController.dealer);

            InitializeComponent();

            selectedPlayer = GameController.table.players[0];

            update_label();

            foreach (Character player in GameController.table.players)
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
            if (selectedPlayer != GameController.dealer || GameController.checkActionPeacefully(GameController.GameOrder.HANDOUT))
            {

                if (GameController.checkActionPeacefully(GameController.GameOrder.PLAYERROUND))
                {
                    if (selectedPlayer.action == PlayerAction.Undecided)
                    {
                        notify("This player hasn't decided to hit or stand yet! Make sure to ask them.");
                        return;
                    }

                    else
                    {
                        if (selectedPlayer.action == PlayerAction.Hit)
                        {
                            selectedPlayer.action = PlayerAction.Undecided;
                            lastCard = GameController.dealer.dealCard(selectedPlayer);
                            update_label();
                        }
                        else
                        {
                            notify("This player has decided to stand! Please move on to the next player. " + GameController.currentGameOrder);
                            return;
                        }
                    }
                }
                else if (GameController.checkActionPeacefully(GameController.GameOrder.HANDOUT))
                {
                    if (selectedPlayer.hand.getRawCards().Count() >= 2)
                    {
                        notify("This player already has 2 cards! Make sure to give everyone 2 cards");
                        return;
                    }
                    lastCard = GameController.dealer.dealCard(selectedPlayer);
                    update_label();

                    bool allPlayersHaveTwoCards = true;

                    foreach (Character player in GameController.table.players)
                    {
                        if (player.hand.getRawCards().Count() < 2)
                        {
                            allPlayersHaveTwoCards = false;
                        }
                    }
                    if (allPlayersHaveTwoCards)
                    {
                        GameController.switchGameOrder();
                    }
                }
                else
                {
                    notify("You can't deal right now! You may be missing a step.");
                }
            }
            else if (GameController.checkActionPeacefully(GameController.GameOrder.DEALERROUND) || GameController.checkActionPeacefully(GameController.GameOrder.CHECK))
            {
                if (selectedPlayer.hand.getValue() >= 17 && GameController.checkActionPeacefully(GameController.GameOrder.DEALERROUND)){
                    GameController.switchGameOrder();
                }

                if (selectedPlayer.hand.getValue() < 17)
                {
                    lastCard = GameController.dealer.dealCard(selectedPlayer);
                    if (selectedPlayer.hand.getValue() >= 17)
                    {
                        GameController.switchGameOrder();
                    }
                    update_label();
                }
                else
                {
                    notify("The dealer has 17 or more, they have to stand! Please assign winners the game.");
                }
            }
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
            foreach (Character player in GameController.table.players)
            { betAmount += player.currentBet; }

            cardsLeft.Text = "| " + GameController.table.deck.cardsLeft + " Cards left";
            player.Text = selectedPlayer.name + " - " + selectedPlayer.hand.cards.Count + " cards (" + selectedPlayer.hand.getValue() + ")";

            string imagePath = lastCard != null
    ? Path.Combine(System.Windows.Forms.Application.StartupPath, "images", lastCard.ToIntString().ToLower().Replace(" ", "_") + ".png")
    : "";

            checkBox1.Checked = selectedPlayer.hasWon;

            DrawnCard.ImageLocation = imagePath;

            if (selectedPlayer == GameController.dealer)
            {
                checkBox1.Visible = false;
                actionAsk.Visible = false;
                ask.Visible = false;
            }
            else
            {
                checkBox1.Visible = true;
                actionAsk.Visible = true;
                ask.Visible = true;
            }
        }

        private void shuffleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (GameController.checkAction(GameController.GameOrder.SETUP))
            {
                GameController.table.shuffleDeck();
            }
            else
            {
                notify("You can't shuffle the deck right now!");
            }


        }

        private void ask_Click(object sender, EventArgs e)
        {
            if (selectedPlayer.action != PlayerAction.Undecided)
            {
                notify("You've already asked them for their action!");
                return;
            }

            if (GameController.checkActionPeacefully(GameController.GameOrder.PLAYERROUND))
            {
                if (selectedPlayer == GameController.dealer)
                {
                    notify("You can't ask this player what they want to do right now!");
                    return;
                }
            }
            if (GameController.checkActionPeacefully(GameController.GameOrder.DEALERROUND))
            {
                if (selectedPlayer != GameController.dealer)
                {
                    notify("You can't ask this player what they want to do right now!");
                    return;
                }
            }

            PlayerAction action = selectedPlayer.getAction();

            selectedPlayer.action = action;

            switch (action)
            {
                case PlayerAction.Hit:
                    actionAsk.Text = selectedPlayer.name + " wants to hit";
                    break;
                case PlayerAction.Stand:
                    actionAsk.Text = selectedPlayer.name + " wants to stand";
                    break;
            }

            if (GameController.currentGameOrder == GameController.GameOrder.PLAYERROUND)
            {

                bool allPlayersHavePassed = true;

                foreach (Character player in GameController.table.players)
                {
                    if (player.action != PlayerAction.Stand && player != GameController.dealer)
                    {
                        allPlayersHavePassed = false;
                    }
                }
                if (allPlayersHavePassed)
                {
                    GameController.switchGameOrder();
                }
            }
        }

        private void BlackJackGame_Load(object sender, EventArgs e)
        {

        }

        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Character player in GameController.table.players)
            {
                if (player.hasWon != player.hasActuallyWon)
                {
                    notify("That's not quite right! " + player.name +  " is incorrectly given a win/loss");
                    return;
                }
            }

            GameController.table.players.Clear();

            GameController.dealer.hand.cards.Clear();

            GameController.dealer.Reset();

            GameController.table.stopGame();

            this.Hide();
            BlackJackMenu blackJackMenu = new BlackJackMenu();
            blackJackMenu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            selectedPlayer.hasWon = checkBox1.Checked;

            selectedPlayer.hasActuallyWon = selectedPlayer.checkWin();
        }
    }
}
