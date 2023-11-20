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
            pictureBox1 = new PictureBox();
            rotationTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            bmi_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bmiPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
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
            bmi_panel.Controls.Add(pictureBox1);
            bmi_panel.Location = new Point(418, 12);
            bmi_panel.Name = "bmi_panel";
            bmi_panel.Size = new Size(260, 164);
            bmi_panel.TabIndex = 3;
            // 
            // per75
            // 
            per75.BackColor = Color.FromArgb(160, 218, 220);
            per75.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            per75.Location = new Point(169, 75);
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
            per25.Location = new Point(70, 75);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 164);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // rotationTimer
            // 
            rotationTimer.Tick += rotationTimer_Tick_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hLine;
            pictureBox2.Location = new Point(13, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(664, 1);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hLine;
            pictureBox3.Location = new Point(12, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(667, 1);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.vline;
            pictureBox4.Location = new Point(689, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1, 357);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1, 355);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.rightC;
            pictureBox6.Location = new Point(675, 354);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 15);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.vline;
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1, 357);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.leftC;
            pictureBox8.Location = new Point(0, 354);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(16, 15);
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}