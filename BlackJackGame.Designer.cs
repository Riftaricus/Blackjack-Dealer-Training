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
            deal = new Button();
            player = new Label();
            right = new Button();
            left = new Button();
            menuStrip2 = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            shuffleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // deal
            // 
            deal.Location = new Point(349, 256);
            deal.Name = "deal";
            deal.Size = new Size(94, 29);
            deal.TabIndex = 0;
            deal.Text = "Deal Card";
            deal.UseVisualStyleBackColor = true;
            deal.Click += deal_Click;
            // 
            // player
            // 
            player.AutoSize = true;
            player.Location = new Point(369, 233);
            player.Name = "player";
            player.Size = new Size(58, 20);
            player.TabIndex = 1;
            player.Text = "PLAYER";
            // 
            // right
            // 
            right.Location = new Point(433, 256);
            right.Name = "right";
            right.Size = new Size(34, 29);
            right.TabIndex = 2;
            right.Text = ">";
            right.UseVisualStyleBackColor = true;
            right.Click += right_Click;
            // 
            // left
            // 
            left.Location = new Point(321, 256);
            left.Name = "left";
            left.Size = new Size(34, 29);
            left.TabIndex = 3;
            left.Text = "<";
            left.UseVisualStyleBackColor = true;
            left.Click += left_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shuffleToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(72, 24);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // shuffleToolStripMenuItem
            // 
            shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            shuffleToolStripMenuItem.Size = new Size(224, 26);
            shuffleToolStripMenuItem.Text = "Shuffle";
            shuffleToolStripMenuItem.Click += shuffleToolStripMenuItem_Click_1;
            // 
            // BlackJackGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(left);
            Controls.Add(right);
            Controls.Add(player);
            Controls.Add(deal);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "BlackJackGame";
            Text = "BlackJackGame";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private List<Button> buttons;
        private Button deal;
        private Label player;
        private Button right;
        private Button left;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem shuffleToolStripMenuItem;
    }
}