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
            bmi_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)arrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bmiPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(690, 368);
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
    }
}