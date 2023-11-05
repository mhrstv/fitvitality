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
            buttonDashboard = new Krypton.Toolkit.KryptonButton();
            mainPanel = new Panel();
            topbar = new Panel();
            buttonHome = new Krypton.Toolkit.KryptonButton();
            buttonSettings = new Krypton.Toolkit.KryptonButton();
            logo2 = new PictureBox();
            logo1 = new PictureBox();
            buttonMin = new PictureBox();
            buttonClose = new PictureBox();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
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
            // buttonDashboard
            // 
            buttonDashboard.CornerRoundingRadius = 15F;
            buttonDashboard.Location = new Point(169, 2);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonDashboard.Size = new Size(42, 28);
            buttonDashboard.StateCommon.Back.Color1 = Color.White;
            buttonDashboard.StateCommon.Back.Color2 = Color.White;
            buttonDashboard.StateCommon.Back.ColorAngle = 45F;
            buttonDashboard.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateCommon.Back.Image = (Image)resources.GetObject("buttonDashboard.StateCommon.Back.Image");
            buttonDashboard.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Tile;
            buttonDashboard.StateCommon.Border.Color1 = Color.Silver;
            buttonDashboard.StateCommon.Border.Color2 = Color.Silver;
            buttonDashboard.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateCommon.Border.Rounding = 15F;
            buttonDashboard.StateCommon.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            buttonDashboard.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            buttonDashboard.StateNormal.Back.ColorAngle = 45F;
            buttonDashboard.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateNormal.Back.Image = (Image)resources.GetObject("buttonDashboard.StateNormal.Back.Image");
            buttonDashboard.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonDashboard.StateNormal.Border.Color1 = Color.Transparent;
            buttonDashboard.StateNormal.Border.Color2 = Color.Transparent;
            buttonDashboard.StateNormal.Border.ColorAngle = 45F;
            buttonDashboard.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateNormal.Border.Rounding = 22F;
            buttonDashboard.StateNormal.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            buttonDashboard.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            buttonDashboard.StatePressed.Back.ColorAngle = 45F;
            buttonDashboard.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StatePressed.Back.Image = Properties.Resources.workout;
            buttonDashboard.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonDashboard.StatePressed.Border.Color1 = Color.Transparent;
            buttonDashboard.StatePressed.Border.Color2 = Color.Transparent;
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
            buttonDashboard.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonDashboard.StateTracking.Border.Color1 = Color.Transparent;
            buttonDashboard.StateTracking.Border.Color2 = Color.Transparent;
            buttonDashboard.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDashboard.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDashboard.StateTracking.Border.Rounding = 10F;
            buttonDashboard.StateTracking.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonDashboard.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Values.Text = "";
            buttonDashboard.Click += kryptonButton1_Click_1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 32);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(690, 368);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += panel3_Paint;
            mainPanel.MouseDown += panel3_MouseDown;
            mainPanel.MouseMove += panel3_MouseMove;
            mainPanel.MouseUp += panel3_MouseUp;
            // 
            // topbar
            // 
            topbar.Controls.Add(buttonHome);
            topbar.Controls.Add(buttonSettings);
            topbar.Controls.Add(buttonDashboard);
            topbar.Controls.Add(logo2);
            topbar.Controls.Add(logo1);
            topbar.Controls.Add(buttonMin);
            topbar.Controls.Add(buttonClose);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(690, 32);
            topbar.TabIndex = 19;
            topbar.Paint += topbar_Paint;
            topbar.MouseDown += panel1_MouseDown;
            topbar.MouseMove += panel1_MouseMove;
            topbar.MouseUp += panel1_MouseUp;
            // 
            // buttonHome
            // 
            buttonHome.CornerRoundingRadius = 15F;
            buttonHome.Location = new Point(120, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonHome.Size = new Size(42, 28);
            buttonHome.StateCommon.Back.Color1 = Color.White;
            buttonHome.StateCommon.Back.Color2 = Color.White;
            buttonHome.StateCommon.Back.ColorAngle = 45F;
            buttonHome.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StateCommon.Back.Image = Properties.Resources.home;
            buttonHome.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Tile;
            buttonHome.StateCommon.Border.Color1 = Color.Silver;
            buttonHome.StateCommon.Border.Color2 = Color.Silver;
            buttonHome.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonHome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StateCommon.Border.Rounding = 15F;
            buttonHome.StateCommon.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonHome.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            buttonHome.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            buttonHome.StateNormal.Back.ColorAngle = 45F;
            buttonHome.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StateNormal.Back.Image = Properties.Resources.home;
            buttonHome.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonHome.StateNormal.Border.Color1 = Color.Transparent;
            buttonHome.StateNormal.Border.Color2 = Color.Transparent;
            buttonHome.StateNormal.Border.ColorAngle = 45F;
            buttonHome.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonHome.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StateNormal.Border.Rounding = 22F;
            buttonHome.StateNormal.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonHome.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            buttonHome.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            buttonHome.StatePressed.Back.ColorAngle = 45F;
            buttonHome.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StatePressed.Back.Image = Properties.Resources.home;
            buttonHome.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonHome.StatePressed.Border.Color1 = Color.Transparent;
            buttonHome.StatePressed.Border.Color2 = Color.Transparent;
            buttonHome.StatePressed.Border.ColorAngle = 45F;
            buttonHome.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonHome.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StatePressed.Border.Rounding = 10F;
            buttonHome.StatePressed.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonHome.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            buttonHome.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            buttonHome.StateTracking.Back.ColorAngle = 45F;
            buttonHome.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StateTracking.Back.Image = Properties.Resources.home;
            buttonHome.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonHome.StateTracking.Border.Color1 = Color.Transparent;
            buttonHome.StateTracking.Border.Color2 = Color.Transparent;
            buttonHome.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonHome.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonHome.StateTracking.Border.Rounding = 10F;
            buttonHome.StateTracking.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonHome.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.TabIndex = 4;
            buttonHome.Values.Text = "";
            buttonHome.Click += kryptonButton1_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.CornerRoundingRadius = 15F;
            buttonSettings.Location = new Point(610, 7);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonSettings.Size = new Size(19, 19);
            buttonSettings.StateCommon.Back.Color1 = Color.White;
            buttonSettings.StateCommon.Back.Color2 = Color.White;
            buttonSettings.StateCommon.Back.ColorAngle = 45F;
            buttonSettings.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StateCommon.Back.Image = Properties.Resources.sett_1_1;
            buttonSettings.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Tile;
            buttonSettings.StateCommon.Border.Color1 = Color.Silver;
            buttonSettings.StateCommon.Border.Color2 = Color.Silver;
            buttonSettings.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSettings.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StateCommon.Border.Rounding = 15F;
            buttonSettings.StateCommon.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonSettings.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            buttonSettings.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            buttonSettings.StateNormal.Back.ColorAngle = 45F;
            buttonSettings.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StateNormal.Back.Image = (Image)resources.GetObject("buttonSettings.StateNormal.Back.Image");
            buttonSettings.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonSettings.StateNormal.Border.Color1 = Color.Transparent;
            buttonSettings.StateNormal.Border.Color2 = Color.Transparent;
            buttonSettings.StateNormal.Border.ColorAngle = 45F;
            buttonSettings.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSettings.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StateNormal.Border.Rounding = 22F;
            buttonSettings.StateNormal.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonSettings.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            buttonSettings.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            buttonSettings.StatePressed.Back.ColorAngle = 45F;
            buttonSettings.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StatePressed.Back.Image = (Image)resources.GetObject("buttonSettings.StatePressed.Back.Image");
            buttonSettings.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonSettings.StatePressed.Border.Color1 = Color.Transparent;
            buttonSettings.StatePressed.Border.Color2 = Color.Transparent;
            buttonSettings.StatePressed.Border.ColorAngle = 45F;
            buttonSettings.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSettings.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StatePressed.Border.Rounding = 10F;
            buttonSettings.StatePressed.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonSettings.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.StateTracking.Back.Color1 = Color.FromArgb(224, 224, 224);
            buttonSettings.StateTracking.Back.Color2 = Color.FromArgb(224, 224, 224);
            buttonSettings.StateTracking.Back.ColorAngle = 45F;
            buttonSettings.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StateTracking.Back.Image = Properties.Resources.sett_1_1;
            buttonSettings.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            buttonSettings.StateTracking.Border.Color1 = Color.Transparent;
            buttonSettings.StateTracking.Border.Color2 = Color.Transparent;
            buttonSettings.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSettings.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSettings.StateTracking.Border.Rounding = 10F;
            buttonSettings.StateTracking.Content.Padding = new Padding(-1, 32, -1, -1);
            buttonSettings.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.TabIndex = 3;
            buttonSettings.Values.Text = "";
            buttonSettings.Click += buttonSettings_Click;
            // 
            // logo2
            // 
            logo2.Image = (Image)resources.GetObject("logo2.Image");
            logo2.Location = new Point(40, 7);
            logo2.Name = "logo2";
            logo2.Size = new Size(66, 20);
            logo2.SizeMode = PictureBoxSizeMode.Zoom;
            logo2.TabIndex = 1;
            logo2.TabStop = false;
            logo2.Click += pictureBox4_Click;
            // 
            // logo1
            // 
            logo1.Image = (Image)resources.GetObject("logo1.Image");
            logo1.Location = new Point(8, 6);
            logo1.Name = "logo1";
            logo1.Size = new Size(26, 24);
            logo1.SizeMode = PictureBoxSizeMode.Zoom;
            logo1.TabIndex = 1;
            logo1.TabStop = false;
            logo1.Click += pictureBox3_Click;
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
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(690, 400);
            Controls.Add(topbar);
            Controls.Add(mainPanel);
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
            ((System.ComponentModel.ISupportInitialize)logo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel mainPanel;
        private Krypton.Toolkit.KryptonButton buttonDashboard;
        private Panel topbar;
        private PictureBox logo2;
        private PictureBox logo1;
        private PictureBox buttonMin;
        private PictureBox buttonClose;
        private Krypton.Toolkit.KryptonButton buttonSettings;
        private Krypton.Toolkit.KryptonButton buttonHome;
    }
}