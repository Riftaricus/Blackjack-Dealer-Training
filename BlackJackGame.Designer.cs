using Blackjack_Dealer_Training.GameLogic;

namespace Blackjack_Dealer_Training
{
    partial class BlackJackGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            int x = 0;
            int y = 200;

            buttons = new List<Button>();

            foreach (Player player in GameController.table.players)
            {
                Button button = new Button();
                button.Location = new Point(x, y);
                button.Name = player.name;
                button.Size = new Size(250, 30);
                button.TabIndex = 1;
                button.Text = "Deal Card To " + player.name;
                button.UseVisualStyleBackColor = true;

                x += 250;

                if (x > 500)
                {
                    x = 0;
                    y += 30;
                }

                buttons.Add(button);

                Controls.Add(button);
            }

            Actions = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            shuffleToolStripMenuItem = new ToolStripMenuItem();
            assignWinnersToolStripMenuItem = new ToolStripMenuItem();
            Actions.SuspendLayout();
            SuspendLayout();
            // 
            // Actions
            // 
            Actions.ImageScalingSize = new Size(20, 20);
            Actions.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            Actions.Location = new Point(0, 0);
            Actions.Name = "Actions";
            Actions.Size = new Size(800, 28);
            Actions.TabIndex = 0;
            Actions.Text = "menuStrip2";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shuffleToolStripMenuItem, assignWinnersToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(72, 24);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // shuffleToolStripMenuItem
            // 
            shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            shuffleToolStripMenuItem.Size = new Size(192, 26);
            shuffleToolStripMenuItem.Text = "Shuffle";
            shuffleToolStripMenuItem.Click += shuffleToolStripMenuItem_Click;
            // 
            // assignWinnersToolStripMenuItem
            // 
            assignWinnersToolStripMenuItem.Name = "assignWinnersToolStripMenuItem";
            assignWinnersToolStripMenuItem.Size = new Size(192, 26);
            assignWinnersToolStripMenuItem.Text = "Assign Winners";
            // 
            // BlackJackGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Actions);
            MainMenuStrip = Actions;
            Name = "BlackJackGame";
            Text = "BlackJackGame";
            Actions.ResumeLayout(false);
            Actions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private MenuStrip Actions;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem shuffleToolStripMenuItem;
        private ToolStripMenuItem assignWinnersToolStripMenuItem;
        private List<Button> buttons;
    }
}