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

        public BlackJackMenu()
        {
            InitializeComponent();
        }

        private void playerCounting_ValueChanged(object sender, EventArgs e)
        {
            playerCount = (int)playerCounting.Value;
            if (playerCount > 0)
            {
                startButton.Enabled = true;
            }
            else
            {
                startButton.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            BlackJackGame gameForm = new BlackJackGame(playerCount - 1);
            gameForm.Show();
            this.Hide();
        }
    }
}
