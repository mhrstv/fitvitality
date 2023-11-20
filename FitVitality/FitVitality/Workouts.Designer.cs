namespace FitVitality
{
    partial class Workouts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workouts));
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            workoutsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.leftC;
            pictureBox8.Location = new Point(0, 354);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(16, 15);
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.rightC;
            pictureBox6.Location = new Point(675, 354);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 15);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1, 355);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.vline;
            pictureBox4.Location = new Point(689, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1, 357);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hLine;
            pictureBox3.Location = new Point(12, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(667, 1);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hLine;
            pictureBox2.Location = new Point(13, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(664, 1);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // workoutsLabel
            // 
            workoutsLabel.AutoSize = true;
            workoutsLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            workoutsLabel.Location = new Point(282, 22);
            workoutsLabel.Name = "workoutsLabel";
            workoutsLabel.Size = new Size(108, 24);
            workoutsLabel.TabIndex = 20;
            workoutsLabel.Text = "Workouts";
            // 
            // Workouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(workoutsLabel);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Workouts";
            Text = "Workouts";
            Load += Workouts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label workoutsLabel;
    }
}