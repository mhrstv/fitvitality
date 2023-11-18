namespace FitVitality
{
    partial class Calculators
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
            label1 = new Label();
            panel1 = new Panel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 22);
            label1.Name = "label1";
            label1.Size = new Size(127, 24);
            label1.TabIndex = 0;
            label1.Text = "Calculators";
            // 
            // panel1
            // 
            panel1.Controls.Add(kryptonButton1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 44);
            panel1.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new Point(143, 10);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(81, 25);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateNormal.Border.Color1 = Color.Black;
            kryptonButton1.StateNormal.Border.Color2 = Color.Black;
            kryptonButton1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateNormal.Border.Rounding = 25F;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(92, 225, 230);
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.Rounding = 25F;
            kryptonButton1.StateTracking.Border.Width = 0;
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.Text = "Open";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(250, 252, 252);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 13);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 0;
            label2.Text = "BMI Calculator";
            // 
            // Calculators
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(690, 368);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculators";
            Text = "Calculators";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}