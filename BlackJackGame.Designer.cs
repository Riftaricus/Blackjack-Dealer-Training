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
            components = new System.ComponentModel.Container();
            deal = new Button();
            actionAsk = new Label();
            right = new Button();
            left = new Button();
            menuStrip2 = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            shuffleToolStripMenuItem = new ToolStripMenuItem();
            gameToolStripMenuItem = new ToolStripMenuItem();
            endGameToolStripMenuItem = new ToolStripMenuItem();
            ask = new Button();
            player = new Label();
            cardsLeft = new Label();
            Card = new ImageList(components);
            imageList1 = new ImageList(components);
            DrawnCard = new PictureBox();
            checkBox1 = new CheckBox();
            statusStrip1 = new StatusStrip();
            didWrong = new ToolStripStatusLabel();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrawnCard).BeginInit();
            statusStrip1.SuspendLayout();
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
            // actionAsk
            // 
            actionAsk.AutoSize = true;
            actionAsk.Location = new Point(371, 199);
            actionAsk.Name = "actionAsk";
            actionAsk.Size = new Size(52, 20);
            actionAsk.TabIndex = 1;
            actionAsk.Text = "Action";
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
            menuStrip2.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem, gameToolStripMenuItem });
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
            shuffleToolStripMenuItem.Size = new Size(138, 26);
            shuffleToolStripMenuItem.Text = "Shuffle";
            shuffleToolStripMenuItem.Click += shuffleToolStripMenuItem_Click_1;
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { endGameToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(62, 24);
            gameToolStripMenuItem.Text = "Game";
            // 
            // endGameToolStripMenuItem
            // 
            endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            endGameToolStripMenuItem.Size = new Size(160, 26);
            endGameToolStripMenuItem.Text = "End Game";
            endGameToolStripMenuItem.Click += endGameToolStripMenuItem_Click;
            // 
            // ask
            // 
            ask.Location = new Point(349, 291);
            ask.Name = "ask";
            ask.Size = new Size(94, 29);
            ask.TabIndex = 5;
            ask.Text = "Ask Player";
            ask.UseVisualStyleBackColor = true;
            ask.Click += ask_Click;
            // 
            // player
            // 
            player.AutoSize = true;
            player.Location = new Point(365, 233);
            player.Name = "player";
            player.Size = new Size(58, 20);
            player.TabIndex = 6;
            player.Text = "PLAYER";
            player.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardsLeft
            // 
            cardsLeft.AutoSize = true;
            cardsLeft.Location = new Point(418, 38);
            cardsLeft.Name = "cardsLeft";
            cardsLeft.Size = new Size(25, 20);
            cardsLeft.TabIndex = 9;
            cardsLeft.Text = "52";
            // 
            // Card
            // 
            Card.ColorDepth = ColorDepth.Depth32Bit;
            Card.ImageSize = new Size(16, 16);
            Card.Tag = "";
            Card.TransparentColor = Color.Transparent;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // DrawnCard
            // 
            DrawnCard.Location = new Point(359, 109);
            DrawnCard.Name = "DrawnCard";
            DrawnCard.Size = new Size(75, 87);
            DrawnCard.SizeMode = PictureBoxSizeMode.Zoom;
            DrawnCard.TabIndex = 10;
            DrawnCard.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(349, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(97, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Has Won?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { didWrong });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // didWrong
            // 
            didWrong.Name = "didWrong";
            didWrong.Size = new Size(0, 18);
            didWrong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BlackJackGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(checkBox1);
            Controls.Add(DrawnCard);
            Controls.Add(cardsLeft);
            Controls.Add(player);
            Controls.Add(ask);
            Controls.Add(left);
            Controls.Add(right);
            Controls.Add(actionAsk);
            Controls.Add(deal);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "BlackJackGame";
            Text = "BlackJackGame";
            Load += BlackJackGame_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrawnCard).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private Button deal;
        private Label actionAsk;
        private Button right;
        private Button left;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem shuffleToolStripMenuItem;
        private Button ask;
        private Label player;
        private Label cardsLeft;
        private ImageList Card;
        private ImageList imageList1;
        private PictureBox DrawnCard;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem endGameToolStripMenuItem;
        private CheckBox checkBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel didWrong;
    }
}