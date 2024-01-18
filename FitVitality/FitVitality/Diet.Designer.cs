namespace FitVitality
{
    partial class Diet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diet));
            leftC = new PictureBox();
            rightC = new PictureBox();
            vLine1 = new PictureBox();
            vLine2 = new PictureBox();
            hLine2 = new PictureBox();
            hLine1 = new PictureBox();
            dietLabel = new Label();
            dietBorder2 = new PictureBox();
            dietBorder1 = new PictureBox();
            dailyGoalLabel = new Label();
            addFoodLabel = new Label();
            calorieIntake = new Label();
            carbohydrates = new Label();
            fat = new Label();
            protein = new Label();
            macroАbbreviation = new Label();
            manageGoalDescription = new Label();
            manageGoalLabel = new Label();
            activityComboBoxMacro = new Krypton.Toolkit.KryptonComboBox();
            activityLevelLabel = new Label();
            balancedButton = new PictureBox();
            highProteinButton = new PictureBox();
            lowCarbsButton = new PictureBox();
            lowFatButton = new PictureBox();
            kCalLabel = new Label();
            cLabel = new Label();
            pLabel = new Label();
            fLabel = new Label();
            foodPanel = new FlowLayoutPanel();
            searchTextBox = new Krypton.Toolkit.KryptonTextBox();
            searchIcon = new PictureBox();
            searchPanel = new FlowLayoutPanel();
            hintLabel = new Label();
            hiddenPanel1 = new Panel();
            label1 = new Label();
            hiddenPanel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)leftC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dietBorder2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dietBorder1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityComboBoxMacro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balancedButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)highProteinButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowCarbsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowFatButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            hiddenPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftC
            // 
            leftC.Image = Properties.Resources.leftC;
            leftC.Location = new Point(0, 354);
            leftC.Name = "leftC";
            leftC.Size = new Size(16, 15);
            leftC.TabIndex = 19;
            leftC.TabStop = false;
            // 
            // rightC
            // 
            rightC.Image = Properties.Resources.rightC;
            rightC.Location = new Point(675, 354);
            rightC.Name = "rightC";
            rightC.Size = new Size(16, 15);
            rightC.TabIndex = 17;
            rightC.TabStop = false;
            // 
            // vLine1
            // 
            vLine1.Image = Properties.Resources.vline;
            vLine1.Location = new Point(0, -1);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 355);
            vLine1.TabIndex = 16;
            vLine1.TabStop = false;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(689, 0);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 357);
            vLine2.TabIndex = 15;
            vLine2.TabStop = false;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 367);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(667, 1);
            hLine2.TabIndex = 14;
            hLine2.TabStop = false;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 1);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(664, 1);
            hLine1.TabIndex = 13;
            hLine1.TabStop = false;
            // 
            // dietLabel
            // 
            dietLabel.AutoSize = true;
            dietLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dietLabel.Location = new Point(320, 12);
            dietLabel.Name = "dietLabel";
            dietLabel.Size = new Size(51, 24);
            dietLabel.TabIndex = 21;
            dietLabel.Text = "Diet";
            dietLabel.Click += dietLabel_Click;
            // 
            // dietBorder2
            // 
            dietBorder2.Image = Properties.Resources.vline;
            dietBorder2.Location = new Point(473, 49);
            dietBorder2.Name = "dietBorder2";
            dietBorder2.Size = new Size(1, 290);
            dietBorder2.TabIndex = 22;
            dietBorder2.TabStop = false;
            // 
            // dietBorder1
            // 
            dietBorder1.Image = Properties.Resources.vline;
            dietBorder1.Location = new Point(219, 49);
            dietBorder1.Name = "dietBorder1";
            dietBorder1.Size = new Size(1, 290);
            dietBorder1.TabIndex = 23;
            dietBorder1.TabStop = false;
            // 
            // dailyGoalLabel
            // 
            dailyGoalLabel.AutoSize = true;
            dailyGoalLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dailyGoalLabel.ForeColor = Color.FromArgb(92, 225, 230);
            dailyGoalLabel.Location = new Point(556, 53);
            dailyGoalLabel.Name = "dailyGoalLabel";
            dailyGoalLabel.Size = new Size(47, 38);
            dailyGoalLabel.TabIndex = 24;
            dailyGoalLabel.Text = "Daily \r\nGoal";
            dailyGoalLabel.TextAlign = ContentAlignment.MiddleCenter;
            dailyGoalLabel.Click += dailyGoalLabel_Click;
            // 
            // addFoodLabel
            // 
            addFoodLabel.AutoSize = true;
            addFoodLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addFoodLabel.ForeColor = Color.FromArgb(92, 225, 230);
            addFoodLabel.Location = new Point(297, 48);
            addFoodLabel.Name = "addFoodLabel";
            addFoodLabel.Size = new Size(96, 19);
            addFoodLabel.TabIndex = 26;
            addFoodLabel.Text = "Today's food";
            addFoodLabel.TextAlign = ContentAlignment.MiddleCenter;
            addFoodLabel.Click += addFoodLabel_Click;
            // 
            // calorieIntake
            // 
            calorieIntake.AutoSize = true;
            calorieIntake.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calorieIntake.ForeColor = Color.Black;
            calorieIntake.Location = new Point(548, 117);
            calorieIntake.Name = "calorieIntake";
            calorieIntake.Size = new Size(31, 19);
            calorieIntake.TabIndex = 27;
            calorieIntake.Text = "#/#";
            calorieIntake.TextAlign = ContentAlignment.MiddleCenter;
            calorieIntake.Visible = false;
            calorieIntake.Click += calorieIntake_Click;
            // 
            // carbohydrates
            // 
            carbohydrates.AutoSize = true;
            carbohydrates.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            carbohydrates.ForeColor = Color.Black;
            carbohydrates.Location = new Point(527, 155);
            carbohydrates.Name = "carbohydrates";
            carbohydrates.Size = new Size(31, 19);
            carbohydrates.TabIndex = 28;
            carbohydrates.Text = "#/#";
            carbohydrates.TextAlign = ContentAlignment.MiddleCenter;
            carbohydrates.Visible = false;
            carbohydrates.Click += carbohydrates_Click;
            // 
            // fat
            // 
            fat.AutoSize = true;
            fat.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fat.ForeColor = Color.Black;
            fat.Location = new Point(527, 238);
            fat.Name = "fat";
            fat.Size = new Size(31, 19);
            fat.TabIndex = 29;
            fat.Text = "#/#";
            fat.TextAlign = ContentAlignment.MiddleCenter;
            fat.Visible = false;
            fat.Click += fat_Click;
            // 
            // protein
            // 
            protein.AutoSize = true;
            protein.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            protein.ForeColor = Color.Black;
            protein.Location = new Point(527, 194);
            protein.Name = "protein";
            protein.Size = new Size(31, 19);
            protein.TabIndex = 30;
            protein.Text = "#/#";
            protein.TextAlign = ContentAlignment.MiddleCenter;
            protein.Visible = false;
            protein.Click += protein_Click;
            // 
            // macroАbbreviation
            // 
            macroАbbreviation.AutoSize = true;
            macroАbbreviation.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            macroАbbreviation.ForeColor = Color.Black;
            macroАbbreviation.Location = new Point(237, 344);
            macroАbbreviation.Name = "macroАbbreviation";
            macroАbbreviation.Size = new Size(216, 15);
            macroАbbreviation.TabIndex = 31;
            macroАbbreviation.Text = "C -  Carbohydrates, P - Protein, F - Fats";
            macroАbbreviation.TextAlign = ContentAlignment.MiddleCenter;
            macroАbbreviation.Click += macroАbbreviation_Click;
            // 
            // manageGoalDescription
            // 
            manageGoalDescription.AutoSize = true;
            manageGoalDescription.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            manageGoalDescription.Location = new Point(44, 256);
            manageGoalDescription.Name = "manageGoalDescription";
            manageGoalDescription.Size = new Size(159, 60);
            manageGoalDescription.TabIndex = 38;
            manageGoalDescription.Text = "In this section you enter your \r\ngoal and activity depending \r\non your busyness and dream\r\nphysique.";
            manageGoalDescription.Click += manageGoalDescription_Click;
            // 
            // manageGoalLabel
            // 
            manageGoalLabel.AutoSize = true;
            manageGoalLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            manageGoalLabel.ForeColor = Color.FromArgb(92, 225, 230);
            manageGoalLabel.Location = new Point(76, 53);
            manageGoalLabel.Name = "manageGoalLabel";
            manageGoalLabel.Size = new Size(68, 38);
            manageGoalLabel.TabIndex = 39;
            manageGoalLabel.Text = "Manage \r\nGoal";
            manageGoalLabel.TextAlign = ContentAlignment.MiddleCenter;
            manageGoalLabel.Click += manageGoalLabel_Click;
            // 
            // activityComboBoxMacro
            // 
            activityComboBoxMacro.CornerRoundingRadius = -1F;
            activityComboBoxMacro.DropDownWidth = 121;
            activityComboBoxMacro.IntegralHeight = false;
            activityComboBoxMacro.Items.AddRange(new object[] { "Sedentary", "Light", "Moderate", "Active", "Very active", "Extra active" });
            activityComboBoxMacro.Location = new Point(113, 130);
            activityComboBoxMacro.Name = "activityComboBoxMacro";
            activityComboBoxMacro.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueLightMode;
            activityComboBoxMacro.Size = new Size(90, 21);
            activityComboBoxMacro.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            activityComboBoxMacro.StateCommon.DropBack.Color1 = SystemColors.ControlLightLight;
            activityComboBoxMacro.StateCommon.DropBack.Color2 = SystemColors.ControlLightLight;
            activityComboBoxMacro.StateCommon.Item.Back.Color1 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateCommon.Item.Back.Color2 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateCommon.Item.Border.Color1 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateCommon.Item.Border.Color2 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            activityComboBoxMacro.StateNormal.Item.Back.Color1 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateNormal.Item.Back.Color2 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateNormal.Item.Border.Color1 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateNormal.Item.Border.Color2 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateNormal.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            activityComboBoxMacro.StateTracking.Item.Back.Color1 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateTracking.Item.Back.Color2 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateTracking.Item.Border.Color1 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateTracking.Item.Border.Color2 = Color.FromArgb(224, 224, 224);
            activityComboBoxMacro.StateTracking.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            activityComboBoxMacro.TabIndex = 40;
            activityComboBoxMacro.SelectedIndexChanged += activityComboBox_SelectedIndexChanged;
            activityComboBoxMacro.Click += activityComboBoxMacro_Click;
            // 
            // activityLevelLabel
            // 
            activityLevelLabel.AutoSize = true;
            activityLevelLabel.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            activityLevelLabel.ForeColor = Color.Black;
            activityLevelLabel.Location = new Point(31, 133);
            activityLevelLabel.Name = "activityLevelLabel";
            activityLevelLabel.Size = new Size(76, 15);
            activityLevelLabel.TabIndex = 42;
            activityLevelLabel.Text = "Activity level:";
            activityLevelLabel.TextAlign = ContentAlignment.MiddleCenter;
            activityLevelLabel.Click += activityLevelLabel_Click;
            // 
            // balancedButton
            // 
            balancedButton.Image = Properties.Resources.balanced;
            balancedButton.Location = new Point(503, 273);
            balancedButton.Name = "balancedButton";
            balancedButton.Size = new Size(77, 31);
            balancedButton.TabIndex = 43;
            balancedButton.TabStop = false;
            balancedButton.Visible = false;
            balancedButton.Click += balancedButton_Click;
            balancedButton.MouseEnter += balancedButton_MouseEnter;
            balancedButton.MouseLeave += balancedButton_MouseLeave;
            // 
            // highProteinButton
            // 
            highProteinButton.Image = Properties.Resources.highProtein;
            highProteinButton.Location = new Point(579, 273);
            highProteinButton.Name = "highProteinButton";
            highProteinButton.Size = new Size(77, 31);
            highProteinButton.TabIndex = 44;
            highProteinButton.TabStop = false;
            highProteinButton.Visible = false;
            highProteinButton.Click += highProteinButton_Click;
            highProteinButton.MouseEnter += highProteinButton_MouseEnter;
            highProteinButton.MouseLeave += highProteinButton_MouseLeave;
            // 
            // lowCarbsButton
            // 
            lowCarbsButton.Image = Properties.Resources.lowCarbs;
            lowCarbsButton.Location = new Point(579, 303);
            lowCarbsButton.Name = "lowCarbsButton";
            lowCarbsButton.Size = new Size(77, 31);
            lowCarbsButton.TabIndex = 46;
            lowCarbsButton.TabStop = false;
            lowCarbsButton.Visible = false;
            lowCarbsButton.Click += lowCarbsButton_Click;
            lowCarbsButton.MouseEnter += lowCarbsButton_MouseEnter;
            lowCarbsButton.MouseLeave += lowCarbsButton_MouseLeave;
            // 
            // lowFatButton
            // 
            lowFatButton.Image = Properties.Resources.lowFat;
            lowFatButton.Location = new Point(503, 303);
            lowFatButton.Name = "lowFatButton";
            lowFatButton.Size = new Size(77, 31);
            lowFatButton.TabIndex = 45;
            lowFatButton.TabStop = false;
            lowFatButton.Visible = false;
            lowFatButton.Click += lowFatButton_Click;
            lowFatButton.MouseEnter += lowFatButton_MouseEnter;
            lowFatButton.MouseLeave += lowFatButton_MouseLeave;
            // 
            // kCalLabel
            // 
            kCalLabel.AutoSize = true;
            kCalLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kCalLabel.ForeColor = Color.Black;
            kCalLabel.Location = new Point(497, 117);
            kCalLabel.Name = "kCalLabel";
            kCalLabel.Size = new Size(53, 19);
            kCalLabel.TabIndex = 47;
            kCalLabel.Text = "kCal = ";
            kCalLabel.TextAlign = ContentAlignment.MiddleCenter;
            kCalLabel.Visible = false;
            kCalLabel.Click += kCalLabel_Click;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cLabel.ForeColor = Color.Black;
            cLabel.Location = new Point(497, 155);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(34, 19);
            cLabel.TabIndex = 48;
            cLabel.Text = "C = ";
            cLabel.TextAlign = ContentAlignment.MiddleCenter;
            cLabel.Visible = false;
            cLabel.Click += cLabel_Click;
            // 
            // pLabel
            // 
            pLabel.AutoSize = true;
            pLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pLabel.ForeColor = Color.Black;
            pLabel.Location = new Point(497, 194);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(33, 19);
            pLabel.TabIndex = 49;
            pLabel.Text = "P = ";
            pLabel.TextAlign = ContentAlignment.MiddleCenter;
            pLabel.Visible = false;
            pLabel.Click += pLabel_Click;
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fLabel.ForeColor = Color.Black;
            fLabel.Location = new Point(497, 238);
            fLabel.Name = "fLabel";
            fLabel.Size = new Size(32, 19);
            fLabel.TabIndex = 50;
            fLabel.Text = "F = ";
            fLabel.TextAlign = ContentAlignment.MiddleCenter;
            fLabel.Visible = false;
            fLabel.Click += fLabel_Click;
            // 
            // foodPanel
            // 
            foodPanel.AutoScroll = true;
            foodPanel.BorderStyle = BorderStyle.FixedSingle;
            foodPanel.FlowDirection = FlowDirection.RightToLeft;
            foodPanel.Location = new Point(226, 133);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(241, 201);
            foodPanel.TabIndex = 51;
            foodPanel.Click += foodPanel_Click;
            foodPanel.Paint += foodPanel_Paint;
            // 
            // searchTextBox
            // 
            searchTextBox.CueHint.CueHintText = "Search";
            searchTextBox.CueHint.Padding = new Padding(0);
            searchTextBox.Location = new Point(232, 77);
            searchTextBox.MaxLength = 28;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(225, 33);
            searchTextBox.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            searchTextBox.StateCommon.Border.Rounding = 15F;
            searchTextBox.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            searchTextBox.StateNormal.Border.Rounding = 15F;
            searchTextBox.TabIndex = 52;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            searchTextBox.KeyDown += searchTextBox_KeyDown;
            searchTextBox.KeyPress += searchTextBox_KeyPress;
            // 
            // searchIcon
            // 
            searchIcon.Cursor = Cursors.Hand;
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(425, 81);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(24, 25);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 53;
            searchIcon.TabStop = false;
            searchIcon.Click += searchIcon_Click;
            searchIcon.MouseHover += searchIcon_MouseHover;
            // 
            // searchPanel
            // 
            searchPanel.AutoScroll = true;
            searchPanel.Location = new Point(237, 110);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(216, 125);
            searchPanel.TabIndex = 54;
            searchPanel.Visible = false;
            searchPanel.Paint += flowLayoutPanel1_Paint;
            searchPanel.Leave += searchPanel_Leave;
            // 
            // hintLabel
            // 
            hintLabel.AutoSize = true;
            hintLabel.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            hintLabel.Location = new Point(252, 119);
            hintLabel.Name = "hintLabel";
            hintLabel.Size = new Size(189, 13);
            hintLabel.TabIndex = 55;
            hintLabel.Text = "Add food to the box from the search bar.";
            // 
            // hiddenPanel1
            // 
            hiddenPanel1.Controls.Add(label1);
            hiddenPanel1.Location = new Point(226, 51);
            hiddenPanel1.Name = "hiddenPanel1";
            hiddenPanel1.Size = new Size(0, 0);
            hiddenPanel1.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 130);
            label1.Name = "label1";
            label1.Size = new Size(215, 48);
            label1.TabIndex = 0;
            label1.Text = "Please select the desired\r\n activity level and nutrition goal \r\nin order to make all the tabs visible!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiddenPanel2
            // 
            hiddenPanel2.Location = new Point(480, 51);
            hiddenPanel2.Name = "hiddenPanel2";
            hiddenPanel2.Size = new Size(0, 0);
            hiddenPanel2.TabIndex = 57;
            // 
            // Diet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(hiddenPanel2);
            Controls.Add(hiddenPanel1);
            Controls.Add(searchPanel);
            Controls.Add(searchIcon);
            Controls.Add(searchTextBox);
            Controls.Add(foodPanel);
            Controls.Add(fLabel);
            Controls.Add(pLabel);
            Controls.Add(cLabel);
            Controls.Add(kCalLabel);
            Controls.Add(lowCarbsButton);
            Controls.Add(lowFatButton);
            Controls.Add(highProteinButton);
            Controls.Add(balancedButton);
            Controls.Add(activityLevelLabel);
            Controls.Add(activityComboBoxMacro);
            Controls.Add(manageGoalLabel);
            Controls.Add(manageGoalDescription);
            Controls.Add(macroАbbreviation);
            Controls.Add(protein);
            Controls.Add(fat);
            Controls.Add(carbohydrates);
            Controls.Add(calorieIntake);
            Controls.Add(addFoodLabel);
            Controls.Add(dailyGoalLabel);
            Controls.Add(dietBorder1);
            Controls.Add(dietBorder2);
            Controls.Add(dietLabel);
            Controls.Add(leftC);
            Controls.Add(rightC);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            Controls.Add(hintLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diet";
            Text = "Diet";
            Load += Diet_Load;
            Click += Diet_Click;
            ((System.ComponentModel.ISupportInitialize)leftC).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightC).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dietBorder2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dietBorder1).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityComboBoxMacro).EndInit();
            ((System.ComponentModel.ISupportInitialize)balancedButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)highProteinButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowCarbsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowFatButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            hiddenPanel1.ResumeLayout(false);
            hiddenPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox leftC;
        private PictureBox rightC;
        private PictureBox vLine1;
        private PictureBox vLine2;
        private PictureBox hLine2;
        private PictureBox hLine1;
        private Label dietLabel;
        private PictureBox dietBorder2;
        private PictureBox dietBorder1;
        private Label dailyGoalLabel;
        private Label addFoodLabel;
        private Label calorieIntake;
        private Label carbohydrates;
        private Label fat;
        private Label protein;
        private Label macroАbbreviation;
        private Label manageGoalDescription;
        private Label manageGoalLabel;
        private Krypton.Toolkit.KryptonComboBox activityComboBoxMacro;
        private Label activityLevelLabel;
        private PictureBox balancedButton;
        private PictureBox highProteinButton;
        private PictureBox lowCarbsButton;
        private PictureBox lowFatButton;
        private Label kCalLabel;
        private Label cLabel;
        private Label pLabel;
        private Label fLabel;
        private FlowLayoutPanel foodPanel;
        private Krypton.Toolkit.KryptonTextBox searchTextBox;
        private PictureBox searchIcon;
        private FlowLayoutPanel searchPanel;
        private Label hintLabel;
        private Panel hiddenPanel1;
        private Label label1;
        private Panel hiddenPanel2;
    }
}