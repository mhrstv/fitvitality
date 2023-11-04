namespace FitVitality
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            loginLabel = new Label();
            textBoxUsername = new Krypton.Toolkit.KryptonTextBox();
            textBoxPassword = new Krypton.Toolkit.KryptonTextBox();
            usernameLabel = new Label();
            labelPassword = new Label();
            newUserLabel = new Label();
            createAccButton = new Label();
            loginButton = new Krypton.Toolkit.KryptonButton();
            topbar = new Panel();
            logo2 = new PictureBox();
            logo1 = new PictureBox();
            buttonMin = new PictureBox();
            buttonClose = new PictureBox();
            rememberMe = new CheckBox();
            loginFail = new Label();
            errorPanel = new Panel();
            pictureBox5 = new PictureBox();
            timerError = new System.Windows.Forms.Timer(components);
            usrmark = new PictureBox();
            passmark = new PictureBox();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            errorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usrmark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passmark).BeginInit();
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
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(92, 225, 230);
            loginLabel.Location = new Point(68, 67);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(151, 46);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "LOGIN";
            // 
            // textBoxUsername
            // 
            textBoxUsername.CueHint.CueHintText = "Enter username";
            textBoxUsername.CueHint.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.CueHint.Padding = new Padding(0);
            textBoxUsername.Location = new Point(44, 191);
            textBoxUsername.MaxLength = 16;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(199, 23);
            textBoxUsername.TabIndex = 7;
            textBoxUsername.TextChanged += kryptonTextBox1_TextChanged;
            textBoxUsername.KeyDown += kryptonTextBox1_KeyDown;
            // 
            // textBoxPassword
            // 
            textBoxPassword.CueHint.CueHintText = "Enter password";
            textBoxPassword.CueHint.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.CueHint.Padding = new Padding(0);
            textBoxPassword.Location = new Point(44, 253);
            textBoxPassword.MaxLength = 32;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(199, 23);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyDown += kryptonTextBox2_KeyDown;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(44, 173);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(67, 14);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(44, 236);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 14);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // newUserLabel
            // 
            newUserLabel.AutoSize = true;
            newUserLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newUserLabel.ForeColor = Color.FromArgb(150, 208, 250);
            newUserLabel.Location = new Point(53, 343);
            newUserLabel.Name = "newUserLabel";
            newUserLabel.Size = new Size(69, 14);
            newUserLabel.TabIndex = 6;
            newUserLabel.Text = "New user?";
            // 
            // createAccButton
            // 
            createAccButton.AutoSize = true;
            createAccButton.Cursor = Cursors.Hand;
            createAccButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            createAccButton.ForeColor = Color.FromArgb(150, 208, 250);
            createAccButton.Location = new Point(121, 343);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(112, 14);
            createAccButton.TabIndex = 6;
            createAccButton.Text = "Create an account";
            createAccButton.Click += label5_Click;
            // 
            // loginButton
            // 
            loginButton.CornerRoundingRadius = 15F;
            loginButton.Location = new Point(99, 306);
            loginButton.Name = "loginButton";
            loginButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            loginButton.Size = new Size(90, 25);
            loginButton.StateCommon.Back.Color1 = Color.FromArgb(90, 220, 225);
            loginButton.StateCommon.Back.Color2 = Color.FromArgb(94, 229, 235);
            loginButton.StateCommon.Back.ColorAngle = 0F;
            loginButton.StateCommon.Border.Color1 = Color.FromArgb(90, 220, 225);
            loginButton.StateCommon.Border.Color2 = Color.FromArgb(94, 229, 235);
            loginButton.StateCommon.Border.ColorAngle = 0F;
            loginButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StateCommon.Border.Rounding = 15F;
            loginButton.StateCommon.Border.Width = 1;
            loginButton.StateCommon.Content.ShortText.Color1 = Color.White;
            loginButton.StateCommon.Content.ShortText.Color2 = Color.White;
            loginButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.StateDisabled.Back.Color1 = Color.FromArgb(92, 225, 230);
            loginButton.StateDisabled.Back.Color2 = Color.FromArgb(92, 225, 230);
            loginButton.StateDisabled.Back.ColorAngle = 45F;
            loginButton.StateDisabled.Border.Color1 = Color.FromArgb(92, 225, 230);
            loginButton.StateDisabled.Border.Color2 = Color.FromArgb(92, 225, 230);
            loginButton.StateDisabled.Border.ColorAngle = 45F;
            loginButton.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StateDisabled.Border.Rounding = 15F;
            loginButton.StateDisabled.Border.Width = 1;
            loginButton.StateDisabled.Content.ShortText.Color1 = Color.White;
            loginButton.StateDisabled.Content.ShortText.Color2 = Color.White;
            loginButton.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.StateNormal.Back.Color1 = Color.FromArgb(92, 225, 230);
            loginButton.StateNormal.Back.Color2 = Color.FromArgb(92, 225, 230);
            loginButton.StateNormal.Back.ColorAngle = 0F;
            loginButton.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StateNormal.Border.Color1 = Color.FromArgb(92, 225, 230);
            loginButton.StateNormal.Border.Color2 = Color.FromArgb(92, 225, 230);
            loginButton.StateNormal.Border.ColorAngle = 0F;
            loginButton.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StateNormal.Border.Rounding = 15F;
            loginButton.StateNormal.Border.Width = 1;
            loginButton.StatePressed.Back.Color1 = Color.FromArgb(0, 160, 192);
            loginButton.StatePressed.Back.Color2 = Color.FromArgb(0, 160, 192);
            loginButton.StatePressed.Back.ColorAngle = 45F;
            loginButton.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StatePressed.Border.Color1 = Color.FromArgb(0, 160, 192);
            loginButton.StatePressed.Border.Color2 = Color.FromArgb(0, 160, 192);
            loginButton.StatePressed.Border.ColorAngle = 45F;
            loginButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StatePressed.Border.Rounding = 15F;
            loginButton.StatePressed.Border.Width = 1;
            loginButton.StateTracking.Back.Color1 = Color.FromArgb(161, 234, 230);
            loginButton.StateTracking.Back.Color2 = Color.FromArgb(161, 234, 230);
            loginButton.StateTracking.Back.ColorAngle = 45F;
            loginButton.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StateTracking.Border.Color1 = Color.FromArgb(161, 234, 230);
            loginButton.StateTracking.Border.Color2 = Color.FromArgb(161, 234, 230);
            loginButton.StateTracking.Border.ColorAngle = 45F;
            loginButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            loginButton.StateTracking.Border.Rounding = 15F;
            loginButton.StateTracking.Border.Width = 1;
            loginButton.TabIndex = 9;
            loginButton.Values.Text = "Login";
            loginButton.Click += kryptonButton1_Click;
            loginButton.MouseLeave += kryptonButton1_MouseLeave;
            // 
            // topbar
            // 
            topbar.Controls.Add(logo2);
            topbar.Controls.Add(logo1);
            topbar.Controls.Add(buttonMin);
            topbar.Controls.Add(buttonClose);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(287, 32);
            topbar.TabIndex = 1;
            topbar.Paint += panel1_Paint;
            topbar.MouseDown += panel1_MouseDown;
            topbar.MouseMove += panel1_MouseMove;
            topbar.MouseUp += panel1_MouseUp;
            // 
            // logo2
            // 
            logo2.Image = (Image)resources.GetObject("logo2.Image");
            logo2.Location = new Point(44, 9);
            logo2.Name = "logo2";
            logo2.Size = new Size(66, 20);
            logo2.SizeMode = PictureBoxSizeMode.Zoom;
            logo2.TabIndex = 1;
            logo2.TabStop = false;
            // 
            // logo1
            // 
            logo1.Image = (Image)resources.GetObject("logo1.Image");
            logo1.Location = new Point(12, 8);
            logo1.Name = "logo1";
            logo1.Size = new Size(26, 24);
            logo1.SizeMode = PictureBoxSizeMode.Zoom;
            logo1.TabIndex = 1;
            logo1.TabStop = false;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.White;
            buttonMin.Image = (Image)resources.GetObject("buttonMin.Image");
            buttonMin.Location = new Point(232, 7);
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
            buttonClose.Location = new Point(257, 7);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(19, 19);
            buttonClose.SizeMode = PictureBoxSizeMode.Zoom;
            buttonClose.TabIndex = 1;
            buttonClose.TabStop = false;
            buttonClose.Click += pictureBox1_Click;
            buttonClose.MouseEnter += pictureBox1_MouseEnter;
            buttonClose.MouseLeave += pictureBox1_MouseLeave;
            buttonClose.MouseHover += pictureBox1_MouseHover;
            // 
            // rememberMe
            // 
            rememberMe.AutoSize = true;
            rememberMe.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rememberMe.ForeColor = Color.Black;
            rememberMe.Location = new Point(44, 282);
            rememberMe.Name = "rememberMe";
            rememberMe.Size = new Size(99, 18);
            rememberMe.TabIndex = 5;
            rememberMe.TabStop = false;
            rememberMe.Text = "Remember me";
            rememberMe.UseVisualStyleBackColor = true;
            rememberMe.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginFail
            // 
            loginFail.AutoSize = true;
            loginFail.BackColor = Color.FromArgb(255, 0, 43);
            loginFail.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginFail.ForeColor = Color.White;
            loginFail.Location = new Point(5, 9);
            loginFail.Name = "loginFail";
            loginFail.Size = new Size(188, 15);
            loginFail.TabIndex = 10;
            loginFail.Text = "Incorrect username or password!";
            // 
            // errorPanel
            // 
            errorPanel.Controls.Add(loginFail);
            errorPanel.Controls.Add(pictureBox5);
            errorPanel.Location = new Point(44, 131);
            errorPanel.Name = "errorPanel";
            errorPanel.Size = new Size(199, 0);
            errorPanel.TabIndex = 11;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(199, 33);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // timerError
            // 
            timerError.Interval = 15;
            timerError.Tick += timer1_Tick;
            // 
            // usrmark
            // 
            usrmark.Image = (Image)resources.GetObject("usrmark.Image");
            usrmark.Location = new Point(217, 192);
            usrmark.Name = "usrmark";
            usrmark.Size = new Size(24, 21);
            usrmark.SizeMode = PictureBoxSizeMode.Zoom;
            usrmark.TabIndex = 20;
            usrmark.TabStop = false;
            usrmark.Visible = false;
            // 
            // passmark
            // 
            passmark.Image = (Image)resources.GetObject("passmark.Image");
            passmark.Location = new Point(217, 254);
            passmark.Name = "passmark";
            passmark.Size = new Size(24, 21);
            passmark.SizeMode = PictureBoxSizeMode.Zoom;
            passmark.TabIndex = 21;
            passmark.TabStop = false;
            passmark.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(287, 415);
            Controls.Add(errorPanel);
            Controls.Add(passmark);
            Controls.Add(usrmark);
            Controls.Add(loginButton);
            Controls.Add(rememberMe);
            Controls.Add(topbar);
            Controls.Add(createAccButton);
            Controls.Add(newUserLabel);
            Controls.Add(labelPassword);
            Controls.Add(usernameLabel);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(loginLabel);
            ForeColor = Color.FromArgb(250, 252, 252);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Opacity = 0D;
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FitVitality";
            FormClosing += Login_FormClosing;
            FormClosed += WelcomeScreen_FormClosed;
            Load += WelcomeScreen_Load;
            Shown += WelcomeScreen_Shown;
            MouseHover += WelcomeScreen_MouseHover;
            topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).EndInit();
            errorPanel.ResumeLayout(false);
            errorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)usrmark).EndInit();
            ((System.ComponentModel.ISupportInitialize)passmark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label loginLabel;
        private Krypton.Toolkit.KryptonTextBox textBoxUsername;
        private Krypton.Toolkit.KryptonTextBox textBoxPassword;
        private Label usernameLabel;
        private Label labelPassword;
        private Label newUserLabel;
        private Label createAccButton;
        private Krypton.Toolkit.KryptonButton loginButton;
        private Panel topbar;
        private PictureBox logo2;
        private PictureBox logo1;
        private PictureBox buttonMin;
        private PictureBox buttonClose;
        private CheckBox rememberMe;
        private Label loginFail;
        private Panel errorPanel;
        private System.Windows.Forms.Timer timerError;
        private PictureBox pictureBox5;
        private PictureBox usrmark;
        private PictureBox passmark;
    }
}