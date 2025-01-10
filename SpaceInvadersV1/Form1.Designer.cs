﻿namespace SpaceInvadersV1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player = new PictureBox();
            panel1 = new Panel();
            killsTxt = new Label();
            scoreTxt = new Label();
            pictureBox1 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            labelLivello = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Black;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(579, 663);
            player.Margin = new Padding(3, 4, 3, 4);
            player.Name = "player";
            player.Size = new Size(101, 115);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(killsTxt);
            panel1.Controls.Add(scoreTxt);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 56);
            panel1.TabIndex = 1;
            // 
            // killsTxt
            // 
            killsTxt.AutoSize = true;
            killsTxt.BackColor = Color.Black;
            killsTxt.Font = new Font("Impact", 14.25F);
            killsTxt.ForeColor = Color.White;
            killsTxt.Location = new Point(1149, 12);
            killsTxt.Name = "killsTxt";
            killsTxt.Size = new Size(64, 29);
            killsTxt.TabIndex = 2;
            killsTxt.Text = "Kills: ";
            // 
            // scoreTxt
            // 
            scoreTxt.AutoSize = true;
            scoreTxt.BackColor = Color.Black;
            scoreTxt.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreTxt.ForeColor = Color.White;
            scoreTxt.Location = new Point(12, 12);
            scoreTxt.Name = "scoreTxt";
            scoreTxt.Size = new Size(92, 29);
            scoreTxt.TabIndex = 1;
            scoreTxt.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1256, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // labelLivello
            // 
            labelLivello.AutoSize = true;
            labelLivello.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLivello.ForeColor = Color.Lime;
            labelLivello.Location = new Point(12, 765);
            labelLivello.Name = "labelLivello";
            labelLivello.Size = new Size(199, 75);
            labelLivello.TabIndex = 4;
            labelLivello.Text = "LEVEL 1";
            labelLivello.Click += labelLivello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 853);
            Controls.Add(labelLivello);
            Controls.Add(panel1);
            Controls.Add(player);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyDown;
            KeyUp += keyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label scoreTxt;
        private Label killsTxt;
        private System.Windows.Forms.Timer gameTimer;
        private Label labelLivello;
    }
}
