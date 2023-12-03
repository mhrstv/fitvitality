using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
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
    public partial class Calculators : Form
    {
        string activity;
        double neck;
        double waist;
        double hips;
        double bodyFat;
        double bfp;
        double bmr;
        double sedentaryBMR;
        double exerciseBMR;
        double intenseBMR;
        double percentages;
        double percentagesStudents;
        private float currentRotation;
        private readonly Image originalImage;
        private string name;
        private int age;
        private string gender;
        private string weight;
        private string height;
        private string goal;
        private string unit_selection;
        public double bmi;
        string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public string _userID;
        public Calculators(string userID)
        {
            InitializeComponent();
            _userID = userID;
            originalImage = Properties.Resources.arrowFinal;
            currentRotation = 0;
            UpdateRotation();
            rotationTimer.Interval = 17;
            rotationTimer.Tick += rotationTimer_Tick;
            rotationTimer.Start();
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
        private void bmi_openButton_Click(object sender, EventArgs e)
        {
            bmiCalcPanel.Size = new Size(547, 270);
            bmiCalcPanel.Visible = true;
            calorie_buttonOpen.Enabled = false;
            macro_buttonOpen.Enabled = false;
            idealweight_buttonOpen.Enabled = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            bmiCalcPanel.Visible = false;
            calorie_buttonOpen.Enabled = true;
            macro_buttonOpen.Enabled = true;
            idealweight_buttonOpen.Enabled = true;
        }

        private void rotationTimer_Tick(object sender, EventArgs e)
        {
            if (bmiCalcPanel.Visible == true)
            {
                if (age > 2 && age <= 20)
                {
                    if (currentRotation <= Math.Round(((percentagesStudents / 100) * 180), 0))
                    {
                        currentRotation += 2;
                    }
                    else if (currentRotation >= percentages)
                        rotationTimer.Enabled = false;
                    UpdateRotation();
                }
                else if (age > 20)
                {
                    if (currentRotation <= Math.Round(((percentages / 100) * 180), 0))
                    {
                        currentRotation += 2;
                    }
                    else if (currentRotation >= percentages)
                        rotationTimer.Enabled = false;
                    UpdateRotation();
                }
            }
        }
        private void Calculators_Load(object sender, EventArgs e)
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

            //BMI
            bmi = Math.Round((Convert.ToDouble(weight) / Math.Pow(Convert.ToDouble(height) / 100, 2)), 1);
            bmiPanelLabel.Text = $"BMI = {bmi.ToString()} kg/m²";
            percentages = Math.Round((((double)bmi - 16) / 24) * 100, 0);
            percentagesStudents = Math.Round(((((double)bmi - 17) / 20) * 2) * 100, 0);
            if (percentages < 0)
                percentages = 0;
            if (percentages > 100)
                percentages = 100;
            if (percentagesStudents < 0)
                percentagesStudents = 0;
            if (percentagesStudents > 100)
                percentagesStudents = 100;
            if (age <= 20 && age > 2)
            {
                bmiPicture.Image = Properties.Resources.bmiMalki;
                if (percentagesStudents <= 5)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Underweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(228, 155, 42);
                }
                if (percentagesStudents <= 85 && percentagesStudents > 5)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Healthy weight)";
                    bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                }
                if (percentagesStudents <= 95 && percentagesStudents > 85)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - At risk of overweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                }
                if (percentagesStudents >= 95)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Overweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(185, 6, 6);
                }
            }
            else
            {
                bmiPicture.Image = Properties.Resources.bmiFinal1;
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

            //BMR
            if (gender == "Male")
            {
                bmr = Math.Round(10 * Convert.ToDouble(weight) + 6.25 * Convert.ToDouble(height) - 5 * age + 5, 0);
            }
            if (gender == "Female")
            {
                bmr = Math.Round(10 * Convert.ToDouble(weight) + 6.25 * Convert.ToDouble(height) - 5 * age + 161, 0);
            }
            sedentaryBMR = bmr + 350;
            exerciseBMR = bmr + 810;
            intenseBMR = bmr + 1600;
            currentBMR.Text = $"BMR = {bmr.ToString()} calories/day";
            sedentaryLabel.Text = $"Sedentary =  ≈{sedentaryBMR.ToString()} calories/day";
            exerciseLabel.Text = $"Exercise =  ≈{exerciseBMR.ToString()} calories/day";
            intExrLabel.Text = $"Intense exercise =  ≈{intenseBMR.ToString()} calories/day";


            //Body Fat Percentage
            if (gender == "Male")
            {
                hipsTb.Enabled = false;
                bodyFatScale.Image = Properties.Resources.bodyFatMan;
                essentialLabel.Location = new Point(255, 118);
                athletesLabel.Location = new Point(303, 118);
                fitnessLabel.Location = new Point(347, 118);
                averageLabel.Location = new Point(380, 118);
                obeseLabel.Location = new Point(447, 118);
            }
            if (gender == "Female")
            {
                hipsTb.Enabled = true;
                bodyFatScale.Image = Properties.Resources.bodyFatWoman;
                essentialLabel.Location = new Point(302, 118);
                athletesLabel.Location = new Point(350, 118);
                fitnessLabel.Location = new Point(394, 118);
                averageLabel.Location = new Point(432, 118);
                obeseLabel.Location = new Point(477, 118);
            }
            neckTb.TextChanged += checkBodyFatInputs;
            waistTb.TextChanged += checkBodyFatInputs;
            hipsTb.TextChanged += checkBodyFatInputs;

            //Calorie Calculator
            if (activityComboBox.SelectedItem == "Sedentary")
                activity = "Sedentary";
            if (activityComboBox.SelectedItem == "Exercise")
                activity = "Exercise";
            if (activityComboBox.SelectedItem == "Intense exercise")
                activity = "Intense exercise";
        }
        private void checkBodyFatInputs(object sender, EventArgs e)
        {
            if (gender == "Male")
            {
                bodyFatCalculateButton.Enabled = !string.IsNullOrEmpty(neckTb.Text) && !string.IsNullOrEmpty(waistTb.Text);
            }
            if (gender == "Female")
            {
                bodyFatCalculateButton.Enabled = !string.IsNullOrEmpty(neckTb.Text) && !string.IsNullOrEmpty(waistTb.Text) && !string.IsNullOrEmpty(hipsTb.Text);
            }
        }

        private void Calculators_Activated(object sender, EventArgs e)
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

            bmiPanelLabel.Text = $"BMI = {bmi.ToString()} kg/m²";
            percentages = Math.Round((((double)bmi - 16) / 24) * 100, 0);
            percentagesStudents = Math.Round(((((double)bmi - 17) / 20) * 2) * 100, 0);
            if (percentages < 0)
                percentages = 0;
            if (percentages > 100)
                percentages = 100;
            if (percentagesStudents < 0)
                percentagesStudents = 0;
            if (percentagesStudents > 100)
                percentagesStudents = 100;
            if (age <= 20 && age > 2)
            {
                bmiPicture.Image = Properties.Resources.bmiMalki;
                if (percentagesStudents <= 5)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Underweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(228, 155, 42);
                }
                if (percentagesStudents <= 85 && percentagesStudents > 5)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Healthy weight)";
                    bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                }
                if (percentagesStudents <= 95 && percentagesStudents > 85)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - At risk of overweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                }
                if (percentagesStudents >= 95)
                {
                    bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Overweight)";
                    bmicategory_label.ForeColor = Color.FromArgb(185, 6, 6);
                }
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

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            buttonCloseBMI.BackColor = Color.IndianRed;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseBMI.BackColor = Color.White;
        }

        private void bmrBorders_Click(object sender, EventArgs e)
        {

        }

        private void bmr_buttonOpen_Click(object sender, EventArgs e)
        {
            bmrCalcPanel.Size = new Size(547, 270);
            bmrCalcPanel.Visible = true;
            calorie_buttonOpen.Enabled = false;
            macro_buttonOpen.Enabled = false;
            idealweight_buttonOpen.Enabled = false;
        }

        private void buttonCloseBMR_Click(object sender, EventArgs e)
        {
            bmrCalcPanel.Visible = false;
            calorie_buttonOpen.Enabled = true;
            macro_buttonOpen.Enabled = true;
            idealweight_buttonOpen.Enabled = true;
        }

        private void buttonCloseBMR_MouseEnter(object sender, EventArgs e)
        {
            buttonCloseBMR.BackColor = Color.IndianRed;
        }

        private void buttonCloseBMR_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseBMR.BackColor = Color.White;
        }

        private void bodyFatButtonClose_Click(object sender, EventArgs e)
        {
            bodyFatCalcPanel.Visible = false;
            calorie_buttonOpen.Enabled = true;
            macro_buttonOpen.Enabled = true;
            idealweight_buttonOpen.Enabled = true;
        }

        private void bodyFatButtonClose_MouseEnter(object sender, EventArgs e)
        {
            bodyFatButtonClose.BackColor = Color.IndianRed;
        }

        private void bodyFatButtonClose_MouseLeave(object sender, EventArgs e)
        {
            bodyFatButtonClose.BackColor = Color.White;
        }

        private void bodyFatCalculateButton_Click(object sender, EventArgs e)
        {
            if (gender == "Male")
            {
                neck = double.Parse(neckTb.Text);
                waist = double.Parse(waistTb.Text);
            }
            if (gender == "Female")
            {
                neck = double.Parse(neckTb.Text);
                waist = double.Parse(waistTb.Text);
                hips = double.Parse(hipsTb.Text);
            }
            if (gender == "Male")
            {
                bodyFat = Math.Round((495 / (1.0324 - 0.19077 * Math.Log10(waist - neck) + 0.15456 * Math.Log10(Convert.ToDouble(height)))) - 450, 0);
            }
            if (gender == "Female")
            {
                bodyFat = Math.Round((495 / (1.29579 - 0.35004 * Math.Log10(waist + hips - neck) + 0.22100 * Math.Log10(Convert.ToDouble(height)))) - 450, 0);
            }
            if (bodyFat < 0)
                bodyFat = 0;
            if (bodyFat > 100)
                bodyFat = 100;
            bodyFatPercentage.Location = new Point(Convert.ToInt16(Math.Round((bodyFat / 40 * 254) - 4, 0)), 0);
            bodyFatArrow.Location = new Point(Convert.ToInt16(Math.Round(bodyFat / 40 * 254, 0)), 15);
            currentBFP.Text = $"Body Fat Percentage = {bodyFat.ToString()}%";
            bodyFatPercentage.Text = bodyFat.ToString() + "%";
        }

        private void bodyfat_buttonOpen_Click(object sender, EventArgs e)
        {
            bodyFatCalcPanel.Size = new Size(547, 270);
            bodyFatCalcPanel.Visible = true;
            calorie_buttonOpen.Enabled = false;
            macro_buttonOpen.Enabled = false;
            idealweight_buttonOpen.Enabled = false;
        }

        private void neckTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            calorieCalcPanel.Visible = false;
            calorie_buttonOpen.Enabled = true;
            macro_buttonOpen.Enabled = true;
            idealweight_buttonOpen.Enabled = true;
        }

        private void calorieButtonClose_MouseEnter(object sender, EventArgs e)
        {
            calorieButtonClose.BackColor = Color.IndianRed;
        }

        private void calorieButtonClose_MouseLeave(object sender, EventArgs e)
        {
            calorieButtonClose.BackColor = Color.White;
        }

        private void calorie_buttonOpen_Click(object sender, EventArgs e)
        {
            calorieCalcPanel.Size = new Size(547, 270);
            calorieCalcPanel.Visible = true;
            calorie_buttonOpen.Enabled = false;
            macro_buttonOpen.Enabled = false;
            idealweight_buttonOpen.Enabled = false;
        }
    }
}
