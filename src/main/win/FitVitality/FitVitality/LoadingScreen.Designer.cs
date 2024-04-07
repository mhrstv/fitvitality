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
            panelLogo = new Panel();
            panelLoad2 = new Panel();
            panelLoad = new Panel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            percentages = new TextBox();
            panelLoad2.SuspendLayout();
            SuspendLayout();
            // 
            // loadTimer
            // 
            loadTimer.Enabled = true;
            loadTimer.Tick += timer1_Tick;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Location = new Point(28, 11);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(335, 302);
            panelLogo.TabIndex = 1;
            // 
            // panelLoad2
            // 
            panelLoad2.BackColor = Color.Black;
            panelLoad2.Controls.Add(panelLoad);
            panelLoad2.Location = new Point(74, 365);
            panelLoad2.Name = "panelLoad2";
            panelLoad2.Size = new Size(242, 13);
            panelLoad2.TabIndex = 2;
            // 
            // panelLoad
            // 
            panelLoad.BackColor = Color.FromArgb(92, 225, 230);
            panelLoad.Location = new Point(0, 0);
            panelLoad.Name = "panelLoad";
            panelLoad.Size = new Size(1, 13);
            panelLoad.TabIndex = 3;
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
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = Color.Black;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = Color.Black;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = Color.Black;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = Color.Black;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 0F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color1 = Color.Black;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color2 = Color.Black;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color1 = Color.Black;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color2 = Color.Black;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            // 
            // percentages
            // 
            percentages.BackColor = Color.Black;
            percentages.BorderStyle = BorderStyle.None;
            percentages.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            percentages.ForeColor = Color.FromArgb(92, 225, 230);
            percentages.Location = new Point(157, 319);
            percentages.Name = "percentages";
            percentages.ReadOnly = true;
            percentages.Size = new Size(76, 28);
            percentages.TabIndex = 5;
            percentages.TabStop = false;
            percentages.TextAlign = HorizontalAlignment.Center;
            // 
            // loadingScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            ClientSize = new Size(390, 400);
            ControlBox = false;
            Controls.Add(percentages);
            Controls.Add(panelLoad2);
            Controls.Add(panelLogo);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loadingScreen";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosed += loadingScreen_FormClosed;
            Load += loadingScreen_Load;
            Shown += loadingScreen_Shown;
            panelLoad2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer loadTimer;
        private Panel panelLogo;
        private Panel panelLoad2;
        private Panel panelLoad;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TextBox percentages;
    }
}