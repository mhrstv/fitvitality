namespace FitVitality
{
    partial class ExerciseListItem
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
            addLabel = new Label();
            SuspendLayout();
            // 
            // exerciseLabel
            // 
            exerciseLabel.Location = new Point(3, 3);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(155, 17);
            exerciseLabel.TabIndex = 0;
            exerciseLabel.Text = "/exercise/";
            // 
            // addLabel
            // 
            addLabel.AutoSize = true;
            addLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addLabel.ForeColor = Color.FromArgb(92, 225, 230);
            addLabel.Location = new Point(164, 1);
            addLabel.Name = "addLabel";
            addLabel.Size = new Size(19, 20);
            addLabel.TabIndex = 2;
            addLabel.Text = "+";
            addLabel.Click += addLabel_Click;
            // 
            // ExerciseListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addLabel);
            Controls.Add(exerciseLabel);
            Name = "ExerciseListItem";
            Size = new Size(184, 23);
            Load += ExerciseListItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exerciseLabel;
        private Label addLabel;
    }
}
