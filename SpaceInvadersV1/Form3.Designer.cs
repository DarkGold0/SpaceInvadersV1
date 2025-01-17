﻿namespace SpaceInvadersV1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            killsTxt = new Label();
            scoreTxt = new Label();
            pictureBox1 = new PictureBox();
            labelLivello = new Label();
            player = new PictureBox();
            continueTxt = new Label();
            winTxt = new Label();
            retryTxt = new Label();
            gameOverTxt = new Label();
            thanksTxt = new Label();
            totalScoreTxt = new Label();
            outScoreTxt = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
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
            panel1.TabIndex = 3;
            // 
            // killsTxt
            // 
            killsTxt.AutoSize = true;
            killsTxt.BackColor = Color.Black;
            killsTxt.Font = new Font("Impact", 14.25F);
            killsTxt.ForeColor = Color.White;
            killsTxt.Location = new Point(1149, 12);
            killsTxt.Name = "killsTxt";
            killsTxt.Size = new Size(51, 23);
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
            scoreTxt.Size = new Size(73, 23);
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
            // labelLivello
            // 
            labelLivello.AutoSize = true;
            labelLivello.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLivello.ForeColor = Color.Red;
            labelLivello.Location = new Point(12, 765);
            labelLivello.Name = "labelLivello";
            labelLivello.Size = new Size(165, 60);
            labelLivello.TabIndex = 7;
            labelLivello.Text = "LEVEL 3";
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(579, 712);
            player.Margin = new Padding(3, 4, 3, 4);
            player.Name = "player";
            player.Size = new Size(101, 115);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 8;
            player.TabStop = false;
            // 
            // continueTxt
            // 
            continueTxt.AutoSize = true;
            continueTxt.BackColor = Color.Transparent;
            continueTxt.Font = new Font("Impact", 25.8000011F);
            continueTxt.ForeColor = Color.Lime;
            continueTxt.Location = new Point(388, 391);
            continueTxt.Name = "continueTxt";
            continueTxt.Size = new Size(437, 43);
            continueTxt.TabIndex = 14;
            continueTxt.Text = "Press enter to open the menu";
            continueTxt.Visible = false;
            // 
            // winTxt
            // 
            winTxt.AutoSize = true;
            winTxt.BackColor = Color.Transparent;
            winTxt.Font = new Font("Impact", 55F);
            winTxt.ForeColor = Color.Lime;
            winTxt.Location = new Point(156, 267);
            winTxt.Name = "winTxt";
            winTxt.Size = new Size(989, 91);
            winTxt.TabIndex = 13;
            winTxt.Text = "YOU HAVE COMPLEATED THE GAME";
            winTxt.Visible = false;
            // 
            // retryTxt
            // 
            retryTxt.AutoSize = true;
            retryTxt.BackColor = Color.Transparent;
            retryTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retryTxt.ForeColor = Color.Red;
            retryTxt.Location = new Point(456, 391);
            retryTxt.Name = "retryTxt";
            retryTxt.Size = new Size(297, 43);
            retryTxt.TabIndex = 12;
            retryTxt.Text = "Press enter to retry";
            retryTxt.Visible = false;
            // 
            // gameOverTxt
            // 
            gameOverTxt.AutoSize = true;
            gameOverTxt.BackColor = Color.Transparent;
            gameOverTxt.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameOverTxt.ForeColor = Color.Red;
            gameOverTxt.Location = new Point(344, 246);
            gameOverTxt.Name = "gameOverTxt";
            gameOverTxt.Size = new Size(472, 117);
            gameOverTxt.TabIndex = 11;
            gameOverTxt.Text = "GAME OVER";
            gameOverTxt.Visible = false;
            // 
            // thanksTxt
            // 
            thanksTxt.AutoSize = true;
            thanksTxt.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thanksTxt.ForeColor = SystemColors.ControlLightLight;
            thanksTxt.Location = new Point(516, 77);
            thanksTxt.Name = "thanksTxt";
            thanksTxt.Size = new Size(206, 27);
            thanksTxt.TabIndex = 15;
            thanksTxt.Text = "Thanks for playing <3";
            thanksTxt.Visible = false;
            // 
            // totalScoreTxt
            // 
            totalScoreTxt.AutoSize = true;
            totalScoreTxt.BackColor = Color.Transparent;
            totalScoreTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalScoreTxt.ForeColor = SystemColors.ButtonHighlight;
            totalScoreTxt.Location = new Point(418, 549);
            totalScoreTxt.Name = "totalScoreTxt";
            totalScoreTxt.Size = new Size(192, 43);
            totalScoreTxt.TabIndex = 17;
            totalScoreTxt.Text = "Total score: ";
            totalScoreTxt.Visible = false;
            // 
            // outScoreTxt
            // 
            outScoreTxt.AutoSize = true;
            outScoreTxt.BackColor = Color.Transparent;
            outScoreTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outScoreTxt.ForeColor = SystemColors.ButtonHighlight;
            outScoreTxt.Location = new Point(418, 473);
            outScoreTxt.Name = "outScoreTxt";
            outScoreTxt.Size = new Size(116, 43);
            outScoreTxt.TabIndex = 16;
            outScoreTxt.Text = "Score: ";
            outScoreTxt.Visible = false;
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 853);
            Controls.Add(totalScoreTxt);
            Controls.Add(outScoreTxt);
            Controls.Add(thanksTxt);
            Controls.Add(continueTxt);
            Controls.Add(winTxt);
            Controls.Add(retryTxt);
            Controls.Add(gameOverTxt);
            Controls.Add(player);
            Controls.Add(labelLivello);
            Controls.Add(panel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            KeyDown += keyDown;
            KeyUp += keyUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Panel panel1;
        private Label killsTxt;
        private Label scoreTxt;
        private PictureBox pictureBox1;
        private Label labelLivello;
        private PictureBox player;
        private Label continueTxt;
        private Label winTxt;
        private Label retryTxt;
        private Label gameOverTxt;
        private Label thanksTxt;
        private Label totalScoreTxt;
        private Label outScoreTxt;
    }
}