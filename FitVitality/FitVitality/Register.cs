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
using Microsoft.VisualBasic.ApplicationServices;

namespace FitVitality
{
    public partial class Register : KryptonForm
    {
        public int userID;
        public bool opened;
        private bool mouseDown;
        private Point lastLocation;
        private bool user_Error = false;
        private bool password_Error = false;
        private bool email_Error = false;
        private bool passMatch_Error = false;
        private string connectionstring = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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

                string query = "INSERT INTO UserData (Username, Email, Password) OUTPUT INSERTED.UserID VALUES (@Username, @Email, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userID = Convert.ToInt32(result);
                    }
                }
            }
            if (userID != null)
            {
                string query = "INSERT INTO UserSettings (UserID) VALUES (@UserID)";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.ExecuteNonQuery();
                    }
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
        private bool containsLetters(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
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
        private bool isValidUsername(string str)
        {
            if (str.Length >= 4)
            {
                if (Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$"))
                {
                    return true;
                }
            }
            return false;
        }
        private bool isValidPassword(string str)
        {
            if (str.Length >= 8)
            {
                if (containsLetters(str))
                {
                    if (containsDigit(str))
                    {
                        if (hasSpecialChar(str))
                        {
                            return true;
                        }
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
            string regUsername = textBoxUsername.Text;
            string regEmail = textBoxEmail.Text;
            string regPassword = textBoxPass.Text;
            string confirmPass = textBoxRepass.Text;
            if (isValidUsername(regUsername))
            {
                user_Error = false;
                validUsername = true;
                usrmark.Visible = false;
                userError.Visible = false;
                textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            else
            {
                user_Error = true;
                usrmark.Visible = true;
                textBoxUsername.Text = "";
                textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if (isValidEmail(regEmail))
            {
                email_Error = false;
                validEmail = true;
                emailmark.Visible = false;
                emailPanel.Visible = false;
                textBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                textBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            else
            {
                email_Error = true;
                emailmark.Visible = true;
                emailError.Image = Properties.Resources.email21;
                emailErrorLabel.Location = new Point(49, 5);
                emailError.Location = new Point(45, 0);
                emailError.Size = new Size(107, 27);
                emailErrorLabel.Size = new Size(96, 14);
                emailErrorLabel.Text = "Email is not valid!";
                textBoxEmail.Text = "";
                textBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if (isValidPassword(regPassword))
            {
                password_Error = false;
                validPassword = true;
                passmark.Visible = false;
                passPanel.Visible = false;
                textBoxPass.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                textBoxPass.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);

            }
            else
            {
                password_Error = true;
                passmark.Visible = true;
                textBoxPass.Text = "";
                textBoxPass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxPass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if ((regPassword != confirmPass) || confirmPass == "")
            {
                passMatch_Error = true;
                repassmark.Visible = true;
                textBoxRepass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxRepass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            else
            {
                passMatch_Error = false;
                passMatch = true;
                repassmark.Visible = false;
                repassErrorPanel.Visible = false;
                textBoxRepass.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                textBoxRepass.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            if (validEmail && validPassword && validUsername && passMatch)
            {
                if (!userExists(regUsername))
                {
                    usrmark.Visible = false;
                    textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                    textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                    if (!emailExists(regEmail))
                    {
                        email_Error = false;
                        emailmark.Visible = false;
                        textBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                        textBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
                        createUser(regUsername, regEmail, regPassword);

                        accCreated.Enabled = true;

                        textBoxUsername.Text = "";
                        textBoxEmail.Text = "";
                        textBoxPass.Text = "";
                        textBoxRepass.Text = "";
                    }
                    else
                    {
                        email_Error = true;
                        emailError.Image = Properties.Resources.repassError;
                        emailErrorLabel.Location = new Point(14, 5);
                        emailError.Location = new Point(0, 0);
                        emailError.Size = new Size(151, 27);
                        emailErrorLabel.Size = new Size(122, 14);
                        emailmark.Visible = true;
                        emailErrorLabel.Text = "Email is already in use!";
                        textBoxEmail.Text = "";
                        textBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                        textBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                    }
                }
                else
                {
                    usrmark.Visible = true;
                    userError.Visible = true;
                    usrError.Text = "Username is already in use!";
                    textBoxUsername.Text = "";
                    textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                    textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelAccCreated.Width += 2;
            if (panelAccCreated.Width >= 168)
            {
                accCreated.Stop();
                accCreated.Enabled = false;
            }
        }

        private void tbusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                kryptonButton1_Click(this, new EventArgs());
            }
        }

        private void tbemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                kryptonButton1_Click(this, new EventArgs());
            }
        }

        private void tbpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                kryptonButton1_Click(this, new EventArgs());
            }
        }

        private void tbrepass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                kryptonButton1_Click(this, new EventArgs());
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (user_Error)
            {
                userError.Visible = true;
                usrError.Text = "Username must contain only digits or letters!";
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (user_Error)
            {
                userError.Visible = false;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (email_Error)
            {
                emailPanel.Visible = true;
            }

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (email_Error)
            {
                emailPanel.Visible = false;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (password_Error)
            {
                passPanel.Visible = true;
                passErrorLabel.Text = "Enter a combination of at least 8 letters, numbers and symbols!";
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (password_Error)
            {
                passPanel.Visible = false;
            }
        }

        private void textBoxRepass_Enter(object sender, EventArgs e)
        {
            if (passMatch_Error)
            {
                repassErrorPanel.Visible = true;
                repassErrorLabel.Text = "Passwords do not match!";
            }
        }

        private void textBoxRepass_Leave(object sender, EventArgs e)
        {
            if (passMatch_Error)
            {
                repassErrorPanel.Visible = false;
            }
        }
    }
}