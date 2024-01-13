namespace FitVitality
{
    partial class FoodItem
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
            foodImage = new PictureBox();
            cLabel = new Label();
            pLabel = new Label();
            fLabel = new Label();
            foodNameLabel = new Label();
            label_g = new Label();
            textBoxGrams = new Krypton.Toolkit.KryptonTextBox();
            caloriesLabel = new Label();
            removeFoodItem = new PictureBox();
            borderLeft = new PictureBox();
            borderRight = new PictureBox();
            hLine1 = new PictureBox();
            hLine2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)foodImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)removeFoodItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borderLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borderRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).BeginInit();
            SuspendLayout();
            // 
            // foodImage
            // 
            foodImage.Location = new Point(9, 12);
            foodImage.Name = "foodImage";
            foodImage.Size = new Size(50, 50);
            foodImage.SizeMode = PictureBoxSizeMode.Zoom;
            foodImage.TabIndex = 0;
            foodImage.TabStop = false;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new Point(65, 4);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(18, 15);
            cLabel.TabIndex = 1;
            cLabel.Text = "C:";
            // 
            // pLabel
            // 
            pLabel.AutoSize = true;
            pLabel.Location = new Point(66, 22);
            pLabel.Name = "pLabel";
            pLabel.Size = new Size(17, 15);
            pLabel.TabIndex = 2;
            pLabel.Text = "P:";
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Location = new Point(67, 40);
            fLabel.Name = "fLabel";
            fLabel.Size = new Size(16, 15);
            fLabel.TabIndex = 3;
            fLabel.Text = "F:";
            // 
            // foodNameLabel
            // 
            foodNameLabel.Location = new Point(104, 23);
            foodNameLabel.Name = "foodNameLabel";
            foodNameLabel.Size = new Size(90, 15);
            foodNameLabel.TabIndex = 4;
            foodNameLabel.Text = "Name";
            foodNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // label_g
            // 
            label_g.AutoSize = true;
            label_g.Location = new Point(180, 55);
            label_g.Name = "label_g";
            label_g.Size = new Size(14, 15);
            label_g.TabIndex = 6;
            label_g.Text = "g";
            // 
            // textBoxGrams
            // 
            textBoxGrams.CueHint.CueHintText = "100";
            textBoxGrams.CueHint.Padding = new Padding(0);
            textBoxGrams.Location = new Point(150, 48);
            textBoxGrams.MaxLength = 4;
            textBoxGrams.Name = "textBoxGrams";
            textBoxGrams.Size = new Size(31, 23);
            textBoxGrams.TabIndex = 7;
            textBoxGrams.TextChanged += textBoxGrams_TextChanged;
            // 
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Location = new Point(67, 55);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(33, 15);
            caloriesLabel.TabIndex = 8;
            caloriesLabel.Text = "kCal:";
            // 
            // removeFoodItem
            // 
            removeFoodItem.Image = Properties.Resources.closeFoodItem;
            removeFoodItem.Location = new Point(176, 4);
            removeFoodItem.Name = "removeFoodItem";
            removeFoodItem.Size = new Size(12, 12);
            removeFoodItem.SizeMode = PictureBoxSizeMode.Zoom;
            removeFoodItem.TabIndex = 9;
            removeFoodItem.TabStop = false;
            removeFoodItem.Click += pictureBox1_Click;
            removeFoodItem.MouseEnter += removeFoodItem_MouseEnter;
            removeFoodItem.MouseLeave += removeFoodItem_MouseLeave;
            // 
            // borderLeft
            // 
            borderLeft.Image = Properties.Resources.vline;
            borderLeft.Location = new Point(0, -2);
            borderLeft.Name = "borderLeft";
            borderLeft.Size = new Size(1, 76);
            borderLeft.TabIndex = 23;
            borderLeft.TabStop = false;
            // 
            // borderRight
            // 
            borderRight.Image = Properties.Resources.vline;
            borderRight.Location = new Point(192, -1);
            borderRight.Name = "borderRight";
            borderRight.Size = new Size(1, 76);
            borderRight.TabIndex = 24;
            borderRight.TabStop = false;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(0, 0);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(193, 1);
            hLine1.TabIndex = 25;
            hLine1.TabStop = false;
            // 
            // hLine2
            // 
            hLine2.Image = Properties.Resources.hLine;
            hLine2.Location = new Point(0, 73);
            hLine2.Name = "hLine2";
            hLine2.Size = new Size(193, 1);
            hLine2.TabIndex = 26;
            hLine2.TabStop = false;
            // 
            // FoodItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(hLine2);
            Controls.Add(hLine1);
            Controls.Add(borderRight);
            Controls.Add(borderLeft);
            Controls.Add(removeFoodItem);
            Controls.Add(caloriesLabel);
            Controls.Add(textBoxGrams);
            Controls.Add(label_g);
            Controls.Add(foodNameLabel);
            Controls.Add(fLabel);
            Controls.Add(pLabel);
            Controls.Add(cLabel);
            Controls.Add(foodImage);
            Name = "FoodItem";
            Size = new Size(193, 74);
            ((System.ComponentModel.ISupportInitialize)foodImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)removeFoodItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)borderLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)borderRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox foodImage;
        private Label cLabel;
        private Label pLabel;
        private Label fLabel;
        private Label foodNameLabel;
        private Label label_g;
        private Krypton.Toolkit.KryptonTextBox textBoxGrams;
        private Label caloriesLabel;
        private PictureBox removeFoodItem;
        private PictureBox borderLeft;
        private PictureBox borderRight;
        private PictureBox hLine1;
        private PictureBox hLine2;
    }
}
