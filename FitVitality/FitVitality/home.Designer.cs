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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            bmicalc_label = new Label();
            bmi_label = new Label();
            bmicategory_label = new Label();
            bmi_panel = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bmi_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bmicalc_label
            // 
            bmicalc_label.AutoSize = true;
            bmicalc_label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bmicalc_label.ForeColor = Color.FromArgb(92, 225, 230);
            bmicalc_label.Location = new Point(57, 10);
            bmicalc_label.Name = "bmicalc_label";
            bmicalc_label.Size = new Size(146, 22);
            bmicalc_label.TabIndex = 0;
            bmicalc_label.Text = "BMI Calculator";
            // 
            // bmi_label
            // 
            bmi_label.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bmi_label.Location = new Point(61, 140);
            bmi_label.Name = "bmi_label";
            bmi_label.Size = new Size(138, 23);
            bmi_label.TabIndex = 1;
            bmi_label.Text = "{BMI}";
            bmi_label.TextAlign = ContentAlignment.MiddleCenter;
            bmi_label.Click += bmi_label_Click;
            // 
            // bmicategory_label
            // 
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
            bmi_panel.Controls.Add(label1);
            bmi_panel.Controls.Add(pictureBox2);
            bmi_panel.Controls.Add(bmi_label);
            bmi_panel.Controls.Add(pictureBox1);
            bmi_panel.Controls.Add(bmicategory_label);
            bmi_panel.Controls.Add(bmicalc_label);
            bmi_panel.Location = new Point(418, 12);
            bmi_panel.Name = "bmi_panel";
            bmi_panel.Size = new Size(260, 164);
            bmi_panel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 97);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 88);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label bmicalc_label;
        private Label bmi_label;
        private Label bmicategory_label;
        private Panel bmi_panel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}