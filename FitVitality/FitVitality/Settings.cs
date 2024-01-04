using Krypton.Toolkit;
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

namespace FitVitality
{
    public partial class Settings : Form
    {
        private string dbName;
        private string dbAge;
        private string dbGender;
        private string dbWeight;
        private string dbHeight;
        private string dbGoal;
        public string _userID;
        private PictureBox pb;
        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Settings(string userID)
        {
            InitializeComponent();
            _userID = userID;

            pb = new PictureBox();
            deleteAccPanel.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            deleteAccPanel.Visible = true;
            confirmPanel.Visible = true;
            closeDAPanel.Visible = true;
            deleteAccPanel.Height = 174;
            deleteAccPanel.Width = 341;
            deleteAccButton.Visible = false;
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
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");

            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                languageComboBox.SelectedItem = "Bulgarian";
            }
            else if (cfg.Read("Language", "SETTINGS") == "en")
            {
                languageComboBox.SelectedItem = "English";
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
                            if (reader["Gender"].ToString() == "Male")
                            {
                                genderComboBox.SelectedItem = "Male";
                            }
                            else
                            {
                                genderComboBox.SelectedItem = "Female";
                            }
                            weightTextBox.Text = reader["Weight"].ToString();
                            heightTextBox.Text = reader["Height"].ToString();
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
                    }
                }
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM UserData WHERE UserID = @ID; DELETE FROM UserSettings WHERE UserID = @ID; DELETE FROM Workouts WHERE UserID = @ID";
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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            deleteAccPanel.Visible = false;
            deleteAccButton.Visible = true;
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
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.DimGray;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(74, 74, 74);
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
            return true;
        }
        private bool validAge(string age)
        {
            foreach (char c in age)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            if (int.Parse(age) < 13 || int.Parse(age) > 120)
            {
                return false;
            }
            return true;
        }
        private bool validWeight(string weight)
        {
            foreach (char c in weight)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            if (double.Parse(weight) < 30.00 && double.Parse(weight) > 400.00)
            {
                return false;
            }
            return true;
        }
        private bool validHeight(string height)
        {
            foreach (char c in height)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            if (double.Parse(height) < 50 && double.Parse(height) > 300)
            {
                return false;
            }
            return true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            dbName = nameTextBox.Text.ToString();
            dbAge = ageTextBox.Text;
            dbWeight = weightTextBox.Text;
            dbHeight = heightTextBox.Text;
            if (genderComboBox.SelectedItem == "Male")
            {
                dbGender = "Male";
            }
            else
            {
                dbGender = "Female";
            }
            if (goalComboBox.SelectedItem == "Cut")
            {
                dbGoal = "Cut";
            }
            else if (goalComboBox.SelectedItem == "Maintain")
            {
                dbGoal = "Maintain";
            }
            else
            {
                dbGoal = "Bulk";
            }
            if (validName(dbName) && validAge(dbAge) && validWeight(dbWeight) && validHeight(dbHeight) && dbGender != "" && dbGoal != "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE UserSettings " +
                               "SET Name = @Name, Age = @Age, Gender = @Gender, Weight = @Weight, Height = @Height, Goal = @Goal " +
                               "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int age = int.Parse(dbAge);
                        double weight = double.Parse(dbWeight);
                        weight = Math.Round(weight, 1);
                        int height = int.Parse(dbHeight);
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@Name", dbName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", dbGender);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@Height", height);
                        command.Parameters.AddWithValue("@Goal", dbGoal);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                errorPanel.Visible = true;
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (languageComboBox.SelectedItem == "Bulgarian")
            {
                cfg.Write("Language", "bg", "SETTINGS");
            }
            else if (languageComboBox.SelectedItem == "English")
            {
                cfg.Write("Language", "en", "SETTINGS");
            }
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorClose_Click(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
        }

        private void errorClose_MouseHover(object sender, EventArgs e)
        {

        }

        private void errorClose_MouseEnter(object sender, EventArgs e)
        {
            errorClose.BackColor = Color.IndianRed;
        }

        private void errorClose_MouseLeave(object sender, EventArgs e)
        {
            errorClose.BackColor = Color.WhiteSmoke;
        }
    }
}
