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
            textBox1 = new TextBox();
            panel2.SuspendLayout();
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
            panel1.Location = new Point(28, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 302);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(74, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 13);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 225, 230);
            panel3.Location = new Point(0, 0);
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
            kryptonPalette1.PalettePaint += kryptonPalette1_PalettePaint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(92, 225, 230);
            textBox1.Location = new Point(157, 319);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(76, 28);
            textBox1.TabIndex = 5;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // loadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(390, 400);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer loadTimer;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private TextBox textBox1;
    }
}