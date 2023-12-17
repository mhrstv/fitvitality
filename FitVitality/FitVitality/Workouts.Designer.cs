namespace FitVitality
{
    partial class Workouts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workouts));
            leftCorner = new PictureBox();
            rightCorner = new PictureBox();
            vLine1 = new PictureBox();
            vLine2 = new PictureBox();
            hLine2 = new PictureBox();
            hLine1 = new PictureBox();
            workoutsLabel = new Label();
            trainPlacePanel = new Panel();
            nextButtonPanel1 = new Panel();
            nextButton1 = new Krypton.Toolkit.KryptonButton();
            outdoorsButton = new PictureBox();
            homeButton = new PictureBox();
            gymButton = new PictureBox();
            trainPlaceLabel = new Label();
            trainPlaceBorders = new PictureBox();
            muscleGroupsPanel = new Panel();
            panel2 = new Panel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            muscleGroupsLabel = new Label();
            muscleGroupsBorders = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            trainPlacePanel.SuspendLayout();
            nextButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outdoorsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gymButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainPlaceBorders).BeginInit();
            muscleGroupsPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)muscleGroupsBorders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // leftCorner
            // 
            leftCorner.Image = Properties.Resources.leftC;
            leftCorner.Location = new Point(0, 354);
            leftCorner.Name = "leftCorner";
            leftCorner.Size = new Size(16, 15);
            leftCorner.TabIndex = 19;
            leftCorner.TabStop = false;
            leftCorner.Click += pictureBox8_Click;
            // 
            // rightCorner
            // 
            rightCorner.Image = Properties.Resources.rightC;
            rightCorner.Location = new Point(675, 354);
            rightCorner.Name = "rightCorner";
            rightCorner.Size = new Size(16, 15);
            rightCorner.TabIndex = 17;
            rightCorner.TabStop = false;
            rightCorner.Click += pictureBox6_Click;
            // 
            // vLine1
            // 
            vLine1.Image = (Image)resources.GetObject("vLine1.Image");
            vLine1.Location = new Point(0, -1);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 355);
            vLine1.TabIndex = 16;
            vLine1.TabStop = false;
            vLine1.Click += pictureBox5_Click;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(689, 0);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 357);
            vLine2.TabIndex = 15;
            vLine2.TabStop = false;
            vLine2.Click += pictureBox4_Click;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 367);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(667, 1);
            hLine2.TabIndex = 14;
            hLine2.TabStop = false;
            hLine2.Click += pictureBox3_Click;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 1);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(664, 1);
            hLine1.TabIndex = 13;
            hLine1.TabStop = false;
            hLine1.Click += pictureBox2_Click;
            // 
            // workoutsLabel
            // 
            workoutsLabel.AutoSize = true;
            workoutsLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            workoutsLabel.Location = new Point(291, 22);
            workoutsLabel.Name = "workoutsLabel";
            workoutsLabel.Size = new Size(108, 24);
            workoutsLabel.TabIndex = 20;
            workoutsLabel.Text = "Workouts";
            // 
            // trainPlacePanel
            // 
            trainPlacePanel.Controls.Add(nextButtonPanel1);
            trainPlacePanel.Controls.Add(outdoorsButton);
            trainPlacePanel.Controls.Add(homeButton);
            trainPlacePanel.Controls.Add(gymButton);
            trainPlacePanel.Controls.Add(trainPlaceLabel);
            trainPlacePanel.Controls.Add(trainPlaceBorders);
            trainPlacePanel.Location = new Point(86, 70);
            trainPlacePanel.Name = "trainPlacePanel";
            trainPlacePanel.Size = new Size(518, 262);
            trainPlacePanel.TabIndex = 24;
            // 
            // nextButtonPanel1
            // 
            nextButtonPanel1.BackColor = Color.WhiteSmoke;
            nextButtonPanel1.Controls.Add(nextButton1);
            nextButtonPanel1.Location = new Point(214, 221);
            nextButtonPanel1.Name = "nextButtonPanel1";
            nextButtonPanel1.Size = new Size(90, 25);
            nextButtonPanel1.TabIndex = 32;
            // 
            // nextButton1
            // 
            nextButton1.CornerRoundingRadius = 15F;
            nextButton1.Location = new Point(0, 0);
            nextButton1.Name = "nextButton1";
            nextButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            nextButton1.Size = new Size(90, 25);
            nextButton1.StateCommon.Back.Color1 = Color.FromArgb(92, 225, 230);
            nextButton1.StateCommon.Back.Color2 = Color.FromArgb(92, 225, 230);
            nextButton1.StateCommon.Back.ColorAngle = 45F;
            nextButton1.StateCommon.Border.Color1 = Color.FromArgb(92, 225, 230);
            nextButton1.StateCommon.Border.Color2 = Color.FromArgb(92, 225, 230);
            nextButton1.StateCommon.Border.ColorAngle = 45F;
            nextButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nextButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StateCommon.Border.Rounding = 15F;
            nextButton1.StateCommon.Border.Width = 1;
            nextButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            nextButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            nextButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton1.StateDisabled.Back.Color1 = Color.FromArgb(92, 225, 230);
            nextButton1.StateDisabled.Back.Color2 = Color.FromArgb(92, 225, 230);
            nextButton1.StateDisabled.Border.Color1 = Color.FromArgb(92, 225, 230);
            nextButton1.StateDisabled.Border.Color2 = Color.FromArgb(92, 225, 230);
            nextButton1.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nextButton1.StateNormal.Back.Color1 = Color.FromArgb(92, 225, 230);
            nextButton1.StateNormal.Back.Color2 = Color.FromArgb(92, 225, 230);
            nextButton1.StateNormal.Back.ColorAngle = 45F;
            nextButton1.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StateNormal.Border.Color1 = Color.FromArgb(92, 225, 230);
            nextButton1.StateNormal.Border.Color2 = Color.FromArgb(92, 225, 230);
            nextButton1.StateNormal.Border.ColorAngle = 45F;
            nextButton1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nextButton1.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StateNormal.Border.Rounding = 15F;
            nextButton1.StateNormal.Border.Width = 1;
            nextButton1.StatePressed.Back.Color1 = Color.FromArgb(0, 160, 192);
            nextButton1.StatePressed.Back.Color2 = Color.FromArgb(0, 160, 192);
            nextButton1.StatePressed.Back.ColorAngle = 45F;
            nextButton1.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StatePressed.Border.Color1 = Color.FromArgb(0, 160, 192);
            nextButton1.StatePressed.Border.Color2 = Color.FromArgb(0, 160, 192);
            nextButton1.StatePressed.Border.ColorAngle = 45F;
            nextButton1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nextButton1.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StatePressed.Border.Rounding = 15F;
            nextButton1.StatePressed.Border.Width = 1;
            nextButton1.StateTracking.Back.Color1 = Color.FromArgb(161, 234, 230);
            nextButton1.StateTracking.Back.Color2 = Color.FromArgb(161, 234, 230);
            nextButton1.StateTracking.Back.ColorAngle = 45F;
            nextButton1.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StateTracking.Border.Color1 = Color.FromArgb(161, 234, 230);
            nextButton1.StateTracking.Border.Color2 = Color.FromArgb(161, 234, 230);
            nextButton1.StateTracking.Border.ColorAngle = 45F;
            nextButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            nextButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            nextButton1.StateTracking.Border.Rounding = 15F;
            nextButton1.StateTracking.Border.Width = 1;
            nextButton1.TabIndex = 31;
            nextButton1.Values.Text = "Next ->";
            nextButton1.Visible = false;
            nextButton1.Click += nextButton1_Click;
            // 
            // outdoorsButton
            // 
            outdoorsButton.Image = Properties.Resources.outdoors;
            outdoorsButton.Location = new Point(300, 161);
            outdoorsButton.Name = "outdoorsButton";
            outdoorsButton.Size = new Size(83, 37);
            outdoorsButton.TabIndex = 4;
            outdoorsButton.TabStop = false;
            outdoorsButton.Click += outdoorsButton_Click;
            outdoorsButton.MouseEnter += outdoorsButton_MouseEnter;
            outdoorsButton.MouseLeave += outdoorsButton_MouseLeave;
            // 
            // homeButton
            // 
            homeButton.Image = Properties.Resources.home1;
            homeButton.Location = new Point(218, 161);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(83, 37);
            homeButton.TabIndex = 3;
            homeButton.TabStop = false;
            homeButton.Click += homeButton_Click;
            homeButton.MouseEnter += homeButton_MouseEnter;
            homeButton.MouseLeave += homeButton_MouseLeave;
            // 
            // gymButton
            // 
            gymButton.Image = Properties.Resources.gym;
            gymButton.Location = new Point(136, 161);
            gymButton.Name = "gymButton";
            gymButton.Size = new Size(83, 37);
            gymButton.TabIndex = 2;
            gymButton.TabStop = false;
            gymButton.Click += gymButton_Click;
            gymButton.MouseEnter += gymButton_MouseEnter;
            gymButton.MouseLeave += gymButton_MouseLeave;
            // 
            // trainPlaceLabel
            // 
            trainPlaceLabel.AutoSize = true;
            trainPlaceLabel.BackColor = Color.FromArgb(242, 242, 242);
            trainPlaceLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            trainPlaceLabel.ForeColor = SystemColors.ControlText;
            trainPlaceLabel.Location = new Point(64, 31);
            trainPlaceLabel.Name = "trainPlaceLabel";
            trainPlaceLabel.Size = new Size(399, 46);
            trainPlaceLabel.TabIndex = 1;
            trainPlaceLabel.Text = "Zdraveite zobadjii tuk shte pravite svoite trenirovki\r\nKude shte trenirate";
            // 
            // trainPlaceBorders
            // 
            trainPlaceBorders.Image = (Image)resources.GetObject("trainPlaceBorders.Image");
            trainPlaceBorders.Location = new Point(0, 0);
            trainPlaceBorders.Name = "trainPlaceBorders";
            trainPlaceBorders.Size = new Size(518, 262);
            trainPlaceBorders.TabIndex = 0;
            trainPlaceBorders.TabStop = false;
            // 
            // muscleGroupsPanel
            // 
            muscleGroupsPanel.Controls.Add(pictureBox5);
            muscleGroupsPanel.Controls.Add(pictureBox4);
            muscleGroupsPanel.Controls.Add(pictureBox3);
            muscleGroupsPanel.Controls.Add(pictureBox2);
            muscleGroupsPanel.Controls.Add(pictureBox1);
            muscleGroupsPanel.Controls.Add(label2);
            muscleGroupsPanel.Controls.Add(panel2);
            muscleGroupsPanel.Controls.Add(muscleGroupsLabel);
            muscleGroupsPanel.Controls.Add(muscleGroupsBorders);
            muscleGroupsPanel.Location = new Point(86, 70);
            muscleGroupsPanel.Name = "muscleGroupsPanel";
            muscleGroupsPanel.Size = new Size(518, 262);
            muscleGroupsPanel.TabIndex = 33;
            muscleGroupsPanel.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(kryptonButton1);
            panel2.Location = new Point(214, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(90, 25);
            panel2.TabIndex = 32;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 15F;
            kryptonButton1.Location = new Point(0, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(90, 25);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 15F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonButton1.StateDisabled.Back.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateDisabled.Back.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateDisabled.Border.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateDisabled.Border.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateNormal.Back.ColorAngle = 45F;
            kryptonButton1.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateNormal.Border.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateNormal.Border.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateNormal.Border.ColorAngle = 45F;
            kryptonButton1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateNormal.Border.Rounding = 15F;
            kryptonButton1.StateNormal.Border.Width = 1;
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(0, 160, 192);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(0, 160, 192);
            kryptonButton1.StatePressed.Back.ColorAngle = 45F;
            kryptonButton1.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(0, 160, 192);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(0, 160, 192);
            kryptonButton1.StatePressed.Border.ColorAngle = 45F;
            kryptonButton1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StatePressed.Border.Rounding = 15F;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(161, 234, 230);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(161, 234, 230);
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(161, 234, 230);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(161, 234, 230);
            kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Rounding = 15F;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 31;
            kryptonButton1.Values.Text = "Next ->";
            kryptonButton1.Visible = false;
            // 
            // muscleGroupsLabel
            // 
            muscleGroupsLabel.AutoSize = true;
            muscleGroupsLabel.BackColor = Color.FromArgb(242, 242, 242);
            muscleGroupsLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            muscleGroupsLabel.ForeColor = SystemColors.ControlText;
            muscleGroupsLabel.Location = new Point(32, 15);
            muscleGroupsLabel.Name = "muscleGroupsLabel";
            muscleGroupsLabel.Size = new Size(330, 38);
            muscleGroupsLabel.TabIndex = 1;
            muscleGroupsLabel.Text = "V sledvashtite tri stupki shte izbirate muskulite ot\r\ndadenata muskulna grupa";
            // 
            // muscleGroupsBorders
            // 
            muscleGroupsBorders.Image = (Image)resources.GetObject("muscleGroupsBorders.Image");
            muscleGroupsBorders.Location = new Point(0, 0);
            muscleGroupsBorders.Name = "muscleGroupsBorders";
            muscleGroupsBorders.Size = new Size(518, 262);
            muscleGroupsBorders.TabIndex = 0;
            muscleGroupsBorders.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(218, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 34;
            label2.Text = "Gorna chast";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(118, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 83);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(205, 89);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(104, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            // 
            // Workouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(muscleGroupsPanel);
            Controls.Add(trainPlacePanel);
            Controls.Add(workoutsLabel);
            Controls.Add(leftCorner);
            Controls.Add(rightCorner);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Workouts";
            Text = " ";
            Load += Workouts_Load;
            ((System.ComponentModel.ISupportInitialize)leftCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            trainPlacePanel.ResumeLayout(false);
            trainPlacePanel.PerformLayout();
            nextButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)outdoorsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)gymButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainPlaceBorders).EndInit();
            muscleGroupsPanel.ResumeLayout(false);
            muscleGroupsPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)muscleGroupsBorders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox leftCorner;
        private PictureBox rightCorner;
        private PictureBox vLine1;
        private PictureBox vLine2;
        private PictureBox hLine2;
        private PictureBox hLine1;
        private Label workoutsLabel;
        private Panel trainPlacePanel;
        private Label trainPlaceLabel;
        private PictureBox trainPlaceBorders;
        private PictureBox outdoorsButton;
        private PictureBox homeButton;
        private PictureBox gymButton;
        private Krypton.Toolkit.KryptonButton nextButton1;
        private Panel nextButtonPanel1;
        private Panel muscleGroupsPanel;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label muscleGroupsLabel;
        private PictureBox muscleGroupsBorders;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
    }
}