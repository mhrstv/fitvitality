namespace FitVitality
{
    partial class home
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
            rotationTimer = new System.Windows.Forms.Timer(components);
            hLine1 = new PictureBox();
            hLine2 = new PictureBox();
            vLine2 = new PictureBox();
            vLine1 = new PictureBox();
            rightC = new PictureBox();
            lefCorner = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lefCorner).BeginInit();
            SuspendLayout();
            // 
            // rotationTimer
            // 
            rotationTimer.Tick += rotationTimer_Tick_1;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 1);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(664, 1);
            hLine1.TabIndex = 4;
            hLine1.TabStop = false;
            hLine1.Click += pictureBox2_Click_1;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 367);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(667, 1);
            hLine2.TabIndex = 7;
            hLine2.TabStop = false;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(689, 0);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 357);
            vLine2.TabIndex = 8;
            vLine2.TabStop = false;
            // 
            // vLine1
            // 
            vLine1.Image = Properties.Resources.vline;
            vLine1.Location = new Point(0, -1);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 355);
            vLine1.TabIndex = 9;
            vLine1.TabStop = false;
            // 
            // rightC
            // 
            rightC.Image = Properties.Resources.rightC;
            rightC.Location = new Point(675, 354);
            rightC.Name = "rightC";
            rightC.Size = new Size(16, 15);
            rightC.TabIndex = 10;
            rightC.TabStop = false;
            // 
            // lefCorner
            // 
            lefCorner.Image = Properties.Resources.leftC;
            lefCorner.Location = new Point(0, 354);
            lefCorner.Name = "lefCorner";
            lefCorner.Size = new Size(16, 15);
            lefCorner.TabIndex = 12;
            lefCorner.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 22);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 13;
            label1.Text = "Dashboard";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(label1);
            Controls.Add(lefCorner);
            Controls.Add(rightC);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            Text = "home";
            Activated += home_Activated;
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightC).EndInit();
            ((System.ComponentModel.ISupportInitialize)lefCorner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer rotationTimer;
        private PictureBox hLine1;
        private PictureBox hLine2;
        private PictureBox vLine2;
        private PictureBox vLine1;
        private PictureBox rightC;
        private PictureBox lefCorner;
        private Label label1;
    }
}