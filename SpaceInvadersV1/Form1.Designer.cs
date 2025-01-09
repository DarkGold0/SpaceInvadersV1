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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player = new PictureBox();
            panel1 = new Panel();
            killsTxt = new Label();
            scoreTxt = new Label();
            pictureBox1 = new PictureBox();
            timeTxt = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            mainPicturebox = new PictureBox();
            titleTxt = new Label();
            credit1txt = new Label();
            startTxt = new Label();
            spriteImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteImage).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Black;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(574, 725);
            player.Margin = new Padding(3, 4, 3, 4);
            player.Name = "player";
            player.Size = new Size(100, 115);
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
            killsTxt.Location = new Point(558, 12);
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
            scoreTxt.Location = new Point(642, 12);
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
            // timeTxt
            // 
            timeTxt.AutoSize = true;
            timeTxt.BackColor = Color.Black;
            timeTxt.Font = new Font("Impact", 14.25F);
            timeTxt.ForeColor = Color.White;
            timeTxt.Location = new Point(3, 60);
            timeTxt.Name = "timeTxt";
            timeTxt.Size = new Size(71, 29);
            timeTxt.TabIndex = 3;
            timeTxt.Text = "0.00 s";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // mainPicturebox
            // 
            mainPicturebox.BackgroundImage = (Image)resources.GetObject("mainPicturebox.BackgroundImage");
            mainPicturebox.Location = new Point(0, -10);
            mainPicturebox.Name = "mainPicturebox";
            mainPicturebox.Size = new Size(1265, 864);
            mainPicturebox.TabIndex = 4;
            mainPicturebox.TabStop = false;
            // 
            // titleTxt
            // 
            titleTxt.AutoSize = true;
            titleTxt.BackColor = Color.Transparent;
            titleTxt.Font = new Font("Unispace", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleTxt.ForeColor = SystemColors.Window;
            titleTxt.Location = new Point(355, 126);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(585, 72);
            titleTxt.TabIndex = 5;
            titleTxt.Text = "SPACE DEFENDERS";
            // 
            // credit1txt
            // 
            credit1txt.AutoSize = true;
            credit1txt.BackColor = Color.Transparent;
            credit1txt.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            credit1txt.ForeColor = SystemColors.ButtonHighlight;
            credit1txt.Location = new Point(896, 816);
            credit1txt.Name = "credit1txt";
            credit1txt.Size = new Size(366, 24);
            credit1txt.TabIndex = 7;
            credit1txt.Text = "A game by: Alessandro Mercandino";
            // 
            // startTxt
            // 
            startTxt.AutoSize = true;
            startTxt.BackColor = Color.Transparent;
            startTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startTxt.ForeColor = Color.Yellow;
            startTxt.Location = new Point(439, 667);
            startTxt.Name = "startTxt";
            startTxt.Size = new Size(423, 54);
            startTxt.TabIndex = 8;
            startTxt.Text = "PRESS ENTER TO START!";
            // 
            // spriteImage
            // 
            spriteImage.BackColor = Color.Transparent;
            spriteImage.Image = (Image)resources.GetObject("spriteImage.Image");
            spriteImage.Location = new Point(531, 292);
            spriteImage.Name = "spriteImage";
            spriteImage.Size = new Size(249, 278);
            spriteImage.SizeMode = PictureBoxSizeMode.StretchImage;
            spriteImage.TabIndex = 9;
            spriteImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 853);
            Controls.Add(spriteImage);
            Controls.Add(startTxt);
            Controls.Add(credit1txt);
            Controls.Add(titleTxt);
            Controls.Add(mainPicturebox);
            Controls.Add(timeTxt);
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
            ((System.ComponentModel.ISupportInitialize)mainPicturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteImage).EndInit();
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
        private PictureBox mainPicturebox;
        private Label titleTxt;
        private Label credit1txt;
        private Label startTxt;
        private PictureBox spriteImage;
    }
}
