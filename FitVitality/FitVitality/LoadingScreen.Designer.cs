namespace FitVitality
{
    partial class startLoadScreen
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
            kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // kryptonProgressBar1
            // 
            kryptonProgressBar1.BackColor = Color.Black;
            kryptonProgressBar1.ForeColor = Color.Black;
            kryptonProgressBar1.Location = new Point(235, 340);
            kryptonProgressBar1.Name = "kryptonProgressBar1";
            kryptonProgressBar1.Size = new Size(241, 10);
            kryptonProgressBar1.TabIndex = 1;
            kryptonProgressBar1.UseKrypton = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_4;
            // 
            // startLoadScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fitvitality;
            ClientSize = new Size(692, 428);
            Controls.Add(kryptonProgressBar1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Name = "startLoadScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "startLoadScreen";
            Load += startLoadScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}