namespace FitVitality
{
    partial class formLogin
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
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textPass = new TextBox();
            textUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            frmRegister = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(103, 303);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 32;
            label5.Text = "Register";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(67, 288);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 31;
            label4.Text = "I do not have an account";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(25, 244);
            button1.Name = "button1";
            button1.Size = new Size(223, 32);
            button1.TabIndex = 30;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ControlDarkDark;
            checkBox1.Location = new Point(147, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 17);
            checkBox1.TabIndex = 29;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textPass
            // 
            textPass.BackColor = SystemColors.ScrollBar;
            textPass.BorderStyle = BorderStyle.None;
            textPass.Cursor = Cursors.IBeam;
            textPass.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textPass.Location = new Point(25, 164);
            textPass.Multiline = true;
            textPass.Name = "textPass";
            textPass.Size = new Size(223, 25);
            textPass.TabIndex = 26;
            // 
            // textUser
            // 
            textUser.BackColor = SystemColors.ScrollBar;
            textUser.BorderStyle = BorderStyle.None;
            textUser.Cursor = Cursors.IBeam;
            textUser.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textUser.Location = new Point(25, 107);
            textUser.Multiline = true;
            textUser.Name = "textUser";
            textUser.Size = new Size(223, 26);
            textUser.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(26, 150);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 24;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(26, 93);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 23;
            label1.Text = "Username";
            // 
            // frmRegister
            // 
            frmRegister.AutoSize = true;
            frmRegister.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            frmRegister.ForeColor = Color.DimGray;
            frmRegister.Location = new Point(67, 43);
            frmRegister.Name = "frmRegister";
            frmRegister.Size = new Size(140, 32);
            frmRegister.TabIndex = 22;
            frmRegister.Text = "Get Started";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 371);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textPass);
            Controls.Add(textUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(frmRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formLogin";
            Load += formLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textPass;
        private TextBox textUser;
        private Label label2;
        private Label label1;
        private Label frmRegister;
    }
}