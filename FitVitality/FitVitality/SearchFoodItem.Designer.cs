namespace FitVitality
{
    partial class SearchFoodItem
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
            foodName = new Label();
            hLine1 = new PictureBox();
            pictureBox2 = new PictureBox();
            borderLeft = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)foodImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borderLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // foodImage
            // 
            foodImage.Location = new Point(3, 3);
            foodImage.Name = "foodImage";
            foodImage.Size = new Size(30, 29);
            foodImage.SizeMode = PictureBoxSizeMode.Zoom;
            foodImage.TabIndex = 0;
            foodImage.TabStop = false;
            foodImage.Click += pictureBox1_Click;
            foodImage.MouseEnter += SearchFoodItem_MouseEnter;
            foodImage.MouseLeave += SearchFoodItem_MouseLeave;
            // 
            // foodName
            // 
            foodName.AutoSize = true;
            foodName.Location = new Point(37, 10);
            foodName.Name = "foodName";
            foodName.Size = new Size(47, 15);
            foodName.TabIndex = 1;
            foodName.Text = "{Name}";
            foodName.Click += label1_Click;
            foodName.MouseEnter += SearchFoodItem_MouseEnter;
            foodName.MouseLeave += SearchFoodItem_MouseLeave;
            // 
            // hLine1
            // 
            hLine1.Image = Properties.Resources.hLine;
            hLine1.Location = new Point(-1, 34);
            hLine1.Name = "hLine1";
            hLine1.Size = new Size(193, 1);
            hLine1.TabIndex = 26;
            hLine1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hLine;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 1);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // borderLeft
            // 
            borderLeft.Image = Properties.Resources.vline;
            borderLeft.Location = new Point(189, 1);
            borderLeft.Name = "borderLeft";
            borderLeft.Size = new Size(1, 35);
            borderLeft.TabIndex = 28;
            borderLeft.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.vline;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1, 35);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // SearchFoodItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(borderLeft);
            Controls.Add(pictureBox2);
            Controls.Add(hLine1);
            Controls.Add(foodName);
            Controls.Add(foodImage);
            Cursor = Cursors.Hand;
            Name = "SearchFoodItem";
            Size = new Size(190, 35);
            Click += SearchFoodItem_Click;
            MouseEnter += SearchFoodItem_MouseEnter;
            MouseLeave += SearchFoodItem_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)foodImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)hLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)borderLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox foodImage;
        private Label foodName;
        private PictureBox hLine1;
        private PictureBox pictureBox2;
        private PictureBox borderLeft;
        private PictureBox pictureBox3;
    }
}
