namespace FitVitality
{
    partial class Exercise
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
            exerciseLabel = new Label();
            removeLabel = new Label();
            SuspendLayout();
            // 
            // exerciseLabel
            // 
            exerciseLabel.Location = new Point(4, 3);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(127, 17);
            exerciseLabel.TabIndex = 0;
            exerciseLabel.Text = "/exercise/";
            // 
            // removeLabel
            // 
            removeLabel.AutoSize = true;
            removeLabel.ForeColor = Color.FromArgb(92, 225, 230);
            removeLabel.Location = new Point(137, 3);
            removeLabel.Name = "removeLabel";
            removeLabel.Size = new Size(14, 15);
            removeLabel.TabIndex = 1;
            removeLabel.Text = "X";
            removeLabel.Click += removeLabel_Click;
            // 
            // Exercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(removeLabel);
            Controls.Add(exerciseLabel);
            Name = "Exercise";
            Size = new Size(154, 23);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exerciseLabel;
        private Label removeLabel;
    }
}
