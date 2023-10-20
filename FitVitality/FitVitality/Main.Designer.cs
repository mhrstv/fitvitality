namespace FitVitality
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            home = new Krypton.Toolkit.KryptonButton();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.closebutton;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritToolTipTitle = false;
            kryptonPalette1.ButtonSpecs.FormMax.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            kryptonPalette1.ButtonSpecs.FormMin.Image = (Image)resources.GetObject("resource.Image");
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 29);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(44, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(650, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.closebutton;
            pictureBox1.Location = new Point(675, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // panel2
            // 
            panel2.Controls.Add(kryptonButton2);
            panel2.Controls.Add(kryptonButton1);
            panel2.Controls.Add(home);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 32);
            panel2.TabIndex = 1;
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = -1F;
            kryptonButton2.Location = new Point(394, 0);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(53, 29);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonButton2.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 255);
            kryptonButton2.StateCommon.Border.Color2 = Color.FromArgb(128, 255, 255);
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.TabIndex = 2;
            kryptonButton2.Values.Text = "marto2";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(335, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(53, 29);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 255);
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 255);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(128, 255, 255);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.Text = "marto1";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // home
            // 
            home.CornerRoundingRadius = -1F;
            home.Location = new Point(276, 0);
            home.Name = "home";
            home.Size = new Size(53, 29);
            home.StateCommon.Back.Color1 = Color.FromArgb(128, 255, 255);
            home.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 255);
            home.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 255);
            home.StateCommon.Border.Color2 = Color.FromArgb(128, 255, 255);
            home.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            home.TabIndex = 0;
            home.Values.Text = "home";
            home.Click += home_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 384);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(706, 439);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0D;
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitVitality";
            Activated += Form1_Activated;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton home;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Panel panel3;
    }
}