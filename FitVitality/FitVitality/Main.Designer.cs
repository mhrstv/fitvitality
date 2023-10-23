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
            panel2 = new Panel();
            buttonWorkout = new Krypton.Toolkit.KryptonButton();
            buttonDashboard = new Krypton.Toolkit.KryptonButton();
            panel3 = new Panel();
            panel2.SuspendLayout();
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
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(11, -1, -1, -1);
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonWorkout);
            panel2.Controls.Add(buttonDashboard);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 46);
            panel2.TabIndex = 1;
            // 
            // buttonWorkout
            // 
            buttonWorkout.CornerRoundingRadius = 10F;
            buttonWorkout.Location = new Point(355, 3);
            buttonWorkout.Name = "buttonWorkout";
            buttonWorkout.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonWorkout.Size = new Size(39, 40);
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
            buttonDashboard.Location = new Point(296, 3);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonDashboard.Size = new Size(39, 40);
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
            panel3.Location = new Point(-9, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(707, 359);
            panel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(690, 400);
            Controls.Add(panel2);
            Controls.Add(panel3);
            CornerRoundingRadius = 15F;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel panel2;
        private Panel panel3;
        private Krypton.Toolkit.KryptonButton buttonDashboard;
        private Krypton.Toolkit.KryptonButton buttonWorkout;
    }
}