namespace SpaceInvadersV1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            killsTxt = new Label();
            scoreTxt = new Label();
            pictureBox1 = new PictureBox();
            player = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            labelLivello = new Label();
            gameOverTxt = new Label();
            retryTxt = new Label();
            winTxt = new Label();
            continueTxt = new Label();
            totalScoreTxt = new Label();
            outScoreTxt = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 2;
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
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(579, 712);
            player.Margin = new Padding(3, 4, 3, 4);
            player.Name = "player";
            player.Size = new Size(101, 115);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 5;
            player.TabStop = false;
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
            labelLivello.ForeColor = Color.FromArgb(255, 128, 0);
            labelLivello.Location = new Point(12, 765);
            labelLivello.Name = "labelLivello";
            labelLivello.Size = new Size(206, 75);
            labelLivello.TabIndex = 6;
            labelLivello.Text = "LEVEL 2";
            // 
            // gameOverTxt
            // 
            gameOverTxt.AutoSize = true;
            gameOverTxt.BackColor = Color.Transparent;
            gameOverTxt.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameOverTxt.ForeColor = Color.Red;
            gameOverTxt.Location = new Point(344, 246);
            gameOverTxt.Name = "gameOverTxt";
            gameOverTxt.Size = new Size(590, 145);
            gameOverTxt.TabIndex = 7;
            gameOverTxt.Text = "GAME OVER";
            gameOverTxt.Visible = false;
            // 
            // retryTxt
            // 
            retryTxt.AutoSize = true;
            retryTxt.BackColor = Color.Transparent;
            retryTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retryTxt.ForeColor = Color.Red;
            retryTxt.Location = new Point(456, 391);
            retryTxt.Name = "retryTxt";
            retryTxt.Size = new Size(368, 54);
            retryTxt.TabIndex = 8;
            retryTxt.Text = "Press enter to retry";
            retryTxt.Visible = false;
            // 
            // winTxt
            // 
            winTxt.AutoSize = true;
            winTxt.BackColor = Color.Transparent;
            winTxt.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winTxt.ForeColor = Color.Lime;
            winTxt.Location = new Point(369, 246);
            winTxt.Name = "winTxt";
            winTxt.Size = new Size(533, 145);
            winTxt.TabIndex = 9;
            winTxt.Text = "YOU WON!";
            winTxt.Visible = false;
            // 
            // continueTxt
            // 
            continueTxt.AutoSize = true;
            continueTxt.BackColor = Color.Transparent;
            continueTxt.Font = new Font("Impact", 25.8000011F);
            continueTxt.ForeColor = Color.Lime;
            continueTxt.Location = new Point(418, 391);
            continueTxt.Name = "continueTxt";
            continueTxt.Size = new Size(440, 54);
            continueTxt.TabIndex = 10;
            continueTxt.Text = "Press enter to continue";
            continueTxt.Visible = false;
            // 
            // totalScoreTxt
            // 
            totalScoreTxt.AutoSize = true;
            totalScoreTxt.BackColor = Color.Transparent;
            totalScoreTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalScoreTxt.ForeColor = SystemColors.ButtonHighlight;
            totalScoreTxt.Location = new Point(418, 549);
            totalScoreTxt.Name = "totalScoreTxt";
            totalScoreTxt.Size = new Size(240, 54);
            totalScoreTxt.TabIndex = 12;
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
            outScoreTxt.Size = new Size(145, 54);
            outScoreTxt.TabIndex = 11;
            outScoreTxt.Text = "Score: ";
            outScoreTxt.Visible = false;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 853);
            Controls.Add(totalScoreTxt);
            Controls.Add(outScoreTxt);
            Controls.Add(continueTxt);
            Controls.Add(winTxt);
            Controls.Add(retryTxt);
            Controls.Add(gameOverTxt);
            Controls.Add(labelLivello);
            Controls.Add(player);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
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

        private Panel panel1;
        private Label killsTxt;
        private Label scoreTxt;
        private PictureBox pictureBox1;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private Label labelLivello;
        private Label gameOverTxt;
        private Label retryTxt;
        private Label winTxt;
        private Label continueTxt;
        private Label totalScoreTxt;
        private Label outScoreTxt;
    }
}