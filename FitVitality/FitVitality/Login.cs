using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Krypton.Toolkit;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace FitVitality
{
    public partial class Login : KryptonForm
    {
        private bool mouseDown;
        private Point lastLocation;
        public string userID;
        public Login()
        {
            InitializeComponent();
        }
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            var activated = new Register();
            if (activated.opened)
            {
                this.Location = Register.ActiveForm.Location;
            }
            var cfg = new Config("FitVitality.ini");
            var username = cfg.Read("Username", "SETTINGS");
            if (username != "")
            {
                kryptonTextBox1.Text = username.ToString();
                checkBox1.Checked = true;
            }
            else
            {
                kryptonTextBox1.Text = "";
                checkBox1.Checked = false;
            }
        }

        private void WelcomeScreen_Shown(object sender, EventArgs e)
        {

            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity += 0.00004;
            }
        }

        private void WelcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var cfg = new Config("FitVitality.ini");
            string username = kryptonTextBox1.Text;
            string password = kryptonTextBox2.Text;
            string query = "SELECT UserID, Username, Password FROM UserData WHERE Username = @Username AND Password = @Password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string dbUser = reader["Username"].ToString();
                            string dbPass = reader["Password"].ToString();
                            if (dbUser == username && dbPass == password)
                            {
                                usrmark.Visible = false;
                                passmark.Visible = false;
                                kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                                kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                                kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                                kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                                panel2.Visible = false;
                                panel2.Height = 0;
                                if (checkBox1.Checked == true)
                                {
                                    cfg.Write("Username", username, "SETTINGS");
                                }
                                else
                                {
                                    cfg.Write("Username", "", "SETTINGS");
                                }

                                for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                                {
                                    this.Opacity = i;
                                }
                                userID = reader["UserID"].ToString();
                                cfg.Write("UserID", userID, "SETTINGS");
                                Form1 form = new Form1();
                                Thread.Sleep(500);
                                form.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            panel2.Visible = true;
                            usrmark.Visible = true;
                            passmark.Visible = true;
                            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                            timer1.Enabled = true;
                        }
                    }
                }
            }
        }

        private void kryptonPalette2_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.IndianRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Silver;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            for (double i = this.Opacity; i >= 0; i = i - 0.00002)
            {
                this.Opacity = i;
            }
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void kryptonButton1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void WelcomeScreen_MouseHover(object sender, EventArgs e)
        {

        }

        public void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Height <= 33)
            {
                panel2.Height += 2;
            }
            if (panel2.Height >= 33)
            {
                timer1.Stop();
                timer1.Enabled = false; 
            }
            
        }

        private void kryptonTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton1_Click(this, new EventArgs());
            }
        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton1_Click(this, new EventArgs());
            }
        }
    }
}
