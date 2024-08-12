﻿using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.Logging;
using System.Collections;
using Azure;

namespace FitVitality
{
    public partial class Settings : Form
    {
        private string dbName;
        private string dbEmail;
        private int dbAge;
        private string dbGender;
        private double dbWeight;
        private double dbHeight;
        private string dbGoal;
        public string _userID;
        private PictureBox pb;
        const string connectionString = @"Server=tcp: mssql-163547-0.cloudclusters.net, 11009;Initial Catalog=FitVitality;User ID=Member;Password=Userpass123!;Connection Timeout=30;TrustServerCertificate=True";
        public Settings(string userID)
        {
            InitializeComponent();
            _userID = userID;

            pb = new PictureBox();
            deleteAccPanel.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }

        //Метод за показване само на панела за изтриване на акаунт
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            beta.Visible = false;
            deleteAccPanel.Visible = true;
            deleteAccPanel.Height = 174;
            deleteAccPanel.Width = 341;
            deleteAccountButton.Visible = false;
            appSettings_label.Visible = false;
            accSettings_label.Visible = false;
            langLabel.Visible = false;
            languageComboBox.Visible = false;
            themeLabel.Visible = false;
            nameLabel.Visible = false;
            ageLabel.Visible = false;
            genderLabel.Visible = false;
            goalLabel.Visible = false;
            weightLabel.Visible = false;
            heightLabel.Visible = false;
            nameTextBox.Visible = false;
            ageTextBox.Visible = false;
            genderComboBox.Visible = false;
            weightTextBox.Visible = false;
            heightTextBox.Visible = false;
            goalComboBox.Visible = false;
            buttonSave.Visible = false;
            vLine3.Visible = false;
            themeComboBox.Visible = false;
            emailTextBox.Visible = false;
            changePasswordButton.Visible = false;
        }

        //Метод за зареждане на формата
        private void Settings_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                languageComboBox.Items.Clear();
                languageComboBox.Items.Add("Български");
                languageComboBox.Items.Add("Английски");
                languageComboBox.SelectedItem = "Български";
                appSettings_label.Text = "Настройки на програма";
                appSettings_label.Location = new Point(appSettings_label.Location.X + 10, appSettings_label.Location.Y);
                accSettings_label.Text = "Настройки на акаунт";
                langLabel.Text = "Език";
                langLabel.Location = new Point(65, langLabel.Location.Y);
                themeLabel.Text = "Тема";
                changePasswordLabel.Text = "Смени парола";
                oldPasswordLabel.Text = "Въведи стара парола";
                newPasswordLabel.Text = "Въведи нова парола";
                confirmNewPasswordLabel.Text = "Потвърди нова парола";
                changePasswordConfirmButton.Text = "Потвърди";
                errorLabel.Text = "Грешка";
                settingErrorLabel.Text = "Въвели сте грешни данни!";
                changePasswordButton.Text = "Смени\nПарола";
                buttonSave.Text = "Запази\nНастройки";
                deleteAccountButton.Text = "Изтрий Акаунт";
                nameLabel.Text = "Име";
                ageLabel.Text = "Години";
                emailLabel.Text = "Имейл";
                genderLabel.Text = "Пол";
                weightLabel.Text = "Тегло";
                heightLabel.Text = "Височина";
                goalLabel.Text = "Цел";
                confirmLabel1.Text = "Напиши \"ПОТВЪРЖДАВАМ\" за да потвърдиш, изтриването на акаунта.";
                confirmLabel2.Text = "ВНИМАНИЕ: Всички твои данни ще изчезнат ЗАВИНАГИ.";
                textBoxConfirm.CueHint.CueHintText = "ПОТВЪРЖДАВАМ";
                confirmButton.Text = "Потвърждавам";
                genderComboBox.Items.Clear();
                genderComboBox.Items.Add("Мъж");
                genderComboBox.Items.Add("Жена");
                goalComboBox.Items.Clear();
                goalComboBox.Items.Add("Сваляне");
                goalComboBox.Items.Add("Поддържане");
                goalComboBox.Items.Add("Покачване");
                if (cfg.Read("Theme", "SETTINGS") == "light")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Тъмна");
                    themeComboBox.Items.Add("Светла");
                    themeComboBox.SelectedItem = "Светла";
                }
                else if (cfg.Read("Theme", "SETTINGS") == "dark")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Тъмна");
                    themeComboBox.Items.Add("Светла");
                    themeComboBox.SelectedItem = "Тъмна";
                }
                beta.Image = Properties.Resources.Beta_Buttonbg;
            }
            else if (cfg.Read("Language", "SETTINGS") == "en")
            {
                languageComboBox.Items.Clear();
                languageComboBox.Items.Add("Bulgarian");
                languageComboBox.Items.Add("English");
                languageComboBox.SelectedItem = "English";
                appSettings_label.Text = "App Settings";
                accSettings_label.Text = "Account Settings";
                langLabel.Text = "Language";
                langLabel.Location = new Point(48, langLabel.Location.Y);
                themeLabel.Text = "Theme";
                changePasswordLabel.Text = "Change Password";
                oldPasswordLabel.Text = "Enter old password";
                newPasswordLabel.Text = "Enter new password";
                confirmNewPasswordLabel.Text = "Confirm new password";
                changePasswordConfirmButton.Text = "Confirm";
                errorLabel.Text = "Error";
                settingErrorLabel.Text = "You have input incorrect data!";
                changePasswordButton.Text = "Change\nPassword";
                buttonSave.Text = "Save\nSettings";
                deleteAccountButton.Text = "Delete Account";
                nameLabel.Text = "Name";
                ageLabel.Text = "Age";
                emailLabel.Text = "Email";
                genderLabel.Text = "Gender";
                weightLabel.Text = "Weight";
                heightLabel.Text = "Height";
                goalLabel.Text = "Goal";
                confirmLabel1.Text = "Type \"CONFIRM\" to confirm that you want to DELETE your account.";
                confirmLabel2.Text = "WARNING: All your data and stored information will be GONE.";
                textBoxConfirm.CueHint.CueHintText = "CONFIRM";
                confirmButton.Text = "Confirm";
                genderComboBox.Items.Clear();
                genderComboBox.Items.Add("Male");
                genderComboBox.Items.Add("Female");
                goalComboBox.Items.Clear();
                goalComboBox.Items.Add("Cut");
                goalComboBox.Items.Add("Maintain");
                goalComboBox.Items.Add("Bulk");
                if (cfg.Read("Theme", "SETTINGS") == "light")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Dark");
                    themeComboBox.Items.Add("Light");
                    themeComboBox.SelectedItem = "Light";
                }
                else if (cfg.Read("Theme", "SETTINGS") == "dark")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Dark");
                    themeComboBox.Items.Add("Light");
                    themeComboBox.SelectedItem = "Dark";
                }
                beta.Image = Properties.Resources.Beta_Button;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UserSettings WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nameTextBox.Text = reader["Name"].ToString();
                            ageTextBox.Text = reader["Age"].ToString();
                            if (cfg.Read("Language", "SETTINGS") == "en")
                            {
                                if (reader["Gender"].ToString() == "Male")
                                {
                                    genderComboBox.SelectedItem = "Male";
                                }
                                else
                                {
                                    genderComboBox.SelectedItem = "Female";
                                }
                            }
                            if (cfg.Read("Language", "SETTINGS") == "bg")
                            {
                                if (reader["Gender"].ToString() == "Male")
                                {
                                    genderComboBox.SelectedItem = "Мъж";
                                }
                                else
                                {
                                    genderComboBox.SelectedItem = "Жена";
                                }
                            }
                            weightTextBox.Text = reader["Weight"].ToString();
                            heightTextBox.Text = reader["Height"].ToString();
                            if (cfg.Read("Language", "SETTINGS") == "en")
                            {
                                if (reader["Goal"].ToString() == "Cut")
                                {
                                    goalComboBox.SelectedItem = "Cut";
                                }
                                else if (reader["Goal"].ToString() == "Maintain")
                                {
                                    goalComboBox.SelectedItem = "Maintain";
                                }
                                else
                                {
                                    goalComboBox.SelectedItem = "Bulk";
                                }
                            }
                            if (cfg.Read("Language", "SETTINGS") == "bg")
                            {
                                if (reader["Goal"].ToString() == "Cut")
                                {
                                    goalComboBox.SelectedItem = "Сваляне";
                                }
                                else if (reader["Goal"].ToString() == "Maintain")
                                {
                                    goalComboBox.SelectedItem = "Поддържане";
                                }
                                else
                                {
                                    goalComboBox.SelectedItem = "Покачване";
                                }
                            }
                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Email FROM UserData WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emailTextBox.Text = reader["Email"].ToString();
                        }
                    }
                }
            }
        }

        //Метод за проверка на въведен текст в текстовото поле за потвърждение
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (textBoxConfirm.Text == "ПОТВЪРЖДАВАМ")
                {
                    confirmButton.Enabled = true;
                }
                else
                {
                    confirmButton.Enabled = false;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (textBoxConfirm.Text == "CONFIRM")
                {
                    confirmButton.Enabled = true;
                }
                else
                {
                    confirmButton.Enabled = false;
                }
            }
        }

        //Метод за изтриване на акаунт
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM UserData WHERE UserID = @ID; DELETE FROM UserSettings WHERE UserID = @ID; DELETE FROM Workouts WHERE UserID = @ID; DELETE FROM UserNutrition WHERE UserID = @ID; DELETE FROM WeeklyInformation WHERE UserID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        deleteAccPanel.Visible = false;
                        Login login = new Login();
                        login.Show();
                        this.ParentForm.Hide();

                    }
                }
                connection.Close();
            }
        }

        private bool validName(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            if (name.Length < 3 || name.Length > 20)
            {
                return false;
            }
            return true;
        }
        private bool validAge(int age)
        {
            if (age < 13 || age > 120)
            {
                return false;
            }
            return true;
        }
        private bool validWeight(double weight)
        {
            if (weight < 30.00 && weight > 400.00)
            {
                return false;
            }
            return true;
        }
        private bool validHeight(double height)
        {
            if (height < 50 && height > 300)
            {
                return false;
            }
            return true;
        }
        private bool validEmail(string email)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(email);
        }
        //Метод за запазване на настройките
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            try
            {
                dbName = nameTextBox.Text.ToString();
                dbEmail = emailTextBox.Text.ToString();
                dbAge = int.Parse(ageTextBox.Text);
                dbWeight = double.Parse(weightTextBox.Text);
                dbHeight = double.Parse(heightTextBox.Text);
                if (genderComboBox.SelectedItem == "Male" || genderComboBox.SelectedItem == "Мъж")
                {
                    dbGender = "Male";
                }
                else
                {
                    dbGender = "Female";
                }
                if (goalComboBox.SelectedItem == "Cut" || goalComboBox.SelectedItem == "Сваляне")
                {
                    dbGoal = "Cut";
                }
                else if (goalComboBox.SelectedItem == "Maintain" || goalComboBox.SelectedItem == "Поддържане")
                {
                    dbGoal = "Maintain";
                }
                else
                {
                    dbGoal = "Bulk";
                }
                if (validName(dbName) && validAge(dbAge) && validWeight(dbWeight) && validHeight(dbHeight) && validEmail(dbEmail) && dbGender != "" && dbGoal != "")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE UserSettings " +
                                   "SET Name = @Name, Age = @Age, Gender = @Gender, Weight = @Weight, Height = @Height, Goal = @Goal " +
                                   "WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int age = dbAge;
                            double weight = dbWeight;
                            weight = Math.Round(weight, 1);
                            double height = dbHeight;
                            command.Parameters.AddWithValue("@UserID", _userID);
                            command.Parameters.AddWithValue("@Name", dbName);
                            command.Parameters.AddWithValue("@Email", dbEmail);
                            command.Parameters.AddWithValue("@Age", age);
                            command.Parameters.AddWithValue("@Gender", dbGender);
                            command.Parameters.AddWithValue("@Weight", weight);
                            command.Parameters.AddWithValue("@Height", height);
                            command.Parameters.AddWithValue("@Goal", dbGoal);
                            command.ExecuteNonQuery();
                        }
                    }
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE UserData " +
                                   "SET Email = @Email " +
                                   "WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", _userID);
                            command.Parameters.AddWithValue("@Email", dbEmail);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    errorPanel.Visible = true;
                }
            }
            catch (FormatException)
            {
                errorPanel.Visible = true;
            }

        }
        //Метод за промяна на езика
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (languageComboBox.SelectedItem == "Български" || languageComboBox.SelectedItem == "Bulgarian")
            {
                cfg.Write("Language", "bg", "SETTINGS");
                if (languageComboBox.SelectedItem == "Bulgarian")
                {
                    languageComboBox.Items.Clear();
                    languageComboBox.Items.Add("Български");
                    languageComboBox.Items.Add("Английски");
                    languageComboBox.SelectedItem = "Български";
                }
                appSettings_label.Text = "Настройки на програма";
                appSettings_label.Location = new Point(appSettings_label.Location.X + 10, appSettings_label.Location.Y);
                accSettings_label.Text = "Настройки на акаунт";
                langLabel.Text = "Език";
                langLabel.Location = new Point(65, langLabel.Location.Y);
                themeLabel.Text = "Тема";
                changePasswordLabel.Text = "Смени парола";
                oldPasswordLabel.Text = "Въведи стара парола";
                newPasswordLabel.Text = "Въведи нова парола";
                confirmNewPasswordLabel.Text = "Потвърди нова парола";
                changePasswordConfirmButton.Text = "Потвърди";
                errorLabel.Text = "Грешка";
                settingErrorLabel.Text = "Въвели сте грешни данни!";
                changePasswordButton.Text = "Смени\nПарола";
                buttonSave.Text = "Запази\nНастройки";
                deleteAccountButton.Text = "Изтрий Акаунт";
                nameLabel.Text = "Име";
                ageLabel.Text = "Години";
                emailLabel.Text = "Имейл";
                genderLabel.Text = "Пол";
                weightLabel.Text = "Тегло";
                heightLabel.Text = "Височина";
                goalLabel.Text = "Цел";
                confirmLabel1.Text = "Напиши \"ПОТВЪРЖДАВАМ\" за да потвърдиш, изтриването на акаунта.";
                confirmLabel2.Text = "ВНИМАНИЕ: Всички твои данни ще изчезнат ЗАВИНАГИ.";
                textBoxConfirm.CueHint.CueHintText = "ПОТВЪРЖДАВАМ";
                confirmButton.Text = "Потвърди";

                genderComboBox.Items.Clear();
                genderComboBox.Items.Add("Мъж");
                genderComboBox.Items.Add("Жена");
                goalComboBox.Items.Clear();
                goalComboBox.Items.Add("Сваляне");
                goalComboBox.Items.Add("Поддържане");
                goalComboBox.Items.Add("Покачване");
                if (themeComboBox.SelectedItem == "Light")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Тъмна");
                    themeComboBox.Items.Add("Светла");
                    themeComboBox.SelectedItem = "Светла";
                }
                else if (themeComboBox.SelectedItem == "Dark")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Тъмна");
                    themeComboBox.Items.Add("Светла");
                    themeComboBox.SelectedItem = "Тъмна";
                }
                beta.Image = Properties.Resources.Beta_Buttonbg;
            }
            else if (languageComboBox.SelectedItem == "English" || languageComboBox.SelectedItem == "Английски")
            {
                cfg.Write("Language", "en", "SETTINGS");
                if (languageComboBox.SelectedItem == "Английски")
                {
                    languageComboBox.Items.Clear();
                    languageComboBox.Items.Add("Bulgarian");
                    languageComboBox.Items.Add("English");
                    languageComboBox.SelectedItem = "English";
                }
                appSettings_label.Text = "App Settings";
                accSettings_label.Text = "Account Settings";
                langLabel.Text = "Language";
                langLabel.Location = new Point(48, langLabel.Location.Y);
                themeLabel.Text = "Theme";
                changePasswordLabel.Text = "Change Password";
                oldPasswordLabel.Text = "Enter old password";
                newPasswordLabel.Text = "Enter new password";
                confirmNewPasswordLabel.Text = "Confirm new password";
                changePasswordConfirmButton.Text = "Confirm";
                errorLabel.Text = "Error";
                settingErrorLabel.Text = "You have input incorrect data!";
                changePasswordButton.Text = "Change\nPassword";
                buttonSave.Text = "Save\nSettings";
                deleteAccountButton.Text = "Delete Account";
                nameLabel.Text = "Name";
                ageLabel.Text = "Age";
                emailLabel.Text = "Email";
                genderLabel.Text = "Gender";
                weightLabel.Text = "Weight";
                heightLabel.Text = "Height";
                goalLabel.Text = "Goal";
                confirmLabel1.Text = "Type \"CONFIRM\" to confirm that you want to DELETE your account.";
                confirmLabel2.Text = "WARNING: All your data and stored information will be GONE.";
                textBoxConfirm.CueHint.CueHintText = "CONFIRM";
                confirmButton.Text = "Confirm";

                genderComboBox.Items.Clear();
                genderComboBox.Items.Add("Male");
                genderComboBox.Items.Add("Female");
                goalComboBox.Items.Clear();
                goalComboBox.Items.Add("Cut");
                goalComboBox.Items.Add("Maintain");
                goalComboBox.Items.Add("Bulk");
                if (themeComboBox.SelectedItem == "Светла")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Dark");
                    themeComboBox.Items.Add("Light");
                    themeComboBox.SelectedItem = "Light";
                }
                else if (themeComboBox.SelectedItem == "Тъмна")
                {
                    themeComboBox.Items.Clear();
                    themeComboBox.Items.Add("Dark");
                    themeComboBox.Items.Add("Light");
                    themeComboBox.SelectedItem = "Dark";
                }
                beta.Image = Properties.Resources.Beta_Button;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UserSettings WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (cfg.Read("Language", "SETTINGS") == "en")
                            {
                                if (reader["Gender"].ToString() == "Male")
                                {
                                    genderComboBox.SelectedItem = "Male";
                                }
                                else
                                {
                                    genderComboBox.SelectedItem = "Female";
                                }
                            }
                            if (cfg.Read("Language", "SETTINGS") == "bg")
                            {
                                if (reader["Gender"].ToString() == "Male")
                                {
                                    genderComboBox.SelectedItem = "Мъж";
                                }
                                else
                                {
                                    genderComboBox.SelectedItem = "Жена";
                                }
                            }
                            if (cfg.Read("Language", "SETTINGS") == "en")
                            {
                                if (reader["Goal"].ToString() == "Cut")
                                {
                                    goalComboBox.SelectedItem = "Cut";
                                }
                                else if (reader["Goal"].ToString() == "Maintain")
                                {
                                    goalComboBox.SelectedItem = "Maintain";
                                }
                                else
                                {
                                    goalComboBox.SelectedItem = "Bulk";
                                }
                            }
                            if (cfg.Read("Language", "SETTINGS") == "bg")
                            {
                                if (reader["Goal"].ToString() == "Cut")
                                {
                                    goalComboBox.SelectedItem = "Сваляне";
                                }
                                else if (reader["Goal"].ToString() == "Maintain")
                                {
                                    goalComboBox.SelectedItem = "Поддържане";
                                }
                                else
                                {
                                    goalComboBox.SelectedItem = "Покачване";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void errorClose_Click(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
        }
        private void errorClose_MouseEnter(object sender, EventArgs e)
        {
            errorClose.BackColor = Color.IndianRed;
        }

        private void errorClose_MouseLeave(object sender, EventArgs e)
        {
            errorClose.BackColor = Color.WhiteSmoke;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            beta.Visible = false;
            changePasswordPanel.Visible = true;
            deleteAccountButton.Visible = false;
            appSettings_label.Visible = false;
            accSettings_label.Visible = false;
            langLabel.Visible = false;
            languageComboBox.Visible = false;
            themeLabel.Visible = false;
            nameLabel.Visible = false;
            ageLabel.Visible = false;
            genderLabel.Visible = false;
            goalLabel.Visible = false;
            weightLabel.Visible = false;
            heightLabel.Visible = false;
            nameTextBox.Visible = false;
            ageTextBox.Visible = false;
            genderComboBox.Visible = false;
            weightTextBox.Visible = false;
            heightTextBox.Visible = false;
            goalComboBox.Visible = false;
            buttonSave.Visible = false;
            vLine3.Visible = false;
            themeComboBox.Visible = false;
            emailTextBox.Visible = false;
            changePasswordButton.Visible = false;
        }

        //Метод за смяна на парола
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool validOldPass = false;
            string oldPass = oldPasswordTextBox.Text;
            string newPass = newPasswordTextBox.Text;
            string confirmPass = confirmPasswordTextBox.Text;
            if (oldPass == "")
            {
                oldPasswordTextBox.BorderColor = Color.Red;
            }
            else
            {
                oldPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
            if (newPass == "")
            {
                newPasswordTextBox.BorderColor = Color.Red;
            }
            else
            {
                newPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
            if (confirmPass == "")
            {
                confirmPasswordTextBox.BorderColor = Color.Red;
            }
            else
            {
                newPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
            }
            if (oldPass != "" && newPass != "" && confirmPass != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT UserID, Password FROM UserData WHERE Password = @Password AND UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", oldPass);
                        command.Parameters.AddWithValue("@UserID", _userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPass = reader["Password"].ToString();
                                if (dbPass == oldPass)
                                {
                                    validOldPass = true;
                                    oldPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
                                }
                                else
                                {
                                    oldPasswordTextBox.BorderColor = Color.Red;
                                }
                            }
                        }
                    }
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (validOldPass)
                    {
                        oldPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
                        connection.Open();
                        string query = "UPDATE UserData SET Password = @Password WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            if (isValidPassword(newPass))
                            {
                                newPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
                                if (newPass == confirmPass)
                                {
                                    command.Parameters.AddWithValue("@Password", newPass);
                                    command.Parameters.AddWithValue("@UserID", _userID);
                                    command.ExecuteNonQuery();
                                    confirmPasswordTextBox.BorderColor = Color.FromArgb(213, 218, 223);
                                    changePasswordPanel.Visible = false;
                                    oldPasswordTextBox.Text = "";
                                    newPasswordTextBox.Text = "";
                                    confirmPasswordTextBox.Text = "";
                                }
                                else
                                {
                                    confirmPasswordTextBox.BorderColor = Color.Red;
                                }
                            }
                            else
                            {
                                newPasswordTextBox.BorderColor = Color.Red;
                            }
                        }
                    }
                }
            }
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            beta.Visible = true;
            changePasswordPanel.Visible = false;
            deleteAccountButton.Visible = true;
            appSettings_label.Visible = true;
            accSettings_label.Visible = true;
            langLabel.Visible = true;
            languageComboBox.Visible = true;
            themeLabel.Visible = true;
            nameLabel.Visible = true;
            ageLabel.Visible = true;
            genderLabel.Visible = true;
            goalLabel.Visible = true;
            weightLabel.Visible = true;
            heightLabel.Visible = true;
            nameTextBox.Visible = true;
            ageTextBox.Visible = true;
            genderComboBox.Visible = true;
            weightTextBox.Visible = true;
            heightTextBox.Visible = true;
            goalComboBox.Visible = true;
            buttonSave.Visible = true;
            vLine3.Visible = true;
            themeComboBox.Visible = true;
            emailTextBox.Visible = true;
            changePasswordButton.Visible = true;
        }

        private void changePasswordClose_MouseEnter(object sender, EventArgs e)
        {
            changePasswordClose.BackColor = Color.IndianRed;
        }

        private void changePasswordClose_MouseLeave(object sender, EventArgs e)
        {
            changePasswordClose.BackColor = Color.WhiteSmoke;
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (themeComboBox.SelectedItem == "Light" || themeComboBox.SelectedItem == "Светла")
            {
                cfg.Write("Theme", "light", "SETTINGS");
            }
            else
                cfg.Write("Theme", "dark", "SETTINGS");
        }

        //Метод за затваряне на панела за изтриване на акаунт
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            deleteAccPanel.Visible = false;
            beta.Visible = true;
            deleteAccountButton.Visible = true;
            appSettings_label.Visible = true;
            accSettings_label.Visible = true;
            langLabel.Visible = true;
            languageComboBox.Visible = true;
            themeLabel.Visible = true;
            nameLabel.Visible = true;
            ageLabel.Visible = true;
            genderLabel.Visible = true;
            goalLabel.Visible = true;
            weightLabel.Visible = true;
            heightLabel.Visible = true;
            nameTextBox.Visible = true;
            ageTextBox.Visible = true;
            genderComboBox.Visible = true;
            weightTextBox.Visible = true;
            heightTextBox.Visible = true;
            goalComboBox.Visible = true;
            buttonSave.Visible = true;
            vLine3.Visible = true;
            themeComboBox.Visible = true;
            emailTextBox.Visible = true;
            changePasswordButton.Visible = true;
        }

        private void closeDeleteAccPanel_MouseEnter(object sender, EventArgs e)
        {
            closeDeleteAccPanel.BackColor = Color.IndianRed;
        }

        private void closeDeleteAccPanel_MouseLeave(object sender, EventArgs e)
        {
            closeDeleteAccPanel.BackColor = Color.WhiteSmoke;
        }
    }
}