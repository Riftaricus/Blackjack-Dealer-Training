namespace Blackjack_Dealer_Training
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem1 = new ToolStripMenuItem();
            testToolStripMenuItem2 = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            standToolStripMenuItem = new ToolStripMenuItem();
            hitToolStripMenuItem = new ToolStripMenuItem();
            dealerToolStripMenuItem = new ToolStripMenuItem();
            shuffleDeckToolStripMenuItem = new ToolStripMenuItem();
            dealCradsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, actionsToolStripMenuItem, dealerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 422);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testToolStripMenuItem1, testToolStripMenuItem2 });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(62, 24);
            testToolStripMenuItem.Text = "Game";
            testToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem1
            // 
            testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            testToolStripMenuItem1.Size = new Size(224, 26);
            testToolStripMenuItem1.Text = "Start Game";
            testToolStripMenuItem1.Click += testToolStripMenuItem1_Click;
            // 
            // testToolStripMenuItem2
            // 
            testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            testToolStripMenuItem2.Size = new Size(224, 26);
            testToolStripMenuItem2.Text = "Settings";
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standToolStripMenuItem, hitToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(72, 24);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // standToolStripMenuItem
            // 
            standToolStripMenuItem.Name = "standToolStripMenuItem";
            standToolStripMenuItem.Size = new Size(224, 26);
            standToolStripMenuItem.Text = "Stand";
            // 
            // hitToolStripMenuItem
            // 
            hitToolStripMenuItem.Name = "hitToolStripMenuItem";
            hitToolStripMenuItem.Size = new Size(224, 26);
            hitToolStripMenuItem.Text = "Hit";
            // 
            // dealerToolStripMenuItem
            // 
            dealerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shuffleDeckToolStripMenuItem, dealCradsToolStripMenuItem });
            dealerToolStripMenuItem.Name = "dealerToolStripMenuItem";
            dealerToolStripMenuItem.Size = new Size(67, 24);
            dealerToolStripMenuItem.Text = "Dealer";
            dealerToolStripMenuItem.Click += dealerToolStripMenuItem_Click;
            // 
            // shuffleDeckToolStripMenuItem
            // 
            shuffleDeckToolStripMenuItem.Name = "shuffleDeckToolStripMenuItem";
            shuffleDeckToolStripMenuItem.Size = new Size(175, 26);
            shuffleDeckToolStripMenuItem.Text = "Shuffle Deck";
            // 
            // dealCradsToolStripMenuItem
            // 
            dealCradsToolStripMenuItem.Name = "dealCradsToolStripMenuItem";
            dealCradsToolStripMenuItem.Size = new Size(175, 26);
            dealCradsToolStripMenuItem.Text = "Deal Cards";
            dealCradsToolStripMenuItem.Click += dealCradsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem1;
        private ToolStripMenuItem testToolStripMenuItem2;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem standToolStripMenuItem;
        private ToolStripMenuItem hitToolStripMenuItem;
        private ToolStripMenuItem dealerToolStripMenuItem;
        private ToolStripMenuItem dealCradsToolStripMenuItem;
        private ToolStripMenuItem shuffleDeckToolStripMenuItem;
    }
}
