using Blackjack_Dealer_Training.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blackjack_Dealer_Training
{
    public partial class BlackJackMenu : Form
    {
        int playerCount = 0;
        List<GameController.GameOrder> wrongSteps = new List<GameController.GameOrder>();

        public BlackJackMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameController.initializeGame();
            playerCount = (int)playerCounting.Value;
            BlackJackGame gameForm = new BlackJackGame(playerCount);
            gameForm.Show();
            this.Hide();
        }
    }
}
