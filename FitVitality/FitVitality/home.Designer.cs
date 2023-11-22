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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            bmicalc_label = new Label();
            bmi_label = new Label();
            bmicategory_label = new Label();
            bmi_panel = new Panel();
            per75 = new Label();
            arrow = new PictureBox();
            per50 = new Label();
            per25 = new Label();
            bmiPicture = new PictureBox();
            bmiBackground = new PictureBox();
            rotationTimer = new System.Windows.Forms.Timer(components);
            hLine1 = new PictureBox();
            hLine2 = new PictureBox();
            vLine2 = new PictureBox();
            vLine1 = new PictureBox();
            rightC = new PictureBox();
            lefCorner = new PictureBox();
            bmi_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bmiPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bmiBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lefCorner).BeginInit();
            SuspendLayout();
            // 
            // bmicalc_label
            // 
            bmicalc_label.AutoSize = true;
            bmicalc_label.BackColor = Color.FromArgb(160, 218, 220);
            bmicalc_label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bmicalc_label.ForeColor = Color.FromArgb(0, 192, 192);
            bmicalc_label.Location = new Point(57, 10);
            bmicalc_label.Name = "bmicalc_label";
            bmicalc_label.Size = new Size(146, 22);
            bmicalc_label.TabIndex = 0;
            bmicalc_label.Text = "BMI Calculator";
            // 
            // bmi_label
            // 
            bmi_label.BackColor = Color.FromArgb(160, 218, 220);
            bmi_label.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bmi_label.Location = new Point(61, 141);
            bmi_label.Name = "bmi_label";
            bmi_label.Size = new Size(138, 22);
            bmi_label.TabIndex = 1;
            bmi_label.Text = "{BMI}";
            bmi_label.TextAlign = ContentAlignment.MiddleCenter;
            bmi_label.Click += bmi_label_Click;
            // 
            // bmicategory_label
            // 
            bmicategory_label.BackColor = Color.FromArgb(160, 218, 220);
            bmicategory_label.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bmicategory_label.Location = new Point(28, 32);
            bmicategory_label.Name = "bmicategory_label";
            bmicategory_label.Size = new Size(205, 23);
            bmicategory_label.TabIndex = 2;
            bmicategory_label.Text = "{Category}";
            bmicategory_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bmi_panel
            // 
            bmi_panel.BackColor = Color.FromArgb(160, 218, 220);
            bmi_panel.Controls.Add(bmi_label);
            bmi_panel.Controls.Add(per75);
            bmi_panel.Controls.Add(arrow);
            bmi_panel.Controls.Add(per50);
            bmi_panel.Controls.Add(per25);
            bmi_panel.Controls.Add(bmiPicture);
            bmi_panel.Controls.Add(bmicategory_label);
            bmi_panel.Controls.Add(bmicalc_label);
            bmi_panel.Controls.Add(bmiBackground);
            bmi_panel.Location = new Point(418, 12);
            bmi_panel.Name = "bmi_panel";
            bmi_panel.Size = new Size(260, 164);
            bmi_panel.TabIndex = 3;
            // 
            // per75
            // 
            per75.BackColor = Color.FromArgb(160, 218, 220);
            per75.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            per75.Location = new Point(170, 75);
            per75.Name = "per75";
            per75.Size = new Size(20, 11);
            per75.TabIndex = 7;
            per75.Text = "75%";
            // 
            // arrow
            // 
            arrow.Image = Properties.Resources.arrowFinal;
            arrow.Location = new Point(101, 103);
            arrow.Name = "arrow";
            arrow.Size = new Size(57, 57);
            arrow.SizeMode = PictureBoxSizeMode.Zoom;
            arrow.TabIndex = 4;
            arrow.TabStop = false;
            arrow.Click += pictureBox2_Click;
            // 
            // per50
            // 
            per50.BackColor = Color.FromArgb(160, 218, 220);
            per50.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            per50.Location = new Point(120, 58);
            per50.Name = "per50";
            per50.Size = new Size(20, 11);
            per50.TabIndex = 6;
            per50.Text = "50%";
            // 
            // per25
            // 
            per25.BackColor = Color.FromArgb(160, 218, 220);
            per25.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            per25.Location = new Point(69, 75);
            per25.Name = "per25";
            per25.Size = new Size(21, 11);
            per25.TabIndex = 5;
            per25.Text = "25%";
            // 
            // bmiPicture
            // 
            bmiPicture.BackColor = Color.Transparent;
            bmiPicture.Image = Properties.Resources.bmiFinal;
            bmiPicture.Location = new Point(61, 58);
            bmiPicture.Name = "bmiPicture";
            bmiPicture.Size = new Size(138, 88);
            bmiPicture.SizeMode = PictureBoxSizeMode.Zoom;
            bmiPicture.TabIndex = 3;
            bmiPicture.TabStop = false;
            // 
            // bmiBackground
            // 
            bmiBackground.Image = (Image)resources.GetObject("bmiBackground.Image");
            bmiBackground.Location = new Point(0, 0);
            bmiBackground.Name = "bmiBackground";
            bmiBackground.Size = new Size(260, 164);
            bmiBackground.TabIndex = 9;
            bmiBackground.TabStop = false;
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
            // home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(lefCorner);
            Controls.Add(rightC);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            Controls.Add(bmi_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            Text = "home";
            Activated += home_Activated;
            Load += home_Load;
            bmi_panel.ResumeLayout(false);
            bmi_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)arrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)bmiPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bmiBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightC).EndInit();
            ((System.ComponentModel.ISupportInitialize)lefCorner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label bmicalc_label;
        private Label bmi_label;
        private Label bmicategory_label;
        private Panel bmi_panel;
        private PictureBox bmiPicture;
        private PictureBox arrow;
        private Label per25;
        private Label per75;
        private Label per50;
        private System.Windows.Forms.Timer rotationTimer;
        private PictureBox bmiBackground;
        private PictureBox hLine1;
        private PictureBox hLine2;
        private PictureBox vLine2;
        private PictureBox vLine1;
        private PictureBox rightC;
        private PictureBox lefCorner;
    }
}