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
        const string connectionString = @"Server=tcp: mssql-163547-0.cloudclusters.net, 11009;Initial Catalog=FitVitality;User ID=Member;Password=Userpass123!;Connection Timeout=30;TrustServerCertificate=True";
        public Register()
        {
            InitializeComponent();
        }

        //Метод за проверка дали потребителя вече съществува
        private bool userExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        //Метод за проверка дали имейла вече съществува
        private bool emailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        //Метод за създаване на потребител
        private void createUser(string username, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO WeeklyInformation (UserID) VALUES (@UserID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.ExecuteNonQuery();
                    }
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO UserNutrition (UserID) VALUES (@UserID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.ExecuteNonQuery();
                    }
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Workouts (UserID) VALUES (@UserID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.ExecuteNonQuery();
                    }
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO UserSettings (UserID) VALUES (@UserID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        //Метод за проверка дали паролата съдържа цифра
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

        //Метод за проверка дали паролата съдържа специален символ
        private static bool hasSpecialChar(string str)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var c in specialChar)
            {
                if (str.Contains(c)) return true;
            }

            return false;
        }
        //Метод за проверка дали паролата съдържа буква
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
        //Метод за проверка дали имейла е валиден
        private bool isValidEmail(string str)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(str);
        }

        //Метод за проверка дали потребителското име е валидно
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

        //Метод за проверка дали паролата е валидна
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

        //Метод за регистрация на потребител
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
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
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    emailErrorLabel.Text = "Email is not valid!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    emailErrorLabel.Text = "Невалиден мейл!";
                }
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

                passMatch_Error = false;
                passMatch = true;
                repassmark.Visible = false;
                repassErrorPanel.Visible = false;
                textBoxRepass.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                textBoxRepass.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            else
            {
                password_Error = true;
                passmark.Visible = true;
                textBoxPass.Text = "";
                textBoxPass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxPass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);

                passMatch_Error = true;
                repassmark.Visible = true;
                textBoxRepass.Text = "";
                textBoxRepass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxRepass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if (password_Error)
            {
                passMatch_Error = false;
                passMatch = true;
                repassmark.Visible = false;
                repassErrorPanel.Visible = false;
                textBoxRepass.Text = "";
                textBoxRepass.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                textBoxRepass.StateCommon.Border.Color2 = Color.FromArgb(177, 192, 214);
            }
            else
            {
                passMatch_Error = true;
                repassmark.Visible = true;
                textBoxRepass.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                textBoxRepass.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
            }
            if ((regPassword != confirmPass) || confirmPass == "")
            {
                passMatch_Error = true;
                repassmark.Visible = true;
                textBoxRepass.Text = "";
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
                        emailError.Location = new Point(0, 0);
                        emailError.Size = new Size(151, 27);
                        emailErrorLabel.Size = new Size(122, 14);
                        emailmark.Visible = true;
                        if (cfg.Read("Language", "SETTINGS") == "en")
                        {
                            emailErrorLabel.Location = new Point(14, 5);
                            emailErrorLabel.Text = "Email is already in use!";
                        }
                        if (cfg.Read("Language", "SETTINGS") == "bg")
                        {
                            emailErrorLabel.Location = new Point(16, 5);
                            emailErrorLabel.Text = "Имейлът вече е зает!";
                        }
                        textBoxEmail.Text = "";
                        textBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                        textBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                    }
                }
                else
                {
                    usrmark.Visible = true;
                    userError.Visible = true;
                    if (cfg.Read("Language", "SETTINGS") == "en")
                    {
                        usrError.Text = "Username is already in use!";
                    }
                    if (cfg.Read("Language", "SETTINGS") == "bg")
                    {
                        usrError.Text = "Името вече съществува!";
                    }
                    textBoxUsername.Text = "";
                    textBoxUsername.StateCommon.Border.Color1 = Color.FromArgb(255, 0, 42);
                    textBoxUsername.StateCommon.Border.Color2 = Color.FromArgb(255, 0, 42);
                }
            }

        }

        //Метод при зареждане на формата
        private void Register_Load(object sender, EventArgs e)
        {
            opened = true;
            this.Location = loadingScreen.ActiveForm.Location;
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                registerLabel.Text = "REGISTER";
                usrError.Text = "Username must contain only digits or letters!";
                usrLabel.Text = "Username";
                textBoxUsername.CueHint.CueHintText = "Enter username";
                emailError.Text = "Email is not valid!";
                emailLabel.Text = "Email";
                textBoxEmail.CueHint.CueHintText = "Enter email";
                passError.Text = "Enter a combination of at least 8\nletters, numbers and symbols!";
                passLabel.Text = "Password";
                textBoxPass.CueHint.CueHintText = "Enter password";
                repassError.Text = "Passwords do not match!";
                repassLabel.Text = "Confirm password";
                textBoxRepass.CueHint.CueHintText = "Re-enter password";
                buttonRegister.Text = "Register";
                haveAnAccButton.Text = "Already have an account?";
                labelcreated.Text = "Account created successfully.";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                registerLabel.Text = "РЕГИСТРАЦИЯ";
                usrError.Text = "Трябва да съдържа само букви и цифри!";
                usrLabel.Text = "Потребителско име";
                textBoxUsername.CueHint.CueHintText = "Въведи потребителско име";
                emailError.Text = "Невалиден мейл!";
                emailLabel.Text = "Имейл";
                textBoxEmail.CueHint.CueHintText = "Въведи имейл";
                passError.Text = "Въведи комбинация от поне 8 букви,\nцифри и символи!";
                passLabel.Text = "Парола";
                textBoxPass.CueHint.CueHintText = "Въведи парола";
                repassError.Text = "Паролите не съвпадат!";
                repassLabel.Text = "Потвърди парола";
                textBoxRepass.CueHint.CueHintText = "Въведи парола";
                buttonRegister.Text = "Регистрация";
                haveAnAccButton.Text = "Вече имаш акаунт?";
                labelcreated.Text = "Акаунтът е създаден.";
            }
        }

        //Метод при затваряне на формата
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
            var cfg = new Config("FitVitality.ini");
            if (user_Error)
            {
                userError.Visible = true;
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    usrError.Text = "Username must contain only digits or letters!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    usrError.Text = "Трябва да съдържа само букви и цифри!";
                }
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
            var cfg = new Config("FitVitality.ini");
            if (password_Error)
            {
                passPanel.Visible = true;
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    passErrorLabel.Text = "Enter a combination of at least 8 letters, numbers and symbols!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    passErrorLabel.Text = "Въведи комбинация от поне 8 цифри, букви и символи!";
                }
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
            var cfg = new Config("FitVitality.ini");
            if (passMatch_Error)
            {
                repassErrorPanel.Visible = true;
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    repassErrorLabel.Text = "Passwords do not match!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    repassErrorLabel.Text = "Паролите не съвпадат!";
                }
            }
        }

        private void textBoxRepass_Leave(object sender, EventArgs e)
        {
            if (passMatch_Error)
            {
                repassErrorPanel.Visible = false;
            }
        }

        private void logo2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void logo2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void logo2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void logo1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void logo1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void logo1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void passShown1_Click(object sender, EventArgs e)
        {
            passHidden1.Visible = true;
            passShown1.Visible = false;
            textBoxPass.UseSystemPasswordChar = false;
            textBoxPass.PasswordChar = '\0';
        }

        private void passHidden1_Click(object sender, EventArgs e)
        {
            passHidden1.Visible = false;
            passShown1.Visible = true;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.PasswordChar = '●';
        }

        private void passShown2_Click(object sender, EventArgs e)
        {
            passHidden2.Visible = true;
            passShown2.Visible = false;
            textBoxRepass.UseSystemPasswordChar = false;
            textBoxRepass.PasswordChar = '\0';
        }

        private void passHidden2_Click(object sender, EventArgs e)
        {
            passHidden2.Visible = false;
            passShown2.Visible = true;
            textBoxRepass.UseSystemPasswordChar = true;
            textBoxRepass.PasswordChar = '●';
        }

        private void passmark_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (password_Error)
            {
                passPanel.Visible = true;
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    passErrorLabel.Text = "Enter a combination of at least 8 letters, numbers and symbols!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    passErrorLabel.Text = "Въведи комбинация от поне 8 цифри, букви и символи!";
                }
            }
        }

        private void passmark_MouseLeave(object sender, EventArgs e)
        {
            if (password_Error)
            {
                passPanel.Visible = false;
            }
        }

        private void repassmark_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (passMatch_Error)
            {
                repassErrorPanel.Visible = true;
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    repassErrorLabel.Text = "Passwords do not match!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    repassErrorLabel.Text = "Паролите не съвпадат!";
                }
            }
        }

        private void repassmark_MouseLeave(object sender, EventArgs e)
        {
            if (passMatch_Error)
            {
                repassErrorPanel.Visible = false;
            }
        }

        private void emailmark_MouseEnter(object sender, EventArgs e)
        {
            if (email_Error)
            {
                emailPanel.Visible = true;
            }
        }

        private void emailmark_MouseLeave(object sender, EventArgs e)
        {
            if (email_Error)
            {
                emailPanel.Visible = false;
            }
        }

        private void usrmark_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (user_Error)
            {
                userError.Visible = true;
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    usrError.Text = "Username must contain only digits or letters!";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    usrError.Text = "Трябва да съдържа само букви и цифри!";
                }
            }
        }

        private void usrmark_MouseLeave(object sender, EventArgs e)
        {
            if (user_Error)
            {
                userError.Visible = false;
            }
        }
    }
}