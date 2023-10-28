using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Microsoft.Identity.Client;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace FitVitality
{
    public partial class Register : KryptonForm
    {
        public bool opened;
        private bool mouseDown;
        private Point lastLocation;
        private string connectionstring = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Register()
        {
            InitializeComponent();
        }
        private bool userExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                string query = "SELECT 1 FROM UserData WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
        private bool emailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                string query = "SELECT 1 FROM UserData WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private void createUser(string username, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                string query = "INSERT INTO UserData (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                }
            }
        }
        private bool containsDigit(string str)
        {
            foreach (var c in str)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool hasSpecialChar(string str)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var c in specialChar)
            {
                if (str.Contains(c)) return true;
            }

            return false;
        }
        private bool underscore_SingleUse(string str)
        {
            if (str.IndexOf('_') != str.LastIndexOf('_'))
            {
                return true;
            }
            return true;
        }
        private bool isValidEmail(string str)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(str);
        }
        private bool isValidUsername(string str)
        {
            if (str.Length >= 4)
            {
                if (Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$"))
                {
                    if (underscore_SingleUse(str))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool isValidPassword(string str)
        {
            if (str.Length >= 8)
            {
                if (containsDigit(str))
                {
                    if (hasSpecialChar(str))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            bool validUsername = false;
            bool validEmail = false;
            bool validPassword = false;
            bool passMatch = false;
            string regUsername = tbusername.Text;
            string regEmail = tbemail.Text;
            string regPassword = tbpass.Text;
            string confirmPass = tbrepass.Text;
            if (isValidUsername(regUsername))
            {
                validUsername = true;
                usrmark.Visible = false;
                userError.Visible = false;
                tbusername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                tbusername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            else
            {
                usrmark.Visible = true;
                userError.Visible = true;
                usrLabel.Text = "Username must contain only digits, numbers and an underscore!";
                tbusername.Text = "";
                tbusername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                tbusername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if (isValidEmail(regEmail))
            {
                validEmail = true;
                emailmark.Visible = false;
                emailError.Visible = false;
                tbemail.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                tbemail.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            else
            {
                emailmark.Visible = true;
                emailError.Visible = true;
                emailLabel.Text = "Email is not valid!";
                tbemail.Text = "";
                tbemail.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                tbemail.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if (isValidPassword(regPassword))
            {
                validPassword = true;
                passmark.Visible = false;
                passError.Visible = false;
                tbpass.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                tbpass.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);

            }
            else
            {
                passmark.Visible = true;
                passError.Visible = true;
                passLabel.Text = "Enter a combination of at least 8 letters, numbers and symbols!";
                tbpass.Text = "";
                tbpass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                tbpass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if ((regPassword != confirmPass) || confirmPass == "")
            {
                repassmark.Visible = true;
                repassError.Visible = true;
                tbrepass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                tbrepass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);

            }
            else
            {
                passMatch = true;
                repassmark.Visible = false;
                repassError.Visible = false;
                tbrepass.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                tbrepass.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            if(validEmail && validPassword && validUsername && passMatch)
            {
                if (!userExists(regUsername))
                {
                    usrmark.Visible = false;
                    tbusername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                    tbusername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                    if (!emailExists(regEmail))
                    {
                        emailmark.Visible = false;
                        tbemail.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                        tbemail.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                        createUser(regUsername, regEmail, regPassword);
                        MessageBox.Show("Account successfully created!");
                        for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                        {
                            this.Opacity = i;
                        }
                        Login welcomeScreen = new Login();
                        welcomeScreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        emailmark.Visible = true;
                        emailError.Visible = true;
                        emailLabel.Text = "Email is already in use!";
                        tbemail.Text = "";
                        tbemail.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                        tbemail.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                    }
                }
                else
                {
                    usrmark.Visible = true;
                    userError.Visible = true;
                    usrLabel.Text = "Username is already in use!";
                    tbusername.Text = "";
                    tbusername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                    tbusername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                }
            }
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            opened = true;
            this.Location = loadingScreen.ActiveForm.Location;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            for (double i = this.Opacity; i >= 0; i = i - 0.00002)
            {
                this.Opacity = i;
            }
            Login welcomeScreen = new Login();
            welcomeScreen.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Register_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity += 0.00004;
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}