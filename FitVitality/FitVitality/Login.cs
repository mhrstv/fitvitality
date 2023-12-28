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
using System.Security.Cryptography;

namespace FitVitality
{
    public partial class Login : KryptonForm
    {
        private bool mouseDown;
        private Point lastLocation;
        public string userID;
        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
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
            var username = Properties.Settings.Default.Username;
            if (username != "")
            {
                textBoxUsername.Text = username.ToString();
                rememberMe.Checked = true;
            }
            else
            {
                textBoxUsername.Text = "";
                rememberMe.Checked = false;
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
            bool login = false;
            var cfg = new Config("FitVitality.ini");
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID, Username, Password FROM UserData WHERE Username = @Username AND Password = @Password";
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
                                login = true;
                                usrmark.Visible = false;
                                passmark.Visible = false;
                                textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                                textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                                textBoxPassword.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                                textBoxPassword.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                                errorPanel.Visible = false;
                                errorPanel.Height = 0;
                                if (rememberMe.Checked == true)
                                {
                                    Properties.Settings.Default.Username = username;
                                    Properties.Settings.Default.Save();
                                }
                                else
                                {   
                                    Properties.Settings.Default.Username = "";
                                    Properties.Settings.Default.Save();
                                }

                                for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                                {
                                    this.Opacity = i;
                                }

                                userID = reader["UserID"].ToString();
                            }
                            else
                            {
                                errorPanel.Visible = true;
                                usrmark.Visible = true;
                                passmark.Visible = true;
                                textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                                textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                                textBoxPassword.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                                textBoxPassword.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                                timerError.Enabled = true;
                            }
                        }
                    }
                }
            }
            if (login)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkData = "SELECT COUNT(*) FROM UserSettings " +
                                       "WHERE UserID = @UserID " +
                                       "AND Name IS NOT NULL " +
                                       "AND Age IS NOT NULL " +
                                       "AND Gender IS NOT NULL " +
                                       "AND Weight IS NOT NULL " +
                                       "AND Height IS NOT NULL " +
                                       "AND Goal IS NOT NULL ";
                    using (SqlCommand commandCheckData = new SqlCommand(checkData, connection))
                    {
                        commandCheckData.Parameters.AddWithValue("@UserID", userID);
                        int count = (int)commandCheckData.ExecuteScalar();
                        if (count != 1)
                        {
                            usrmark.Visible = false;
                            passmark.Visible = false;
                            textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                            textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                            textBoxPassword.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                            textBoxPassword.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                            errorPanel.Visible = false;
                            errorPanel.Height = 0;
                            if (rememberMe.Checked == true)
                            {
                                Properties.Settings.Default.Username = username;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.Username = "";
                                Properties.Settings.Default.Save();
                            }

                            for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                            {
                                this.Opacity = i;
                            }
                            Welcome welcome = new Welcome(userID);
                            Thread.Sleep(500);
                            welcome.Show();
                            this.Hide();
                        }
                        else
                        {
                            usrmark.Visible = false;
                            passmark.Visible = false;
                            textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                            textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                            textBoxPassword.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                            textBoxPassword.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                            errorPanel.Visible = false;
                            errorPanel.Height = 0;
                            if (rememberMe.Checked == true)
                            {
                                Properties.Settings.Default.Username = username;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.Username = "";
                                Properties.Settings.Default.Save();
                            }

                            for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                            {
                                this.Opacity = i;
                            }
                            Form1 form = new Form1(userID);
                            Thread.Sleep(500);
                            form.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                errorPanel.Visible = true;
                usrmark.Visible = true;
                passmark.Visible = true;
                textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                textBoxPassword.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxPassword.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                timerError.Enabled = true;
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
            buttonClose.BackColor = Color.IndianRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.White;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.Silver;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.White;
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
            if (errorPanel.Height <= 33)
            {
                errorPanel.Height += 2;
            }
            if (errorPanel.Height >= 33)
            {
                timerError.Stop();
                timerError.Enabled = false;
            }

        }

        private void kryptonTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                kryptonButton1_Click(this, new EventArgs());
            }

        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                kryptonButton1_Click(this, new EventArgs());
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            passHidden.Visible = false;
            passShown.Visible = true;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PasswordChar = '●';
        }

        private void passShown_Click(object sender, EventArgs e)
        {
            passHidden.Visible = true;
            passShown.Visible = false;
            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.PasswordChar = '\0';
        }
    }
}
