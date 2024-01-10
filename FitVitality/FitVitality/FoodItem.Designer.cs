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
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            caloriesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)foodImage).BeginInit();
            SuspendLayout();
            // 
            // foodImage
            // 
            foodImage.Location = new Point(9, 12);
            foodImage.Name = "foodImage";
            foodImage.Size = new Size(50, 50);
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
            foodNameLabel.Location = new Point(94, 8);
            foodNameLabel.Name = "foodNameLabel";
            foodNameLabel.Size = new Size(100, 15);
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
            // kryptonTextBox1
            // 
            kryptonTextBox1.CueHint.CueHintText = "100";
            kryptonTextBox1.CueHint.Padding = new Padding(0);
            kryptonTextBox1.Location = new Point(150, 48);
            kryptonTextBox1.MaxLength = 4;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(31, 23);
            kryptonTextBox1.TabIndex = 7;
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
            // FoodItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(caloriesLabel);
            Controls.Add(kryptonTextBox1);
            Controls.Add(label_g);
            Controls.Add(foodNameLabel);
            Controls.Add(fLabel);
            Controls.Add(pLabel);
            Controls.Add(cLabel);
            Controls.Add(foodImage);
            Name = "FoodItem";
            Size = new Size(197, 74);
            ((System.ComponentModel.ISupportInitialize)foodImage).EndInit();
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
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label caloriesLabel;
    }
}
