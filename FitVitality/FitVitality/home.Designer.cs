namespace FitVitality
{
    partial class home
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            rotationTimer = new System.Windows.Forms.Timer(components);
            hLine1 = new PictureBox();
            hLine2 = new PictureBox();
            vLine2 = new PictureBox();
            vLine1 = new PictureBox();
            rightC = new PictureBox();
            lefCorner = new PictureBox();
            label1 = new Label();
            workoutsPanel = new Panel();
            workoutsButton = new Guna.UI2.WinForms.Guna2Button();
            workoutsDetails = new Label();
            workoutsTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            workoutsLabel = new Label();
            workoutsBorders = new PictureBox();
            dailyGoalPanel = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            fLabel = new Label();
            pLabel = new Label();
            cLabel = new Label();
            kCalLabel = new Label();
            protein = new Label();
            fat = new Label();
            carbohydrates = new Label();
            calorieIntake = new Label();
            label2 = new Label();
            dailyGoalBorders = new PictureBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lefCorner).BeginInit();
            workoutsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workoutsBorders).BeginInit();
            dailyGoalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dailyGoalBorders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // rotationTimer
            // 
            rotationTimer.Tick += rotationTimer_Tick_1;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 1);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(664, 1);
            hLine1.TabIndex = 4;
            hLine1.TabStop = false;
            hLine1.Click += pictureBox2_Click_1;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 367);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(667, 1);
            hLine2.TabIndex = 7;
            hLine2.TabStop = false;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(689, 0);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 357);
            vLine2.TabIndex = 8;
            vLine2.TabStop = false;
            // 
            // vLine1
            // 
            vLine1.Image = Properties.Resources.vline;
            vLine1.Location = new Point(0, -1);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 355);
            vLine1.TabIndex = 9;
            vLine1.TabStop = false;
            // 
            // rightC
            // 
            rightC.Image = Properties.Resources.rightC;
            rightC.Location = new Point(675, 354);
            rightC.Name = "rightC";
            rightC.Size = new Size(16, 15);
            rightC.TabIndex = 10;
            rightC.TabStop = false;
            // 
            // lefCorner
            // 
            lefCorner.Image = Properties.Resources.leftC;
            lefCorner.Location = new Point(0, 354);
            lefCorner.Name = "lefCorner";
            lefCorner.Size = new Size(16, 15);
            lefCorner.TabIndex = 12;
            lefCorner.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 22);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 13;
            label1.Text = "Dashboard";
            // 
            // workoutsPanel
            // 
            workoutsPanel.Controls.Add(workoutsButton);
            workoutsPanel.Controls.Add(workoutsDetails);
            workoutsPanel.Controls.Add(workoutsTextBox);
            workoutsPanel.Controls.Add(workoutsLabel);
            workoutsPanel.Controls.Add(workoutsBorders);
            workoutsPanel.Location = new Point(444, 64);
            workoutsPanel.Name = "workoutsPanel";
            workoutsPanel.Size = new Size(213, 269);
            workoutsPanel.TabIndex = 14;
            // 
            // workoutsButton
            // 
            workoutsButton.BackColor = Color.Transparent;
            workoutsButton.BorderRadius = 13;
            workoutsButton.CustomizableEdges = customizableEdges1;
            workoutsButton.DisabledState.BorderColor = Color.DarkGray;
            workoutsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            workoutsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            workoutsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            workoutsButton.FillColor = Color.White;
            workoutsButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            workoutsButton.ForeColor = Color.White;
            workoutsButton.Image = Properties.Resources.forwardArrow;
            workoutsButton.Location = new Point(90, 236);
            workoutsButton.Name = "workoutsButton";
            workoutsButton.PressedColor = Color.LightGray;
            workoutsButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            workoutsButton.Size = new Size(32, 25);
            workoutsButton.TabIndex = 51;
            workoutsButton.Click += createNextButton_Click;
            // 
            // workoutsDetails
            // 
            workoutsDetails.AutoSize = true;
            workoutsDetails.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            workoutsDetails.Location = new Point(29, 218);
            workoutsDetails.Name = "workoutsDetails";
            workoutsDetails.Size = new Size(154, 13);
            workoutsDetails.TabIndex = 3;
            workoutsDetails.Text = "Press the arrow for more details.";
            // 
            // workoutsTextBox
            // 
            workoutsTextBox.BorderColor = Color.White;
            workoutsTextBox.CustomizableEdges = customizableEdges3;
            workoutsTextBox.DefaultText = "3x12 dumbell mumbell\r\n3x12 dumbell mumbell\r\n3x12 dumbell mumbell\r\n3x12 dumbell mumbell\r\n3x12 dumbell mumbell\r\n3x12 dumbell mumbell\r\n";
            workoutsTextBox.DisabledState.BorderColor = Color.White;
            workoutsTextBox.DisabledState.FillColor = Color.White;
            workoutsTextBox.DisabledState.ForeColor = Color.Black;
            workoutsTextBox.DisabledState.PlaceholderForeColor = Color.Black;
            workoutsTextBox.Enabled = false;
            workoutsTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            workoutsTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            workoutsTextBox.ForeColor = Color.Black;
            workoutsTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            workoutsTextBox.Location = new Point(13, 41);
            workoutsTextBox.Multiline = true;
            workoutsTextBox.Name = "workoutsTextBox";
            workoutsTextBox.PasswordChar = '\0';
            workoutsTextBox.PlaceholderForeColor = Color.White;
            workoutsTextBox.PlaceholderText = "";
            workoutsTextBox.SelectedText = "";
            workoutsTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            workoutsTextBox.Size = new Size(186, 163);
            workoutsTextBox.TabIndex = 2;
            // 
            // workoutsLabel
            // 
            workoutsLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            workoutsLabel.Location = new Point(13, 14);
            workoutsLabel.Name = "workoutsLabel";
            workoutsLabel.Size = new Size(186, 23);
            workoutsLabel.TabIndex = 1;
            workoutsLabel.Text = "/day/";
            workoutsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // workoutsBorders
            // 
            workoutsBorders.Image = Properties.Resources.workoutMainBorders;
            workoutsBorders.Location = new Point(0, 0);
            workoutsBorders.Name = "workoutsBorders";
            workoutsBorders.Size = new Size(213, 269);
            workoutsBorders.TabIndex = 0;
            workoutsBorders.TabStop = false;
            // 
            // dailyGoalPanel
            // 
            dailyGoalPanel.Controls.Add(guna2Button1);
            dailyGoalPanel.Controls.Add(fLabel);
            dailyGoalPanel.Controls.Add(pLabel);
            dailyGoalPanel.Controls.Add(cLabel);
            dailyGoalPanel.Controls.Add(kCalLabel);
            dailyGoalPanel.Controls.Add(protein);
            dailyGoalPanel.Controls.Add(fat);
            dailyGoalPanel.Controls.Add(carbohydrates);
            dailyGoalPanel.Controls.Add(calorieIntake);
            dailyGoalPanel.Controls.Add(label2);
            dailyGoalPanel.Controls.Add(dailyGoalBorders);
            dailyGoalPanel.Location = new Point(223, 64);
            dailyGoalPanel.Name = "dailyGoalPanel";
            dailyGoalPanel.Size = new Size(183, 127);
            dailyGoalPanel.TabIndex = 15;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 13;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.forwardArrow;
            guna2Button1.Location = new Point(139, 94);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.LightGray;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(32, 25);
            guna2Button1.TabIndex = 52;
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fLabel.ForeColor = Color.Black;
            fLabel.Location = new Point(16, 101);
            fLabel.Name = "fLabel";
            fLabel.Size = new Size(32, 19);
            fLabel.TabIndex = 54;
            fLabel.Text = "F = ";
            fLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pLabel
            // 
            pLabel.AutoSize = true;
            pLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pLabel.ForeColor = Color.Black;
            pLabel.Location = new Point(16, 79);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(33, 19);
            pLabel.TabIndex = 53;
            pLabel.Text = "P = ";
            pLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cLabel.ForeColor = Color.Black;
            cLabel.Location = new Point(16, 56);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(34, 19);
            cLabel.TabIndex = 52;
            cLabel.Text = "C = ";
            cLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kCalLabel
            // 
            kCalLabel.AutoSize = true;
            kCalLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kCalLabel.ForeColor = Color.Black;
            kCalLabel.Location = new Point(17, 32);
            kCalLabel.Name = "kCalLabel";
            kCalLabel.Size = new Size(53, 19);
            kCalLabel.TabIndex = 51;
            kCalLabel.Text = "kCal = ";
            kCalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // protein
            // 
            protein.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            protein.ForeColor = Color.Black;
            protein.Location = new Point(48, 78);
            protein.Name = "protein";
            protein.Size = new Size(75, 19);
            protein.TabIndex = 58;
            protein.Text = "#/#";
            protein.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fat
            // 
            fat.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fat.ForeColor = Color.Black;
            fat.Location = new Point(48, 100);
            fat.Name = "fat";
            fat.Size = new Size(75, 19);
            fat.TabIndex = 57;
            fat.Text = "#/#";
            fat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carbohydrates
            // 
            carbohydrates.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            carbohydrates.ForeColor = Color.Black;
            carbohydrates.Location = new Point(48, 56);
            carbohydrates.Name = "carbohydrates";
            carbohydrates.Size = new Size(75, 19);
            carbohydrates.TabIndex = 56;
            carbohydrates.Text = "#/#";
            carbohydrates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // calorieIntake
            // 
            calorieIntake.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calorieIntake.ForeColor = Color.Black;
            calorieIntake.Location = new Point(65, 32);
            calorieIntake.Name = "calorieIntake";
            calorieIntake.Size = new Size(75, 19);
            calorieIntake.TabIndex = 55;
            calorieIntake.Text = "#/#";
            calorieIntake.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 7);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 2;
            label2.Text = "Daily Goal";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dailyGoalBorders
            // 
            dailyGoalBorders.Image = Properties.Resources.dailyGoalMainBorders;
            dailyGoalBorders.Location = new Point(0, 0);
            dailyGoalBorders.Name = "dailyGoalBorders";
            dailyGoalBorders.Size = new Size(183, 127);
            dailyGoalBorders.TabIndex = 59;
            dailyGoalBorders.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(31, 201);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart1.PaletteCustomColors = new Color[] { Color.FromArgb(92, 225, 230) };
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(375, 132);
            chart1.TabIndex = 16;
            chart1.Text = "chart1";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(690, 368);
            Controls.Add(chart1);
            Controls.Add(dailyGoalPanel);
            Controls.Add(workoutsPanel);
            Controls.Add(label1);
            Controls.Add(lefCorner);
            Controls.Add(rightC);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            Text = "home";
            Activated += home_Activated;
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightC).EndInit();
            ((System.ComponentModel.ISupportInitialize)lefCorner).EndInit();
            workoutsPanel.ResumeLayout(false);
            workoutsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workoutsBorders).EndInit();
            dailyGoalPanel.ResumeLayout(false);
            dailyGoalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dailyGoalBorders).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer rotationTimer;
        private PictureBox hLine1;
        private PictureBox hLine2;
        private PictureBox vLine2;
        private PictureBox vLine1;
        private PictureBox rightC;
        private PictureBox lefCorner;
        private Label label1;
        private Panel workoutsPanel;
        private PictureBox workoutsBorders;
        private Label workoutsLabel;
        private Label workoutsDetails;
        private Guna.UI2.WinForms.Guna2TextBox workoutsTextBox;
        private Guna.UI2.WinForms.Guna2Button workoutsButton;
        private Panel dailyGoalPanel;
        private Label label2;
        private Label fLabel;
        private Label pLabel;
        private Label cLabel;
        private Label kCalLabel;
        private Label protein;
        private Label fat;
        private Label carbohydrates;
        private Label calorieIntake;
        private PictureBox dailyGoalBorders;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}