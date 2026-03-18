namespace Blackjack_Dealer_Training
{
    partial class BlackJackMenu
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
            title = new Label();
            playerCounting = new NumericUpDown();
            playerAmount = new Label();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playerCounting).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.FlatStyle = FlatStyle.Popup;
            title.Font = new Font("Segoe UI", 18F);
            title.ForeColor = SystemColors.ActiveCaptionText;
            title.Location = new Point(185, 40);
            title.Name = "title";
            title.Size = new Size(432, 41);
            title.TabIndex = 0;
            title.Text = "Blackjack Dealer Training (BJDT)";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // playerCounting
            // 
            playerCounting.Location = new Point(376, 195);
            playerCounting.Name = "playerCounting";
            playerCounting.Size = new Size(55, 27);
            playerCounting.TabIndex = 1;
            playerCounting.ValueChanged += playerCounting_ValueChanged;
            // 
            // playerAmount
            // 
            playerAmount.AutoSize = true;
            playerAmount.Location = new Point(376, 172);
            playerAmount.Name = "playerAmount";
            playerAmount.Size = new Size(55, 20);
            playerAmount.TabIndex = 2;
            playerAmount.Text = "Players";
            // 
            // startButton
            // 
            startButton.Enabled = false;
            startButton.Location = new Point(355, 228);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 3;
            startButton.Text = "Start Game";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // BlackJackMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(startButton);
            Controls.Add(playerAmount);
            Controls.Add(playerCounting);
            Controls.Add(title);
            Name = "BlackJackMenu";
            Text = "BlackJackMenu";
            ((System.ComponentModel.ISupportInitialize)playerCounting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private NumericUpDown playerCounting;
        private Label playerAmount;
        private Button startButton;
    }
}