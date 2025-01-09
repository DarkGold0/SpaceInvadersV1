namespace SpaceInvadersV1
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
            PictureBox player;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            killsTxt = new Label();
            scoreTxt = new Label();
            pictureBox1 = new PictureBox();
            timeTxt = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Black;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(325, 464);
            player.Name = "player";
            player.Size = new Size(85, 85);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 42);
            panel1.TabIndex = 1;
            // 
            // killsTxt
            // 
            killsTxt.AutoSize = true;
            killsTxt.BackColor = Color.Black;
            killsTxt.Font = new Font("Impact", 14.25F);
            killsTxt.ForeColor = Color.White;
            killsTxt.Location = new Point(488, 9);
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
            scoreTxt.Location = new Point(562, 9);
            scoreTxt.Name = "scoreTxt";
            scoreTxt.Size = new Size(73, 23);
            scoreTxt.TabIndex = 1;
            scoreTxt.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(954, 36);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timeTxt
            // 
            timeTxt.AutoSize = true;
            timeTxt.BackColor = Color.Black;
            timeTxt.Font = new Font("Impact", 14.25F);
            timeTxt.ForeColor = Color.White;
            timeTxt.Location = new Point(3, 45);
            timeTxt.Name = "timeTxt";
            timeTxt.Size = new Size(56, 23);
            timeTxt.TabIndex = 3;
            timeTxt.Text = "0.00 s";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(734, 561);
            Controls.Add(timeTxt);
            Controls.Add(panel1);
            Controls.Add(player);
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
        private Label timeTxt;
        private Label killsTxt;
        private System.Windows.Forms.Timer gameTimer;
    }
}
