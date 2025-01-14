namespace SpaceInvadersV1
{
    partial class controlsBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlsBtn));
            startBtn1 = new Button();
            label1 = new Label();
            credit1txt = new Label();
            scoreTxt = new Label();
            showControlsBtn = new Button();
            SuspendLayout();
            // 
            // startBtn1
            // 
            startBtn1.BackColor = Color.Yellow;
            startBtn1.Cursor = Cursors.Hand;
            startBtn1.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startBtn1.Location = new Point(508, 484);
            startBtn1.Margin = new Padding(3, 4, 3, 4);
            startBtn1.Name = "startBtn1";
            startBtn1.Size = new Size(248, 130);
            startBtn1.TabIndex = 6;
            startBtn1.Text = "Click to play!\r\n\r\n\r\n";
            startBtn1.UseVisualStyleBackColor = false;
            startBtn1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(258, 213);
            label1.Name = "label1";
            label1.Size = new Size(775, 96);
            label1.TabIndex = 7;
            label1.Text = "SPACE DEFENDERS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // credit1txt
            // 
            credit1txt.AutoSize = true;
            credit1txt.BackColor = Color.Transparent;
            credit1txt.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            credit1txt.ForeColor = SystemColors.ButtonHighlight;
            credit1txt.Location = new Point(884, 820);
            credit1txt.Name = "credit1txt";
            credit1txt.Size = new Size(366, 24);
            credit1txt.TabIndex = 8;
            credit1txt.Text = "A game by: Alessandro Mercandino";
            // 
            // scoreTxt
            // 
            scoreTxt.AutoSize = true;
            scoreTxt.BackColor = Color.Transparent;
            scoreTxt.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreTxt.ForeColor = SystemColors.ButtonHighlight;
            scoreTxt.Location = new Point(12, 18);
            scoreTxt.Name = "scoreTxt";
            scoreTxt.Size = new Size(251, 54);
            scoreTxt.TabIndex = 9;
            scoreTxt.Text = "Latest score:";
            // 
            // showControlsBtn
            // 
            showControlsBtn.BackColor = Color.FromArgb(255, 192, 128);
            showControlsBtn.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showControlsBtn.Location = new Point(726, 414);
            showControlsBtn.Name = "showControlsBtn";
            showControlsBtn.Size = new Size(129, 49);
            showControlsBtn.TabIndex = 10;
            showControlsBtn.Text = "Show controls:";
            showControlsBtn.UseVisualStyleBackColor = false;
            showControlsBtn.Click += button1_Click_1;
            // 
            // controlsBtn
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 853);
            Controls.Add(showControlsBtn);
            Controls.Add(scoreTxt);
            Controls.Add(credit1txt);
            Controls.Add(label1);
            Controls.Add(startBtn1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "controlsBtn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu1";
            Load += Menu1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startBtn1;
        private Label label1;
        private Label credit1txt;
        private Label scoreTxt;
        private Button showControlsBtn;
    }
}