namespace FitVitality
{
    partial class WorkoutsDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutsDashboard));
            leftCorner = new PictureBox();
            rightCorner = new PictureBox();
            vLine1 = new PictureBox();
            vLine2 = new PictureBox();
            hLine2 = new PictureBox();
            hLine1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            SuspendLayout();
            // 
            // leftCorner
            // 
            leftCorner.Image = Properties.Resources.leftC;
            leftCorner.Location = new Point(0, 354);
            leftCorner.Name = "leftCorner";
            leftCorner.Size = new Size(16, 15);
            leftCorner.TabIndex = 25;
            leftCorner.TabStop = false;
            // 
            // rightCorner
            // 
            rightCorner.Image = Properties.Resources.rightC;
            rightCorner.Location = new Point(675, 354);
            rightCorner.Name = "rightCorner";
            rightCorner.Size = new Size(16, 15);
            rightCorner.TabIndex = 24;
            rightCorner.TabStop = false;
            // 
            // vLine1
            // 
            vLine1.Image = (Image)resources.GetObject("vLine1.Image");
            vLine1.Location = new Point(0, -1);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 355);
            vLine1.TabIndex = 23;
            vLine1.TabStop = false;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(689, 0);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 357);
            vLine2.TabIndex = 22;
            vLine2.TabStop = false;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 367);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(667, 1);
            hLine2.TabIndex = 21;
            hLine2.TabStop = false;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 1);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(664, 1);
            hLine1.TabIndex = 20;
            hLine1.TabStop = false;
            // 
            // WorkoutsDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(leftCorner);
            Controls.Add(rightCorner);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.None;
            Name = "WorkoutsDashboard";
            Text = "WorkoutsDashboard";
            ((System.ComponentModel.ISupportInitialize)leftCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox leftCorner;
        private PictureBox rightCorner;
        private PictureBox vLine1;
        private PictureBox vLine2;
        private PictureBox hLine2;
        private PictureBox hLine1;
    }
}