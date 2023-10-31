namespace FitVitality
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            topbar = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonMin = new PictureBox();
            buttonClose = new PictureBox();
            panel1 = new Panel();
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
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(36, 41, 46);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(36, 41, 46);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(36, 41, 46);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(36, 41, 46);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(11, -1, -1, -1);
            // 
            // topbar
            // 
            topbar.Controls.Add(pictureBox4);
            topbar.Controls.Add(pictureBox3);
            topbar.Controls.Add(buttonMin);
            topbar.Controls.Add(buttonClose);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(690, 32);
            topbar.TabIndex = 20;
            topbar.MouseDown += topbar_MouseDown;
            topbar.MouseMove += topbar_MouseMove;
            topbar.MouseUp += topbar_MouseUp;
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
            buttonMin.BackColor = Color.FromArgb(36, 41, 46);
            buttonMin.Image = (Image)resources.GetObject("buttonMin.Image");
            buttonMin.Location = new Point(636, 7);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(19, 19);
            buttonMin.SizeMode = PictureBoxSizeMode.CenterImage;
            buttonMin.TabIndex = 2;
            buttonMin.TabStop = false;
            buttonMin.Click += buttonMin_Click;
            buttonMin.MouseEnter += buttonMin_MouseEnter;
            buttonMin.MouseLeave += buttonMin_MouseLeave;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(36, 41, 46);
            buttonClose.Image = Properties.Resources.closebutton;
            buttonClose.Location = new Point(661, 7);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(19, 19);
            buttonClose.SizeMode = PictureBoxSizeMode.Zoom;
            buttonClose.TabIndex = 1;
            buttonClose.TabStop = false;
            buttonClose.Click += buttonClose_Click;
            buttonClose.MouseEnter += buttonClose_MouseEnter;
            buttonClose.MouseLeave += buttonClose_MouseLeave;
            // 
            // panel1
            // 
            panel1.Location = new Point(71, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 299);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(690, 400);
            Controls.Add(panel1);
            Controls.Add(topbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Welcome";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitVitality";
            Load += Welcome_Load;
            Shown += Welcome_Shown;
            topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel topbar;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox buttonMin;
        private PictureBox buttonClose;
        private Panel panel1;
    }
}