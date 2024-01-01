namespace FitVitality
{
    partial class WorkoutListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutListItem));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            labelExercises = new Label();
            workoutNumLabel = new Label();
            selectButton = new Krypton.Toolkit.KryptonButton();
            leftTopC = new PictureBox();
            rightTopC = new PictureBox();
            leftBottomCorner = new PictureBox();
            rightBottomCorner = new PictureBox();
            vLine2 = new PictureBox();
            vLine1 = new PictureBox();
            hLine2 = new PictureBox();
            hLine1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftTopC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightTopC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBottomCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightBottomCorner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.closebutton;
            kryptonPalette1.ButtonSpecs.FormMax.Image = (Image)resources.GetObject("resource.Image");
            kryptonPalette1.ButtonSpecs.FormMin.Image = (Image)resources.GetObject("resource.Image1");
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Properties.Resources.maximizebutton;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = Color.Black;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = Color.Black;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 5;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.Black;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.Black;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Width = 0;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(11, -1, -1, -1);
            // 
            // labelExercises
            // 
            labelExercises.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelExercises.Location = new Point(12, 48);
            labelExercises.Name = "labelExercises";
            labelExercises.Size = new Size(276, 138);
            labelExercises.TabIndex = 15;
            labelExercises.Text = "[MUSCLE GROUP] - [EXERCISES]";
            // 
            // workoutNumLabel
            // 
            workoutNumLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            workoutNumLabel.Location = new Point(28, 12);
            workoutNumLabel.Name = "workoutNumLabel";
            workoutNumLabel.Size = new Size(244, 23);
            workoutNumLabel.TabIndex = 14;
            workoutNumLabel.Text = "Workout [Number]";
            workoutNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectButton
            // 
            selectButton.CornerRoundingRadius = 15F;
            selectButton.Location = new Point(213, 189);
            selectButton.Name = "selectButton";
            selectButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            selectButton.Size = new Size(70, 25);
            selectButton.StateCommon.Back.Color1 = Color.FromArgb(90, 220, 225);
            selectButton.StateCommon.Back.Color2 = Color.FromArgb(94, 229, 235);
            selectButton.StateCommon.Back.ColorAngle = 0F;
            selectButton.StateCommon.Border.Color1 = Color.FromArgb(90, 220, 225);
            selectButton.StateCommon.Border.Color2 = Color.FromArgb(94, 229, 235);
            selectButton.StateCommon.Border.ColorAngle = 0F;
            selectButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            selectButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StateCommon.Border.Rounding = 15F;
            selectButton.StateCommon.Border.Width = 1;
            selectButton.StateCommon.Content.ShortText.Color1 = Color.White;
            selectButton.StateCommon.Content.ShortText.Color2 = Color.White;
            selectButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectButton.StateDisabled.Back.Color1 = Color.FromArgb(92, 225, 230);
            selectButton.StateDisabled.Back.Color2 = Color.FromArgb(92, 225, 230);
            selectButton.StateDisabled.Back.ColorAngle = 45F;
            selectButton.StateDisabled.Border.Color1 = Color.FromArgb(92, 225, 230);
            selectButton.StateDisabled.Border.Color2 = Color.FromArgb(92, 225, 230);
            selectButton.StateDisabled.Border.ColorAngle = 45F;
            selectButton.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            selectButton.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StateDisabled.Border.Rounding = 15F;
            selectButton.StateDisabled.Border.Width = 1;
            selectButton.StateDisabled.Content.ShortText.Color1 = Color.White;
            selectButton.StateDisabled.Content.ShortText.Color2 = Color.White;
            selectButton.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectButton.StateNormal.Back.Color1 = Color.FromArgb(92, 225, 230);
            selectButton.StateNormal.Back.Color2 = Color.FromArgb(92, 225, 230);
            selectButton.StateNormal.Back.ColorAngle = 0F;
            selectButton.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StateNormal.Border.Color1 = Color.FromArgb(92, 225, 230);
            selectButton.StateNormal.Border.Color2 = Color.FromArgb(92, 225, 230);
            selectButton.StateNormal.Border.ColorAngle = 0F;
            selectButton.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            selectButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StateNormal.Border.Rounding = 15F;
            selectButton.StateNormal.Border.Width = 1;
            selectButton.StatePressed.Back.Color1 = Color.FromArgb(0, 160, 192);
            selectButton.StatePressed.Back.Color2 = Color.FromArgb(0, 160, 192);
            selectButton.StatePressed.Back.ColorAngle = 45F;
            selectButton.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StatePressed.Border.Color1 = Color.FromArgb(0, 160, 192);
            selectButton.StatePressed.Border.Color2 = Color.FromArgb(0, 160, 192);
            selectButton.StatePressed.Border.ColorAngle = 45F;
            selectButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            selectButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StatePressed.Border.Rounding = 15F;
            selectButton.StatePressed.Border.Width = 1;
            selectButton.StateTracking.Back.Color1 = Color.FromArgb(161, 234, 230);
            selectButton.StateTracking.Back.Color2 = Color.FromArgb(161, 234, 230);
            selectButton.StateTracking.Back.ColorAngle = 45F;
            selectButton.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StateTracking.Border.Color1 = Color.FromArgb(161, 234, 230);
            selectButton.StateTracking.Border.Color2 = Color.FromArgb(161, 234, 230);
            selectButton.StateTracking.Border.ColorAngle = 45F;
            selectButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            selectButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            selectButton.StateTracking.Border.Rounding = 15F;
            selectButton.StateTracking.Border.Width = 1;
            selectButton.TabIndex = 13;
            selectButton.Values.Text = "Select";
            // 
            // leftTopC
            // 
            leftTopC.Image = Properties.Resources.leftCUp;
            leftTopC.Location = new Point(0, 0);
            leftTopC.Name = "leftTopC";
            leftTopC.Size = new Size(16, 15);
            leftTopC.TabIndex = 17;
            leftTopC.TabStop = false;
            // 
            // rightTopC
            // 
            rightTopC.Image = Properties.Resources.rightCUp;
            rightTopC.Location = new Point(284, 0);
            rightTopC.Name = "rightTopC";
            rightTopC.Size = new Size(16, 15);
            rightTopC.TabIndex = 16;
            rightTopC.TabStop = false;
            // 
            // leftBottomCorner
            // 
            leftBottomCorner.Image = Properties.Resources.leftC;
            leftBottomCorner.Location = new Point(0, 201);
            leftBottomCorner.Name = "leftBottomCorner";
            leftBottomCorner.Size = new Size(16, 15);
            leftBottomCorner.TabIndex = 20;
            leftBottomCorner.TabStop = false;
            // 
            // rightBottomCorner
            // 
            rightBottomCorner.Image = Properties.Resources.rightC;
            rightBottomCorner.Location = new Point(284, 202);
            rightBottomCorner.Name = "rightBottomCorner";
            rightBottomCorner.Size = new Size(16, 15);
            rightBottomCorner.TabIndex = 21;
            rightBottomCorner.TabStop = false;
            // 
            // vLine2
            // 
            vLine2.Image = Properties.Resources.vline;
            vLine2.Location = new Point(299, 12);
            vLine2.Name = "vLine2";
            vLine2.Size = new Size(1, 190);
            vLine2.TabIndex = 22;
            vLine2.TabStop = false;
            // 
            // vLine1
            // 
            vLine1.Image = Properties.Resources.vline;
            vLine1.Location = new Point(0, 12);
            vLine1.Name = "vLine1";
            vLine1.Size = new Size(1, 191);
            vLine1.TabIndex = 23;
            vLine1.TabStop = false;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(12, 216);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(275, 1);
            hLine2.TabIndex = 24;
            hLine2.TabStop = false;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(13, 0);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(275, 1);
            hLine1.TabIndex = 25;
            hLine1.TabStop = false;
            // 
            // WorkoutListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(hLine1);
            Controls.Add(hLine2);
            Controls.Add(vLine1);
            Controls.Add(vLine2);
            Controls.Add(rightBottomCorner);
            Controls.Add(leftBottomCorner);
            Controls.Add(leftTopC);
            Controls.Add(rightTopC);
            Controls.Add(labelExercises);
            Controls.Add(workoutNumLabel);
            Controls.Add(selectButton);
            Name = "WorkoutListItem";
            Size = new Size(300, 218);
            Load += WorkoutListItem_Load;
            ((System.ComponentModel.ISupportInitialize)leftTopC).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightTopC).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBottomCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightBottomCorner).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label labelExercises;
        private Label workoutNumLabel;
        private Krypton.Toolkit.KryptonButton selectButton;
        private PictureBox leftTopC;
        private PictureBox rightTopC;
        private PictureBox leftBottomCorner;
        private PictureBox rightBottomCorner;
        private PictureBox vLine2;
        private PictureBox vLine1;
        private PictureBox hLine2;
        private PictureBox hLine1;
    }
}
