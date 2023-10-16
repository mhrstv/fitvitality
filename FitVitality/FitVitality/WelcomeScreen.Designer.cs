namespace FitVitality
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            label1 = new Label();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonPalette2 = new Krypton.Toolkit.KryptonPalette(components);
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormClose.AllowInheritToolTipTitle = false;
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.closebutton;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormMax.AllowInheritToolTipTitle = false;
            kryptonPalette1.ButtonSpecs.FormMax.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritExtraText = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritImage = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritText = false;
            kryptonPalette1.ButtonSpecs.FormMin.AllowInheritToolTipTitle = false;
            kryptonPalette1.ButtonSpecs.FormMin.Image = Properties.Resources.minimizebutton;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(92, 225, 230);
            label1.Location = new Point(277, 49);
            label1.Name = "label1";
            label1.Size = new Size(180, 55);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(268, 149);
            kryptonTextBox1.MaxLength = 16;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(199, 23);
            kryptonTextBox1.TabIndex = 1;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(268, 211);
            kryptonTextBox2.MaxLength = 32;
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.PasswordChar = '●';
            kryptonTextBox2.Size = new Size(199, 23);
            kryptonTextBox2.TabIndex = 2;
            kryptonTextBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(268, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 14);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(268, 194);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(150, 208, 250);
            label4.Location = new Point(277, 246);
            label4.Name = "label4";
            label4.Size = new Size(69, 14);
            label4.TabIndex = 6;
            label4.Text = "New user?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(150, 208, 250);
            label5.Location = new Point(345, 246);
            label5.Name = "label5";
            label5.Size = new Size(112, 14);
            label5.TabIndex = 7;
            label5.Text = "Create an account";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(322, 277);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Palette = kryptonPalette2;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton1.Size = new Size(90, 25);
            kryptonButton1.TabIndex = 8;
            kryptonButton1.Values.Text = "Login";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonPalette2
            // 
            kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette2.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = Color.FromArgb(92, 225, 230);
            kryptonPalette2.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = Color.FromArgb(152, 225, 230);
            kryptonPalette2.ButtonStyles.ButtonStandalone.StateNormal.Content.LongText.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette2.ButtonStyles.ButtonStandalone.StateNormal.Content.LongText.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette2.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette2.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Color2 = Color.FromArgb(250, 252, 252);
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(734, 444);
            Controls.Add(kryptonButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(250, 252, 252);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WelcomeScreen";
            Opacity = 0D;
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosed += WelcomeScreen_FormClosed;
            Load += WelcomeScreen_Load;
            Shown += WelcomeScreen_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette2;
    }
}