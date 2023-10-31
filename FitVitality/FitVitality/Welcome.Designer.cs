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
            name = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            age = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            gender = new Panel();
            kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            label3 = new Label();
            weight = new Panel();
            kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            label4 = new Label();
            height = new Panel();
            goal = new Panel();
            kryptonThemeComboBox2 = new Krypton.Toolkit.KryptonThemeComboBox();
            label6 = new Label();
            kryptonNumericUpDown2 = new Krypton.Toolkit.KryptonNumericUpDown();
            label5 = new Label();
            activity = new Panel();
            kryptonThemeComboBox3 = new Krypton.Toolkit.KryptonThemeComboBox();
            label7 = new Label();
            buttonNext = new PictureBox();
            buttonPrevious = new PictureBox();
            labelWelcome = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonClose).BeginInit();
            name.SuspendLayout();
            age.SuspendLayout();
            gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).BeginInit();
            weight.SuspendLayout();
            height.SuspendLayout();
            goal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox2).BeginInit();
            activity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonPrevious).BeginInit();
            panel1.SuspendLayout();
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
            // name
            // 
            name.Controls.Add(label1);
            name.Controls.Add(textBox1);
            name.Location = new Point(75, 50);
            name.Name = "name";
            name.Size = new Size(540, 300);
            name.TabIndex = 21;
            name.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(217, 108);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter your name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // age
            // 
            age.Controls.Add(label2);
            age.Controls.Add(textBox2);
            age.Location = new Point(75, 50);
            age.Name = "age";
            age.Size = new Size(540, 300);
            age.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(228, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter your age";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // gender
            // 
            gender.Controls.Add(kryptonThemeComboBox1);
            gender.Controls.Add(label3);
            gender.Location = new Point(0, 0);
            gender.Name = "gender";
            gender.Size = new Size(540, 300);
            gender.TabIndex = 22;
            // 
            // kryptonThemeComboBox1
            // 
            kryptonThemeComboBox1.CornerRoundingRadius = -1F;
            kryptonThemeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            kryptonThemeComboBox1.DropDownWidth = 121;
            kryptonThemeComboBox1.IntegralHeight = false;
            kryptonThemeComboBox1.Items.AddRange(new object[] { "Male", "Female" });
            kryptonThemeComboBox1.Location = new Point(212, 143);
            kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            kryptonThemeComboBox1.Size = new Size(121, 21);
            kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(218, 122);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 1;
            label3.Text = "Whats your gender";
            label3.Click += label3_Click;
            // 
            // weight
            // 
            weight.Controls.Add(kryptonNumericUpDown1);
            weight.Controls.Add(label4);
            weight.Location = new Point(75, 50);
            weight.Name = "weight";
            weight.Size = new Size(540, 300);
            weight.TabIndex = 22;
            // 
            // kryptonNumericUpDown1
            // 
            kryptonNumericUpDown1.Location = new Point(204, 143);
            kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            kryptonNumericUpDown1.Size = new Size(120, 22);
            kryptonNumericUpDown1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(194, 108);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 1;
            label4.Text = "how much do you weigh";
            // 
            // height
            // 
            height.Controls.Add(goal);
            height.Controls.Add(kryptonNumericUpDown2);
            height.Controls.Add(label5);
            height.Location = new Point(75, 50);
            height.Name = "height";
            height.Size = new Size(540, 300);
            height.TabIndex = 23;
            // 
            // goal
            // 
            goal.Controls.Add(gender);
            goal.Controls.Add(kryptonThemeComboBox2);
            goal.Controls.Add(label6);
            goal.Location = new Point(0, 0);
            goal.Name = "goal";
            goal.Size = new Size(540, 300);
            goal.TabIndex = 23;
            // 
            // kryptonThemeComboBox2
            // 
            kryptonThemeComboBox2.CornerRoundingRadius = -1F;
            kryptonThemeComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            kryptonThemeComboBox2.DropDownWidth = 121;
            kryptonThemeComboBox2.IntegralHeight = false;
            kryptonThemeComboBox2.Items.AddRange(new object[] { "Cut weight", "Gain weight", "Maintain weight" });
            kryptonThemeComboBox2.Location = new Point(204, 126);
            kryptonThemeComboBox2.Name = "kryptonThemeComboBox2";
            kryptonThemeComboBox2.Size = new Size(121, 21);
            kryptonThemeComboBox2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(214, 93);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 1;
            label6.Text = "what is your goal";
            // 
            // kryptonNumericUpDown2
            // 
            kryptonNumericUpDown2.Location = new Point(204, 143);
            kryptonNumericUpDown2.Name = "kryptonNumericUpDown2";
            kryptonNumericUpDown2.Size = new Size(120, 22);
            kryptonNumericUpDown2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(212, 108);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 1;
            label5.Text = "how tall are you";
            // 
            // activity
            // 
            activity.Controls.Add(kryptonThemeComboBox3);
            activity.Controls.Add(label7);
            activity.Location = new Point(76, 50);
            activity.Name = "activity";
            activity.Size = new Size(538, 300);
            activity.TabIndex = 24;
            // 
            // kryptonThemeComboBox3
            // 
            kryptonThemeComboBox3.CornerRoundingRadius = -1F;
            kryptonThemeComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            kryptonThemeComboBox3.DropDownWidth = 121;
            kryptonThemeComboBox3.IntegralHeight = false;
            kryptonThemeComboBox3.Items.AddRange(new object[] { "Lightly active", "Active", "Very active" });
            kryptonThemeComboBox3.Location = new Point(204, 126);
            kryptonThemeComboBox3.Name = "kryptonThemeComboBox3";
            kryptonThemeComboBox3.Size = new Size(121, 21);
            kryptonThemeComboBox3.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(194, 93);
            label7.Name = "label7";
            label7.Size = new Size(139, 15);
            label7.TabIndex = 1;
            label7.Text = "what is your activity level";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(624, 154);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(58, 92);
            buttonNext.TabIndex = 27;
            buttonNext.TabStop = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(8, 154);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(58, 92);
            buttonPrevious.TabIndex = 28;
            buttonPrevious.TabStop = false;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.ForeColor = Color.FromArgb(250, 252, 252);
            labelWelcome.Location = new Point(0, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(609, 133);
            labelWelcome.TabIndex = 3;
            labelWelcome.Text = "Welcome!";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelWelcome);
            panel1.Location = new Point(41, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 133);
            panel1.TabIndex = 29;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 41, 46);
            ClientSize = new Size(690, 400);
            Controls.Add(panel1);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonNext);
            Controls.Add(height);
            Controls.Add(weight);
            Controls.Add(age);
            Controls.Add(activity);
            Controls.Add(name);
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
            name.ResumeLayout(false);
            name.PerformLayout();
            age.ResumeLayout(false);
            age.PerformLayout();
            gender.ResumeLayout(false);
            gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).EndInit();
            weight.ResumeLayout(false);
            weight.PerformLayout();
            height.ResumeLayout(false);
            height.PerformLayout();
            goal.ResumeLayout(false);
            goal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox2).EndInit();
            activity.ResumeLayout(false);
            activity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonPrevious).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel topbar;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox buttonMin;
        private PictureBox buttonClose;
        private Panel name;
        private TextBox textBox1;
        private Panel age;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Panel gender;
        private Panel weight;
        private Label label4;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Label label3;
        private Panel height;
        private Panel goal;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox2;
        private Label label6;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown2;
        private Label label5;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private Panel activity;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox3;
        private Label label7;
        private PictureBox buttonNext;
        private PictureBox buttonPrevious;
        private Label labelWelcome;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
    }
}