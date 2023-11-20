namespace FitVitality
{
    partial class Diet
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
            leftC = new PictureBox();
            rightC = new PictureBox();
            vLine1 = new PictureBox();
            vLine2 = new PictureBox();
            hLine2 = new PictureBox();
            hLine1 = new PictureBox();
            dietLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)leftC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            SuspendLayout();
            // 
            // leftC
            // 
            leftC.Image = Properties.Resources.leftC;
            leftC.Location = new Point(0, 354);
            leftC.Name = "leftC";
            leftC.Size = new Size(16, 15);
            leftC.TabIndex = 19;
            leftC.TabStop = false;
            // 
            // rightC
            // 
            rightC.Image = Properties.Resources.rightC;
            rightC.Location = new Point(675, 354);
            rightC.Name = "rightC";
            rightC.Size = new Size(16, 15);
            rightC.TabIndex = 17;
            rightC.TabStop = false;
            // 
            // vLine1
            // 
            vLine1.Image = Properties.Resources.vline;
            vLine1.Location = new Point(0, -1);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 355);
            vLine1.TabIndex = 16;
            vLine1.TabStop = false;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(689, 0);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 357);
            vLine2.TabIndex = 15;
            vLine2.TabStop = false;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 367);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(667, 1);
            hLine2.TabIndex = 14;
            hLine2.TabStop = false;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 1);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(664, 1);
            hLine1.TabIndex = 13;
            hLine1.TabStop = false;
            // 
            // dietLabel
            // 
            dietLabel.AutoSize = true;
            dietLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dietLabel.Location = new Point(320, 22);
            dietLabel.Name = "dietLabel";
            dietLabel.Size = new Size(51, 24);
            dietLabel.TabIndex = 21;
            dietLabel.Text = "Diet";
            // 
            // Diet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(dietLabel);
            Controls.Add(leftC);
            Controls.Add(rightC);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diet";
            Text = "Diet";
            ((System.ComponentModel.ISupportInitialize)leftC).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightC).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox leftC;
        private PictureBox rightC;
        private PictureBox vLine1;
        private PictureBox vLine2;
        private PictureBox hLine2;
        private PictureBox hLine1;
        private Label dietLabel;
    }
}