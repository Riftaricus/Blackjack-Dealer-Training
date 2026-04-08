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

        int correctPercentage = 0;
        List<GameController.GameOrder> wrongSteps = new List<GameController.GameOrder>();

        public BlackJackMenu()
        {
            InitializeComponent();
        }

        private void update(int correctPercentage, List<GameController.GameOrder> wrongSteps)
        {
            this.correctPercentage = correctPercentage;
            this.wrongSteps = wrongSteps;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            playerCount = (int)playerCounting.Value;
            BlackJackGame gameForm = new BlackJackGame(playerCount - 1);
            gameForm.Show();
            this.Hide();
        }
    }
}
