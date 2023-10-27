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
        private bool uppercaseLetters(string str)
        {
            foreach (var c in str)
            {
                if (Char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }
        private bool lowercaseLetters(string str)
        {
            foreach (var c in str)
            {
                if (Char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
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
        private bool isValidEmail(string str)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(str);
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
        private bool underscoreRepeated(string str)
        {


            return false;
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string regUsername = kryptonTextBox1.Text;
            string regEmail = kryptonTextBox3.Text;
            string regPassword = kryptonTextBox2.Text;
            string confirmPass = kryptonTextBox4.Text;
            if (regUsername.Length >= 4)
            {
                if (Regex.IsMatch(regUsername, @"^[a-zA-Z0-9_]+$"))
                {
                    if (underscoreRepeated(regUsername))
                    {
                        if (regPassword.Length >= 8)
                        {
                            if (uppercaseLetters(regPassword))
                            {
                                if (lowercaseLetters(regPassword))
                                {
                                    if (containsDigit(regPassword))
                                    {
                                        if (hasSpecialChar(regPassword))
                                        {
                                            if (regPassword == confirmPass)
                                            {
                                                if (isValidEmail(regEmail))
                                                {
                                                    if (!userExists(regUsername))
                                                    {
                                                        if (!emailExists(regEmail))
                                                        {
                                                            createUser(regUsername, regEmail, regPassword);
                                                            MessageBox.Show("User successfully registered!");
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
                                                            MessageBox.Show("Email is already in use!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Username is already in use!");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Email is not valid!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Passwords do not match!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Your password should contain atleast 1 symbol!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your password should contain atleast 1 number!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Your password should contain atleast 1 lowercase character!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your password should contain atleast 1 uppercase character!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your password should be atleast 8 characters long!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Do not use more than 1 underscore in your username!");
                    }
                }
                else
                {
                    MessageBox.Show("Please use only english letters or numbers!");
                }
            }
            else
            {
                MessageBox.Show("Your username should be atleast 4 characters long!");
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
    }
}