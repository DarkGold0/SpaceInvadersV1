﻿namespace SpaceInvadersV1
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(512, 42);
            label1.TabIndex = 0;
            label1.Text = "Use the arrow keys or WASD to move";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 19.8000011F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 81);
            label2.Name = "label2";
            label2.Size = new Size(273, 42);
            label2.TabIndex = 1;
            label2.Text = "Press SPACE to fire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 19.8000011F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(35, 186);
            label3.Name = "label3";
            label3.Size = new Size(250, 42);
            label3.TabIndex = 2;
            label3.Text = "Enjoy the game ;)";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(577, 251);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}