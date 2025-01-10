namespace SpaceInvadersV1
{
    partial class Menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            mainPicturebox = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)mainPicturebox).BeginInit();
            SuspendLayout();
            // 
            // mainPicturebox
            // 
            mainPicturebox.BackgroundImage = (Image)resources.GetObject("mainPicturebox.BackgroundImage");
            mainPicturebox.Location = new Point(-4, -10);
            mainPicturebox.Margin = new Padding(3, 2, 3, 2);
            mainPicturebox.Name = "mainPicturebox";
            mainPicturebox.Size = new Size(1107, 667);
            mainPicturebox.TabIndex = 5;
            mainPicturebox.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(492, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Menu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 640);
            Controls.Add(button1);
            Controls.Add(mainPicturebox);
            Name = "Menu1";
            Text = "Menu1";
            Load += Menu1_Load;
            ((System.ComponentModel.ISupportInitialize)mainPicturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainPicturebox;
        private Button button1;
    }
}