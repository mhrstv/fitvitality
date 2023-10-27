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
            buttonWorkout = new Krypton.Toolkit.KryptonButton();
            buttonDashboard = new Krypton.Toolkit.KryptonButton();
            panel3 = new Panel();
            topbar = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonMin = new PictureBox();
            buttonClose = new PictureBox();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.closebutton;
            kryptonPalette1.ButtonSpecs.FormMax.Image = (Image)resources.GetObject("resource.Image");
            kryptonPalette1.ButtonSpecs.FormMin.Image = (Image)resources.GetObject("resource.Image1");
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Properties.Resources.maximizebutton;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 1;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(11, -1, -1, -1);
            // 
            // buttonWorkout
            // 
            buttonWorkout.CornerRoundingRadius = 10F;
            buttonWorkout.Location = new Point(354, 3);
            buttonWorkout.Name = "buttonWorkout";
            buttonWorkout.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonWorkout.Size = new Size(25, 26);
            buttonWorkout.StateCommon.Back.Color1 = Color.White;
            buttonWorkout.StateCommon.Back.Color2 = Color.White;
            buttonWorkout.StateCommon.Back.ColorAngle = 45F;
            buttonWorkout.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StateCommon.Back.Image = (Image)resources.GetObject("buttonWorkout.StateCommon.Back.Image");
            buttonWorkout.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonWorkout.StateCommon.Border.Color1 = Color.Silver;
            buttonWorkout.StateCommon.Border.Color2 = Color.Silver;
            buttonWorkout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonWorkout.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StateCommon.Border.Rounding = 10F;
            buttonWorkout.StateCommon.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonWorkout.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWorkout.StateNormal.Back.Color1 = Color.White;
            buttonWorkout.StateNormal.Back.Color2 = Color.White;
            buttonWorkout.StateNormal.Back.ColorAngle = 45F;
            buttonWorkout.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StateNormal.Back.Image = (Image)resources.GetObject("buttonWorkout.StateNormal.Back.Image");
            buttonWorkout.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonWorkout.StateNormal.Border.Color1 = Color.Silver;
            buttonWorkout.StateNormal.Border.Color2 = Color.Silver;
            buttonWorkout.StateNormal.Border.ColorAngle = 45F;
            buttonWorkout.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonWorkout.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StateNormal.Border.Rounding = 10F;
            buttonWorkout.StateNormal.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonWorkout.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWorkout.StatePressed.Back.Color1 = Color.Gray;
            buttonWorkout.StatePressed.Back.Color2 = Color.Gray;
            buttonWorkout.StatePressed.Back.ColorAngle = 45F;
            buttonWorkout.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StatePressed.Back.Image = (Image)resources.GetObject("buttonWorkout.StatePressed.Back.Image");
            buttonWorkout.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonWorkout.StatePressed.Border.Color1 = Color.Silver;
            buttonWorkout.StatePressed.Border.Color2 = Color.Silver;
            buttonWorkout.StatePressed.Border.ColorAngle = 45F;
            buttonWorkout.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonWorkout.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StatePressed.Border.Rounding = 10F;
            buttonWorkout.StatePressed.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonWorkout.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWorkout.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            buttonWorkout.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            buttonWorkout.StateTracking.Back.ColorAngle = 45F;
            buttonWorkout.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StateTracking.Back.Image = (Image)resources.GetObject("buttonWorkout.StateTracking.Back.Image");
            buttonWorkout.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonWorkout.StateTracking.Border.Color1 = Color.Silver;
            buttonWorkout.StateTracking.Border.Color2 = Color.Silver;
            buttonWorkout.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonWorkout.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonWorkout.StateTracking.Border.Rounding = 10F;
            buttonWorkout.StateTracking.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonWorkout.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWorkout.TabIndex = 1;
            buttonWorkout.Values.Text = "";
            buttonWorkout.Click += kryptonButton2_Click_3;
            // 
            // buttonDashboard
            // 
            buttonDashboard.CornerRoundingRadius = 10F;
            buttonDashboard.Location = new Point(312, 3);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonDashboard.Size = new Size(19, 23);
            buttonDashboard.StateCommon.Back.Color1 = Color.White;
            buttonDashboard.StateCommon.Back.Color2 = Color.White;
            buttonDashboard.StateCommon.Back.ColorAngle = 45F;
            buttonDashboard.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateCommon.Back.Image = (Image)resources.GetObject("buttonDashboard.StateCommon.Back.Image");
            buttonDashboard.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            buttonDashboard.StateCommon.Border.Color1 = Color.Silver;
            buttonDashboard.StateCommon.Border.Color2 = Color.Silver;
            buttonDashboard.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateCommon.Border.Rounding = 10F;
            buttonDashboard.StateCommon.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.StateNormal.Back.Color1 = Color.White;
            buttonDashboard.StateNormal.Back.Color2 = Color.White;
            buttonDashboard.StateNormal.Back.ColorAngle = 45F;
            buttonDashboard.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateNormal.Back.Image = (Image)resources.GetObject("buttonDashboard.StateNormal.Back.Image");
            buttonDashboard.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            buttonDashboard.StateNormal.Border.Color1 = Color.Silver;
            buttonDashboard.StateNormal.Border.Color2 = Color.Silver;
            buttonDashboard.StateNormal.Border.ColorAngle = 45F;
            buttonDashboard.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateNormal.Border.Rounding = 10F;
            buttonDashboard.StateNormal.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.StatePressed.Back.Color1 = Color.Gray;
            buttonDashboard.StatePressed.Back.Color2 = Color.Gray;
            buttonDashboard.StatePressed.Back.ColorAngle = 45F;
            buttonDashboard.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StatePressed.Back.Image = (Image)resources.GetObject("buttonDashboard.StatePressed.Back.Image");
            buttonDashboard.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            buttonDashboard.StatePressed.Border.Color1 = Color.Silver;
            buttonDashboard.StatePressed.Border.Color2 = Color.Silver;
            buttonDashboard.StatePressed.Border.ColorAngle = 45F;
            buttonDashboard.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StatePressed.Border.Rounding = 10F;
            buttonDashboard.StatePressed.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            buttonDashboard.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            buttonDashboard.StateTracking.Back.ColorAngle = 45F;
            buttonDashboard.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateTracking.Back.Image = (Image)resources.GetObject("buttonDashboard.StateTracking.Back.Image");
            buttonDashboard.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            buttonDashboard.StateTracking.Border.Color1 = Color.Silver;
            buttonDashboard.StateTracking.Border.Color2 = Color.Silver;
            buttonDashboard.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateTracking.Border.Rounding = 10F;
            buttonDashboard.StateTracking.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Values.Text = "";
            buttonDashboard.Click += kryptonButton1_Click_1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 356);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;
            // 
            // topbar
            // 
            topbar.Controls.Add(buttonWorkout);
            topbar.Controls.Add(buttonDashboard);
            topbar.Controls.Add(pictureBox4);
            topbar.Controls.Add(pictureBox3);
            topbar.Controls.Add(buttonMin);
            topbar.Controls.Add(buttonClose);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(690, 32);
            topbar.TabIndex = 19;
            topbar.MouseDown += panel1_MouseDown;
            topbar.MouseMove += panel1_MouseMove;
            topbar.MouseUp += panel1_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.White;
            buttonMin.Image = (Image)resources.GetObject("buttonMin.Image");
            buttonMin.Location = new Point(636, 7);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(19, 19);
            buttonMin.SizeMode = PictureBoxSizeMode.CenterImage;
            buttonMin.TabIndex = 2;
            buttonMin.TabStop = false;
            buttonMin.Click += pictureBox2_Click;
            buttonMin.MouseEnter += pictureBox2_MouseEnter;
            buttonMin.MouseLeave += pictureBox2_MouseLeave;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Image = Properties.Resources.closebutton;
            buttonClose.Location = new Point(661, 7);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(19, 19);
            buttonClose.SizeMode = PictureBoxSizeMode.Zoom;
            buttonClose.TabIndex = 1;
            buttonClose.TabStop = false;
            buttonClose.Click += pictureBox1_Click;
            buttonClose.MouseEnter += pictureBox1_MouseEnter;
            buttonClose.MouseLeave += pictureBox1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(690, 400);
            Controls.Add(topbar);
            Controls.Add(panel3);
            CornerRoundingRadius = 15F;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(690, 400);
            Name = "Form1";
            Opacity = 0D;
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            StateCommon.Border.Rounding = 15F;
            Text = "FitVitality";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Shown += Form1_Shown;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel panel3;
        private Krypton.Toolkit.KryptonButton buttonDashboard;
        private Krypton.Toolkit.KryptonButton buttonWorkout;
        private Panel topbar;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox buttonMin;
        private PictureBox buttonClose;
    }
}