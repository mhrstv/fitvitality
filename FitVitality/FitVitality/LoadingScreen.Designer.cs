namespace FitVitality
{
    partial class loadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingScreen));
            loadTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            SuspendLayout();
            // 
            // loadTimer
            // 
            loadTimer.Enabled = true;
            loadTimer.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(200, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 302);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(246, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 13);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 225, 230);
            panel3.Location = new Point(246, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 13);
            panel3.TabIndex = 3;
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritToolTipTitle = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritToolTipTitle = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritToolTipTitle = false;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            // 
            // loadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(734, 444);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "loadingScreen";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Activated += loadingScreen_Activated;
            Load += loadingScreen_Load;
            Shown += loadingScreen_Shown;
            Enter += loadingScreen_Enter;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer loadTimer;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}