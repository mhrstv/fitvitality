﻿namespace FitVitality
{
    partial class marto1
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 144);
            label1.Name = "label1";
            label1.Size = new Size(217, 60);
            label1.TabIndex = 1;
            label1.Text = "MARTO1";
            // 
            // marto1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(699, 348);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "marto1";
            Text = "marto1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}