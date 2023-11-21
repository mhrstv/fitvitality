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


namespace FitVitality
{
    public partial class home : Form
    {
        double percentages;
        private float currentRotation;
        private readonly Image originalImage;
        List<Panel> active_tabs = new List<Panel>();
        private string name;
        private int age;
        private string gender;
        private string weight;
        private string height;
        private string goal;
        private string unit_selection;
        private string _userID;
        public double bmi;
        string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public home(string userID)
        {
            InitializeComponent();
            _userID = userID;
            originalImage = Properties.Resources.arrowFinal;
            currentRotation = 0;
            UpdateRotation();
            rotationTimer.Interval = 17;
            rotationTimer.Tick += RotationTimer_Tick;
            rotationTimer.Start();
        }
        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            if (currentRotation <= Math.Round(((percentages / 100) * 180), 0))
            {
                currentRotation += 2;
            }
            else if (currentRotation >= percentages)
                rotationTimer.Enabled = false;
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            Image rotatedImage = RotateImage(originalImage, currentRotation);
            arrow.Image = rotatedImage;
        }

        private Image RotateImage(Image image, float angle)
        {
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }
            return rotatedImage;
        }
        private void home_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
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
                            name = reader["Name"].ToString();
                            age = int.Parse(reader["Age"].ToString());
                            if (reader["Gender"].ToString() == "Male")
                            {
                                gender = "Male";
                            }
                            else
                            {
                                gender = "Female";
                            }
                            weight = reader["Weight"].ToString();
                            height = reader["Height"].ToString();
                            if (reader["Goal"].ToString() == "Cut")
                            {
                                goal = "Cut";
                            }
                            else if (reader["Goal"].ToString() == "Maintain")
                            {
                                goal = "Maintain";
                            }
                            else
                            {
                                goal = "Bulk";
                            }
                        }
                    }
                }
            }
            bmi = Math.Round((Convert.ToDouble(weight) / Math.Pow(Convert.ToDouble(height) / 100, 2)), 2);
            bmi_label.Text = $"BMI = {bmi.ToString()} kg/m²";
            percentages = Math.Round((((double)bmi - 16) / 24) * 100, 0);
            if (percentages < 0)
                percentages = 0;
            else if (percentages > 100)
                percentages = 100;
            if (age < 20 && age > 2)
            {

            }
            else
            {
                if (bmi < 16)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Severe Thinness)";
                    bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                }
                else if (bmi >= 16 && bmi < 17)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Moderate Thinness)";
                    bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                }
                else if (bmi >= 17 && bmi < 18.5)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Mild Thinness)";
                    bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Normal)";
                    bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Overweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Obese Class I)";
                    bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Obese Class II)";
                    bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                }
                else
                {
                    bmicategory_label.Text = "(" + percentages.ToString() + "% - Obese Class III)";
                    bmicategory_label.ForeColor = Color.FromArgb(138, 1, 1);
                }
            }
        }

        private void home_Activated(object sender, EventArgs e)
        {
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
                            name = reader["Name"].ToString();
                            age = int.Parse(reader["Age"].ToString());
                            if (reader["Gender"].ToString() == "Male")
                            {
                                gender = "Male";
                            }
                            else
                            {
                                gender = "Female";
                            }
                            weight = reader["Weight"].ToString();
                            height = reader["Height"].ToString();
                            if (reader["Goal"].ToString() == "Cut")
                            {
                                goal = "Cut";
                            }
                            else if (reader["Goal"].ToString() == "Maintain")
                            {
                                goal = "Maintain";
                            }
                            else
                            {
                                goal = "Bulk";
                            }
                        }
                    }
                }
            }
            bmi = Math.Round((Convert.ToDouble(weight) / Math.Pow(Convert.ToDouble(height) / 100, 2)), 2);
            bmi_label.Text = $"BMI = {bmi.ToString()} kg/m²";
            if (age < 20 && age > 2)
            {

            }
            else
            {
                if (bmi < 16)
                {
                    bmicategory_label.Text = "(Severe Thinness)";
                    bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                }
                else if (bmi >= 16 && bmi < 17)
                {
                    bmicategory_label.Text = "(Moderate Thinness)";
                    bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                }
                else if (bmi >= 17 && bmi < 18.5)
                {
                    bmicategory_label.Text = "(Mild Thinness)";
                    bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    bmicategory_label.Text = "(Normal)";
                    bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    bmicategory_label.Text = "(Overweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    bmicategory_label.Text = "(Obese Class I)";
                    bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    bmicategory_label.Text = "(Obese Class II)";
                    bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                }
                else
                {
                    bmicategory_label.Text = "(Obese Class III)";
                    bmicategory_label.ForeColor = Color.FromArgb(138, 1, 1);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bmi_label_Click(object sender, EventArgs e)
        {

        }

        private void rotationTimer_Tick_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
