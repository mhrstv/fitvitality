using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitVitality
{
    public partial class Calculators : Form
    {
        double neck;
        double waist;
        double hips;
        double bodyFat;
        double bmr;
        double sedentaryBMR;
        double exerciseBMR13;
        double exerciseBMR45;
        double DailyBMR34;
        double intenseBMR67;
        double veryIntenseBMR;
        double percentages;
        double percentagesStudents;
        private float currentRotation;
        private readonly Image originalImage;
        private int age;
        private string gender;
        private string weight;
        private string height;
        private string goal;
        private string unit_selection;
        public double bmi;

        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = @"Server=tcp: mssql-163547-0.cloudclusters.net, 10009;Initial Catalog=FitVitality;User ID=Member;Password=Userpass123!;Connection Timeout=30;TrustServerCertificate=True";
        //private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public string _userID;

        public void CalorieCalculation(double activity)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                lossLabel.Text = $"Weight loss - {Math.Round(activity * 0.75, 0)} calories/day";
                mildLossLabel.Text = $"Mild weight loss - {Math.Round(activity * 0.88, 0)} calories/day";
                maintainLabel.Text = $"Maintain weight - {Math.Round(activity, 0)} calories/day";
                mildGainLabel.Text = $"Mild weight gain - {Math.Round(activity * 1.12, 0)} calories/day";
                gainLabel.Text = $"Gain weight - {Math.Round(activity * 1.25, 0)} calories/day";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                lossLabel.Text = $"Отслабване - {Math.Round(activity * 0.75, 0)} калории/ден";
                mildLossLabel.Text = $"Леко отслабване - {Math.Round(activity * 0.88, 0)} калории/ден";
                maintainLabel.Text = $"Поддържане - {Math.Round(activity, 0)} калории/ден";
                mildGainLabel.Text = $"Леко покачване - {Math.Round(activity * 1.12, 0)} калории/ден";
                gainLabel.Text = $"Покачване - {Math.Round(activity * 1.25, 0)} калории/ден";
            }
        }
        public void MacroBalanced(double activity)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.25 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.5 / 4:f1}g/day";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity = activity;
                    calorieIntake.Text = $"Current calorie intake per day is {activity.ToString()}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.25 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.5 / 4:f1}g/day";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.25 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.5 / 4:f1}g/day";
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.25 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.5 / 4:f1}г/ден";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity = activity;
                    calorieIntake.Text = $"Дневното приемане на калории е {activity.ToString()}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.25 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.5 / 4:f1}г/ден";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.25 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.5 / 4:f1}г/ден";
                }
            }
        }
        public void MacroLowFat(double activity)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.2 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.55 / 4:f1}g/day";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity = activity;
                    calorieIntake.Text = $"Current calorie intake per day is {activity.ToString()}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.2 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.55 / 4:f1}g/day";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.2 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.55 / 4:f1}g/day";
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.2 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.55 / 4:f1}г/ден";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity = activity;
                    calorieIntake.Text = $"Дневното приемане на калории е {activity.ToString()}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.2 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.55 / 4:f1}г/ден";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.25 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.2 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.55 / 4:f1}г/ден";
                }

            }
        }
        public void MacroLowCarb(double activity)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.3 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.3 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.4 / 4:f1}g/day";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity = activity;
                    calorieIntake.Text = $"Current calorie intake per day is {activity.ToString()}.";
                    protein.Text = $"{activity * 0.3 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.3 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.4 / 4:f1}g/day";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.3 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.3 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.4 / 4:f1}g/day";
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.3 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.3 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.4 / 4:f1}г/ден";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity = activity;
                    calorieIntake.Text = $"Дневното приемане на калории е {activity.ToString()}.";
                    protein.Text = $"{activity * 0.3 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.3 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.4 / 4:f1}г/ден";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.3 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.3 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.4 / 4:f1}г/ден";
                }
            }
        }
        public void MacroHighProtein(double activity)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.35 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.2 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.45 / 4:f1}g/day";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity = activity;
                    calorieIntake.Text = $"Current calorie intake per day is {activity.ToString()}.";
                    protein.Text = $"{activity * 0.35 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.2 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.45 / 4:f1}g/day";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(368, 93);
                    carbohydrates.Location = new Point(356, 130);
                    fat.Location = new Point(336, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Current calorie intake per day is {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.35 / 4:f1}g/day";
                    fat.Text = $"{activity * 0.2 / 9:f1}g/day";
                    carbohydrates.Text = $"{activity * 0.45 / 4:f1}g/day";
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (goal == "Cut")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(0.75, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 0.88, 0)}.";
                    protein.Text = $"{activity * 0.35 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.2 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.45 / 4:f1}г/ден";
                }
                if (goal == "Maintain")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity = activity;
                    calorieIntake.Text = $"Дневното приемане на калории е {activity.ToString()}.";
                    protein.Text = $"{activity * 0.35 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.2 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.45 / 4:f1}г/ден";
                }
                if (goal == "Bulk")
                {
                    protein.Location = new Point(375, 93);
                    carbohydrates.Location = new Point(405, 130);
                    fat.Location = new Point(381, 168);
                    activity *= Math.Round(1.25, 0);
                    calorieIntake.Text = $"Дневното приемане на калории е {Math.Round(activity * 1.12, 0)}.";
                    protein.Text = $"{activity * 0.35 / 4:f1}г/ден";
                    fat.Text = $"{activity * 0.2 / 9:f1}г/ден";
                    carbohydrates.Text = $"{activity * 0.45 / 4:f1}г/ден";
                }
            }
        }
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
            buttonOpenCalorie.Enabled = false;
            buttonOpenMacro.Enabled = false;
            buttonOpenIdealWeight.Enabled = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            bmiCalcPanel.Visible = false;
            buttonOpenCalorie.Enabled = true;
            buttonOpenMacro.Enabled = true;
            buttonOpenIdealWeight.Enabled = true;
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
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                calculators_label.Text = "Calculators";
                bodyfat_label.Text = "Body Fat";
                calorie_label.Text = "Calorie";
                macro_label.Text = "Macro";
                idealweight_label.Text = "Ideal Weight";
                buttonOpenBMI.Text = "Open";
                buttonOpenBMR.Text = "Open";
                buttonOpenBodyFat.Text = "Open";
                buttonOpenCalorie.Text = "Open";
                buttonOpenMacro.Text = "Open";
                buttonOpenIdealWeight.Text = "Open";
                bmiCalcLabel.Text = "BMI Calculator";
                bmicalc_label.Text = "BMI Calculator";
                bmiDescription.Text = "The Body Mass Index is a \r\nmeasurement " +
                    "of a\r\nperson's leanness based on\r\ntheir height and weight.  \r\n" +
                    "Specifically, the value obtained \r\nfrom the calculation of BMI is \r\nused " +
                    "to categorize whether a \r\nperson is underweight, normal \r\nweight, overweight, " +
                    "or obese \r\ndepending on what range the \r\nvalue falls between.\r\n";
                bmrCalcLabel.Text = "BMR Calculator";
                bmrDescription.Text = "Your Basal Metabolic Rate \r\nis the number of " +
                    "calories \r\nyou burn as your body performs \r\nbasic (basal) life-sustaining " +
                    "\r\nfunction that are based on your \r\nactivity level (you can change \r\nthat " +
                    "from the settings).\r\n";
                activityDescriptions.Text = "Sedentary - little or no exercise (<30mins)\r\n" +
                    "Exercise - 4, 5 times a week (~40-50mins)\r\nIntense exercise - daily (2+ hours) \r\n";
                dailyCalsLabel.Text = "Daily calories based on activity level:";
                bodyFatLabel.Text = "Body Fat Calculator";
                bodyFatDescription.Text = "Body fat percentage is \r\ndefined as the percentage \r\nof " +
                    "your body that consists \r\nof fat. Measuring body fat \r\nis key to assessing " +
                    "whether \r\na person is overweight, \r\nobese or at a healthy weight.\r\n";
                extraMeasurementsLabel.Text = "We need extra measurements for this calculation.\r\n";
                neckLabel.Text = "Neck (cm)";
                waistLabel.Text = "Waist (cm)";
                hipsLabel.Text = "Hips (women only)";
                bodyFatCalculateButton.Text = "Calculate";
                essentialLabel.Text = "Essential";
                athletesLabel.Text = "Athlete";
                fitnessLabel.Text = "Fitness";
                averageLabel.Text = "Average";
                obeseLabel.Text = "Obese";
                calorieCalcLabel.Text = "Calorie Calculator";
                extraMeasurementsL.Text = "We need information about your activity level.";
                activityLabel.Text = "Activity level";
                calorieCalcButton.Text = "Calculate";
                calorieDescription.Text = "The Calorie Calculator is very \r\nsimilar to the " +
                    "Basal Metabolic \r\nRate calculator. This calculator \r\ncan provide some simple" +
                    " \r\nguidelines for gaining, losing \r\nor maintaining weight based\r\non your " +
                    "activity level.\r\n";
                activityComboBox.Items.Clear();
                activityComboBox.Items.Add("Sedentary");
                activityComboBox.Items.Add("Light");
                activityComboBox.Items.Add("Moderate");
                activityComboBox.Items.Add("Active");
                activityComboBox.Items.Add("Very active");
                activityComboBox.Items.Add("Extra active");
                macroCalcLabel.Text = "Macro Calculator";
                balancedButton.Text = "Balanced";
                lowFatButton.Text = "Low fat";
                lowCarbsButton.Text = "Low carbs";
                highProteinButton.Text = "High protein";
                macroCalcDescription.Text = "A macro calculator is a tool\r\nthat helps " +
                    "individuals \r\ndetermine their \r\nmacronutrient intake based \r\non their weight, " +
                    "height, \r\nactivity, and goals. It \r\ncalculates the amounts of \r\nproteins, " +
                    "fats, and carbohydrates \r\nthat they should consume.\r\n";
                activityLevelNeedLabel.Text = "We will need your activity level for this calculation:";
                actLevelLabel.Text = "Activity level:";
                changeGoalLabel.Location = new Point(319, 238);
                changeGoalLabel.Text = "You can change your goal from the settings!\r\n";
                macroCalcButton.Text = "Calculate";
                proteinLabel.Text = "Protein - ";
                carbsLabel.Text = "Carbs - ";
                fatLabel.Text = "Fat - ";
                activityComboBoxMacro.Items.Clear();
                activityComboBoxMacro.Items.Add("Sedentary");
                activityComboBoxMacro.Items.Add("Light");
                activityComboBoxMacro.Items.Add("Moderate");
                activityComboBoxMacro.Items.Add("Active");
                activityComboBoxMacro.Items.Add("Very active");
                activityComboBoxMacro.Items.Add("Extra active");
                idealWeightCalcLabel.Text = "Ideal Weight Calculator";
                idealWeightDescription.Text = "The ideal weight calculator is \r\na tool designed to " +
                    "estimate \r\na healthy weight range for \r\nindividuals based on factors \r\nsuch " +
                    "as height and gender.\r\n";
                idealWeightLabel1.Text = "Your ideal weight, based on \r\nthe popular " +
                    "Robinson's \r\nformula is\r\n";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                calculators_label.Text = "Калкулатори";
                bodyfat_label.Text = "Телесна мазнина";
                calorie_label.Text = "Калории";
                macro_label.Text = "Макро";
                idealweight_label.Text = "Идеално тегло";
                buttonOpenBMI.Text = "Отвори";
                buttonOpenBMR.Text = "Отвори";
                buttonOpenBodyFat.Text = "Отвори";
                buttonOpenCalorie.Text = "Отвори";
                buttonOpenMacro.Text = "Отвори";
                buttonOpenIdealWeight.Text = "Отвори";
                bmiCalcLabel.Text = "BMI Калкулатор";
                bmicalc_label.Text = "BMI Калкулатор";
                bmiDescription.Text = "Индексът на телесната маса е\r\nизмерване " +
                    "на\r\nслабостта на човек\r\nспоред ръстта и теглото му.\r\n" +
                    "По конкретно се използва\r\nза категоризиране дали дадено\r\nлице е с поднормено, нормално\r\nили наднормено тегло.";
                bmiDescription.Location = new Point(bmiDescription.Location.X, bmiDescription.Location.Y +20);
                bmrCalcLabel.Text = "BMR Калкулатор";
                bmrDescription.Text = "Вашата базална метаболитна\r\nскорост е броят калории,\r\n" +
                    "които изгаряте през деня\r\nспоред нивото ви на активност\r\n(можете да промените това\r\nот настройките).";
                activityDescriptions.Text = "Заседналост - почти никакво движение(<30мин)\r\n" +
                    "Тренировки - 4, 5 пъти в седмицата(~40-50мин)\r\nТежки тренировки - всеки ден (2+ часа) \r\n";
                dailyCalsLabel.Text = "Дневни калории според активност:";
                bodyFatLabel.Text = "Калкулатор на телесна мазнина";
                bodyFatDescription.Text = "Измерването на телесните\r\nмазнини е от ключово " +
                    "значение\r\nза оценката дали дадено\r\nлице е с " +
                    "наднормено\r\nтегло, със затлъстяване или\r\nсъс здравословно тегло.";
                bodyFatDescription.Location = new Point(bodyFatDescription.Location.X - 15, bodyFatDescription.Location.Y);
                extraMeasurementsLabel.Text = "Нуждаем се от допълнителни измервания.";
                neckLabel.Text = "Врат (cm)";
                waistLabel.Text = "Талия (cm)";
                hipsLabel.Text = "Бедра (само жени)";
                bodyFatCalculateButton.Text = "Изчисли";
                essentialLabel.Text = "Съществен";
                athletesLabel.Text = "Атлет";
                fitnessLabel.Text = "Фитнес";
                averageLabel.Text = "Средно";
                obeseLabel.Text = "Затлъстял";
                calorieCalcLabel.Text = "Калкулатор за калории";
                extraMeasurementsL.Text = "Нуждаем се от ниво на активност.";
                activityLabel.Text = "Активност:";
                calorieCalcButton.Text = "Изчисли";
                calorieDescription.Text = "Този калкулатор може да\r\nпредостави някои прости насоки\r\nза " +
                    "покачване, загуба\r\nили поддържане на тегло\r\nвъз основа на вашето\r\nниво на активност.";
                activityComboBox.Items.Clear();
                activityComboBox.Items.Add("Заседналост");
                activityComboBox.Items.Add("Лека");
                activityComboBox.Items.Add("Умерена");
                activityComboBox.Items.Add("Активна");
                activityComboBox.Items.Add("Много активна");
                activityComboBox.Items.Add("Екстра активна");
                macroCalcLabel.Text = "Макро Калкулатор";
                balancedButton.Text = "Баланс";
                lowFatButton.Text = "Ниска мазнина";
                lowCarbsButton.Text = "Нисък въглехидрат";
                highProteinButton.Text = "Висок протеин";
                macroCalcDescription.Text = "Макро калкулаторът\r\nопределя приема на\r\nмакронутриенти " +
                    "въз основа на\r\nтегло, височина, активност\r\nи цели. Изчислява\r\nколичеството " +
                    "протеини, мазнини\r\nи въглехидрати, които\r\nтрябва да се консумират.";
                activityLevelNeedLabel.Text = "Ще ни трябва нивото ви на активност:";
                actLevelLabel.Text = "Активност:";
                changeGoalLabel.Location = new Point(340, 238);
                changeGoalLabel.Text = "Можете да смените целта\r\nот настройките!";
                macroCalcButton.Text = "Изчисли";
                proteinLabel.Text = "Протеин - ";
                carbsLabel.Text = "Въглехидрат - ";
                fatLabel.Text = "Мазнини - ";
                activityComboBoxMacro.Items.Clear();
                activityComboBoxMacro.Items.Add("Заседналост");
                activityComboBoxMacro.Items.Add("Лека");
                activityComboBoxMacro.Items.Add("Умерена");
                activityComboBoxMacro.Items.Add("Активна");
                activityComboBoxMacro.Items.Add("Много активна");
                activityComboBoxMacro.Items.Add("Екстра активна");
                idealWeightCalcLabel.Text = "Калкулатор за идеално тегло";
                idealWeightDescription.Text = "Калкулаторът за идеално тегло\r\nеинструмент, " +
                    "предназначен да\r\nоцени диапазона на\r\nздравословно тегло";
                idealWeightLabel1.Text = "Идеалното тегло за вас\r\nспоред формулата на Робинсон е";
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
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
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
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (age <= 20 && age > 2)
                {
                    bmiPicture.Image = Properties.Resources.bmiMalki;
                    if (percentagesStudents <= 5)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Поднормено тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(228, 155, 42);
                    }
                    if (percentagesStudents <= 85 && percentagesStudents > 5)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Здравословно тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                    }
                    if (percentagesStudents <= 95 && percentagesStudents > 85)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Риско от наднормено)";
                        bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                    }
                    if (percentagesStudents >= 95)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Наднормено тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(185, 6, 6);
                    }
                }
                else
                {
                    bmiPicture.Image = Properties.Resources.bmiFinal1;
                    if (bmi < 16)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Тежка слабост)";
                        bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                    }
                    else if (bmi >= 16 && bmi < 17)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Умерена слабост)";
                        bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                    }
                    else if (bmi >= 17 && bmi < 18.5)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Лека слабост)";
                        bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                    }
                    else if (bmi >= 18.5 && bmi < 25)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Нормално)";
                        bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                    }
                    else if (bmi >= 25 && bmi < 30)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Наднормено тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                    }
                    else if (bmi >= 30 && bmi < 35)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Затлъстялост Ниво 1)";
                        bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                    }
                    else if (bmi >= 35 && bmi < 40)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Затлъстялост Ниво 2)";
                        bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                    }
                    else
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Затлъстялост Ниво 3)";
                        bmicategory_label.ForeColor = Color.FromArgb(138, 1, 1);
                    }
                }
            }

            //BMR
            if (gender == "Male")
            {
                bmr = Math.Round(10 * Convert.ToDouble(weight) + 6.25 * Convert.ToDouble(height) - 5 * age + 5, 0);
            }
            if (gender == "Female")
            {
                bmr = Math.Round(10 * Convert.ToDouble(weight) + 6.25 * Convert.ToDouble(height) - 5 * age - 161, 0);
            }
            sedentaryBMR = Math.Round(bmr * 1.2, 0);
            exerciseBMR13 = Math.Round(bmr * 1.38, 0);
            exerciseBMR45 = Math.Round(bmr * 1.45, 0);
            DailyBMR34 = Math.Round(bmr * 1.55, 0);
            intenseBMR67 = Math.Round(bmr * 1.72, 0);
            veryIntenseBMR = Math.Round(bmr * 1.9, 0);

            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                currentBMR.Text = $"BMR = {bmr.ToString()} calories/day";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                currentBMR.Text = $"BMR = {bmr.ToString()} калории/ден";
            }

            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                sedentaryLabel.Text = $"Sedentary =  ≈{sedentaryBMR.ToString()} calories/day";
                exerciseLabel1.Text = $"Exercise 1 - 3 days =  ≈{exerciseBMR13.ToString()} calories/day";
                exerciseLabel2.Text = $"Exercise 4 - 5 days =  ≈{exerciseBMR45.ToString()} calories/day";
                dailyLabel.Text = $"Daily exercise =  ≈{DailyBMR34.ToString()} calories/day";
                intenseLabel.Text = $"Intense exercise =  ≈{intenseBMR67.ToString()} calories/day";
                veryIntenseLabel.Text = $"Very intense exercise =  ≈{veryIntenseBMR.ToString()} calories/day";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                sedentaryLabel.Text = $"Заседналост =  ≈{sedentaryBMR.ToString()} к/д";
                exerciseLabel1.Text = $"Упражнения 1 - 3 дни =  ≈{exerciseBMR13.ToString()} к/д";
                exerciseLabel2.Text = $"Упражнения 4 - 5 дни =  ≈{exerciseBMR45.ToString()} к/д";
                dailyLabel.Text = $"Дневни упражнения =  ≈{DailyBMR34.ToString()} к/д";
                intenseLabel.Text = $"Интензивни упражнения =  ≈{intenseBMR67.ToString()} к/д";
                veryIntenseLabel.Text = $"Много интензивни упражнения =  ≈{veryIntenseBMR.ToString()} к/д";
            }

            //Body Fat Percentage
            if (gender == "Male")
            {
                hipsTb.Enabled = false;
                bodyFatScale.Image = Properties.Resources.bodyFatMan;
                essentialLabel.Location = new Point(242, 118);
                athletesLabel.Location = new Point(305, 118);
                fitnessLabel.Location = new Point(345, 118);
                averageLabel.Location = new Point(390, 118);
                obeseLabel.Location = new Point(430, 118);
            }
            if (gender == "Female")
            {
                hipsTb.Enabled = true;
                bodyFatScale.Image = Properties.Resources.bodyFatWoman;
                essentialLabel.Location = new Point(267, 118);
                athletesLabel.Location = new Point(335, 118);
                fitnessLabel.Location = new Point(375, 118);
                averageLabel.Location = new Point(416, 118);
                obeseLabel.Location = new Point(460, 118);
            }
            neckTb.TextChanged += checkBodyFatInputs;
            waistTb.TextChanged += checkBodyFatInputs;
            hipsTb.TextChanged += checkBodyFatInputs;


            //Ideal Weight Calculator
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (gender == "Male")
                {
                    idealWeight.Text = Math.Round(52 + ((double.Parse(height) - 152.4) / 2.54 * 1.9), 0).ToString() + "kg";
                }
                if (gender == "Female")
                {
                    idealWeight.Text = Math.Round(49 + ((double.Parse(height) - 152.4) / 2.54 * 1.7), 0).ToString() + "kg";
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (gender == "Male")
                {
                    idealWeight.Text = Math.Round(52 + ((double.Parse(height) - 152.4) / 2.54 * 1.9), 0).ToString() + "кг";
                }
                if (gender == "Female")
                {
                    idealWeight.Text = Math.Round(49 + ((double.Parse(height) - 152.4) / 2.54 * 1.7), 0).ToString() + "кг";
                }
            }
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
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
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
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (age <= 20 && age > 2)
                {
                    bmiPicture.Image = Properties.Resources.bmiMalki;
                    if (percentagesStudents <= 5)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Поднормено тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(228, 155, 42);
                    }
                    if (percentagesStudents <= 85 && percentagesStudents > 5)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Здравословно тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                    }
                    if (percentagesStudents <= 95 && percentagesStudents > 85)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Риско от наднормено)";
                        bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                    }
                    if (percentagesStudents >= 95)
                    {
                        bmicategory_label.Text = "(" + percentagesStudents.ToString() + "% - Наднормено тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(185, 6, 6);
                    }
                }
                else
                {
                    bmiPicture.Image = Properties.Resources.bmiFinal1;
                    if (bmi < 16)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Тежка слабост)";
                        bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                    }
                    else if (bmi >= 16 && bmi < 17)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Умерена слабост)";
                        bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                    }
                    else if (bmi >= 17 && bmi < 18.5)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Лека слабост)";
                        bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                    }
                    else if (bmi >= 18.5 && bmi < 25)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Нормално)";
                        bmicategory_label.ForeColor = Color.FromArgb(0, 129, 55);
                    }
                    else if (bmi >= 25 && bmi < 30)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Наднормено тегло)";
                        bmicategory_label.ForeColor = Color.FromArgb(255, 228, 0);
                    }
                    else if (bmi >= 30 && bmi < 35)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Затлъстялост Ниво 1)";
                        bmicategory_label.ForeColor = Color.FromArgb(211, 136, 136);
                    }
                    else if (bmi >= 35 && bmi < 40)
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Затлъстялост Ниво 2)";
                        bmicategory_label.ForeColor = Color.FromArgb(188, 32, 32);
                    }
                    else
                    {
                        bmicategory_label.Text = "(" + percentages.ToString() + "% - Затлъстялост Ниво 3)";
                        bmicategory_label.ForeColor = Color.FromArgb(138, 1, 1);
                    }
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
        private void bmr_buttonOpen_Click(object sender, EventArgs e)
        {
            bmrCalcPanel.Size = new Size(547, 270);
            bmrCalcPanel.Visible = true;
            buttonOpenCalorie.Enabled = false;
            buttonOpenMacro.Enabled = false;
            buttonOpenIdealWeight.Enabled = false;
        }

        private void buttonCloseBMR_Click(object sender, EventArgs e)
        {
            bmrCalcPanel.Visible = false;
            buttonOpenCalorie.Enabled = true;
            buttonOpenMacro.Enabled = true;
            buttonOpenIdealWeight.Enabled = true;
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
            buttonOpenCalorie.Enabled = true;
            buttonOpenMacro.Enabled = true;
            buttonOpenIdealWeight.Enabled = true;
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
                if (Regex.IsMatch(neckTb.Text, @"^\d+$") && Regex.IsMatch(waistTb.Text, @"^\d+$"))
                {
                    neck = double.Parse(neckTb.Text);
                    waist = double.Parse(waistTb.Text);
                    bodyFat = Math.Round((495 / (1.0324 - 0.19077 * Math.Log10(waist - neck) + 0.15456 * Math.Log10(Convert.ToDouble(height)))) - 450, 0);
                }
            }
            if (gender == "Female")
            {
                if (Regex.IsMatch(neckTb.Text, @"^\d+$") && Regex.IsMatch(waistTb.Text, @"^\d+$") && Regex.IsMatch(hipsTb.Text, @"^\d+$"))
                {
                    neck = double.Parse(neckTb.Text);
                    waist = double.Parse(waistTb.Text);
                    hips = double.Parse(hipsTb.Text);
                    bodyFat = Math.Round((495 / (1.29579 - 0.35004 * Math.Log10(waist + hips - neck) + 0.22100 * Math.Log10(Convert.ToDouble(height)))) - 450, 0);
                }
            }
            if (bodyFat < 0)
                bodyFat = 0;
            if (bodyFat > 100)
                bodyFat = 100;
            bodyFatPercentage.Location = new Point(Convert.ToInt16(Math.Round((bodyFat / 40 * 254) - 4, 0)), 0);
            bodyFatArrow.Location = new Point(Convert.ToInt16(Math.Round(bodyFat / 40 * 254, 0)), 15);
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                currentBFP.Text = $"Body Fat Percentage = {bodyFat.ToString()}%";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                currentBFP.Text = $"Процент на мазнини = {bodyFat.ToString()}%";
            }
            bodyFatPercentage.Text = bodyFat.ToString() + "%";
        }

        private void bodyfat_buttonOpen_Click(object sender, EventArgs e)
        {
            bodyFatCalcPanel.Size = new Size(547, 270);
            bodyFatCalcPanel.Visible = true;
            buttonOpenCalorie.Enabled = false;
            buttonOpenMacro.Enabled = false;
            buttonOpenIdealWeight.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            calorieCalcPanel.Visible = false;
            buttonOpenCalorie.Enabled = true;
            buttonOpenMacro.Enabled = true;
            buttonOpenIdealWeight.Enabled = true;
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
            buttonOpenCalorie.Enabled = false;
            buttonOpenMacro.Enabled = false;
            buttonOpenIdealWeight.Enabled = false;
        }

        private void calorieCalcButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBox.SelectedItem == "Sedentary")
                {
                    CalorieCalculation(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Light")
                {
                    CalorieCalculation(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Moderate")
                {
                    CalorieCalculation(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Active")
                {
                    CalorieCalculation(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Very active")
                {
                    CalorieCalculation(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Extra active")
                {
                    CalorieCalculation(veryIntenseBMR);
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBox.SelectedItem == "Заседналост")
                {
                    CalorieCalculation(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Лека")
                {
                    CalorieCalculation(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Умерена")
                {
                    CalorieCalculation(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Активна")
                {
                    CalorieCalculation(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Много активна")
                {
                    CalorieCalculation(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Екстра активна")
                {
                    CalorieCalculation(veryIntenseBMR);
                }
            }
        }

        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBox.SelectedItem == "Sedentary" || activityComboBox.SelectedItem == "Light" || activityComboBox.SelectedItem == "Moderate" || activityComboBox.SelectedItem == "Active" || activityComboBox.SelectedItem == "Very active" || activityComboBox.SelectedItem == "Extra active")
                {
                    calorieCalcButton.Enabled = true;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBox.SelectedItem == "Заседналост" || activityComboBox.SelectedItem == "Лека" || activityComboBox.SelectedItem == "Умерена" || activityComboBox.SelectedItem == "Активна" || activityComboBox.SelectedItem == "Много активна" || activityComboBox.SelectedItem == "Екстра активна")
                {
                    calorieCalcButton.Enabled = true;
                }
            }
        }

        private void buttonCloseIdealWeight_Click(object sender, EventArgs e)
        {
            idealWeightCalcPanel.Visible = false;
            buttonOpenCalorie.Enabled = true;
            buttonOpenMacro.Enabled = true;
            buttonOpenIdealWeight.Enabled = true;
        }

        private void buttonCloseIdealWeight_MouseEnter(object sender, EventArgs e)
        {
            buttonCloseIdealWeight.BackColor = Color.IndianRed;
        }

        private void buttonCloseIdealWeight_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseIdealWeight.BackColor = Color.White;
        }

        private void idealweight_buttonOpen_Click(object sender, EventArgs e)
        {
            idealWeightCalcPanel.Size = new Size(547, 270);
            idealWeightCalcPanel.Visible = true;
            buttonOpenCalorie.Enabled = false;
            buttonOpenMacro.Enabled = false;
            buttonOpenIdealWeight.Enabled = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            macroCalcPanel.Visible = false;
            buttonOpenCalorie.Enabled = true;
            buttonOpenMacro.Enabled = true;
            buttonOpenIdealWeight.Enabled = true;
        }

        private void buttonCloseMacroCalc_MouseEnter(object sender, EventArgs e)
        {
            buttonCloseMacroCalc.BackColor = Color.IndianRed;
        }

        private void buttonCloseMacroCalc_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseMacroCalc.BackColor = Color.White;
        }

        private void macro_buttonOpen_Click(object sender, EventArgs e)
        {
            macroCalcPanel.Size = new Size(547, 270);
            macroCalcPanel.Visible = true;
            buttonOpenCalorie.Enabled = false;
            buttonOpenMacro.Enabled = false;
            buttonOpenIdealWeight.Enabled = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            balancedButton.Visible = true;
            lowCarbsButton.Visible = true;
            lowFatButton.Visible = true;
            highProteinButton.Visible = true;
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBoxMacro.SelectedItem == "Sedentary")
                {
                    MacroBalanced(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Light")
                {
                    MacroBalanced(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Moderate")
                {
                    MacroBalanced(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Active")
                {
                    MacroBalanced(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Very active")
                {
                    MacroBalanced(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Extra active")
                {
                    MacroBalanced(veryIntenseBMR);
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBoxMacro.SelectedItem == "Заседналост")
                {
                    MacroBalanced(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Лека")
                {
                    MacroBalanced(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Умерена")
                {
                    MacroBalanced(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Активна")
                {
                    MacroBalanced(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Много активна")
                {
                    MacroBalanced(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Екстра активна")
                {
                    MacroBalanced(veryIntenseBMR);
                }
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBoxMacro.SelectedItem == "Sedentary" || activityComboBoxMacro.SelectedItem == "Light" || activityComboBoxMacro.SelectedItem == "Moderate" || activityComboBoxMacro.SelectedItem == "Active" || activityComboBoxMacro.SelectedItem == "Very active" || activityComboBoxMacro.SelectedItem == "Extra active")
                {
                    macroCalcButton.Enabled = true;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBoxMacro.SelectedItem == "Заседналост" || activityComboBoxMacro.SelectedItem == "Лека" || activityComboBoxMacro.SelectedItem == "Умерена" || activityComboBoxMacro.SelectedItem == "Активна" || activityComboBoxMacro.SelectedItem == "Много активна" || activityComboBoxMacro.SelectedItem == "Екстра активна")
                {
                    macroCalcButton.Enabled = true;
                }
            }
        }

        private void balancedButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBoxMacro.SelectedItem == "Sedentary")
                {
                    MacroBalanced(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Light")
                {
                    MacroBalanced(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Moderate")
                {
                    MacroBalanced(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Active")
                {
                    MacroBalanced(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Very active")
                {
                    MacroBalanced(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Extra active")
                {
                    MacroBalanced(veryIntenseBMR);
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBoxMacro.SelectedItem == "Заседналост")
                {
                    MacroBalanced(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Лека")
                {
                    MacroBalanced(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Умерена")
                {
                    MacroBalanced(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Активна")
                {
                    MacroBalanced(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Много активна")
                {
                    MacroBalanced(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Екстра активна")
                {
                    MacroBalanced(veryIntenseBMR);
                }
            }
        }

        private void lowFatButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBoxMacro.SelectedItem == "Sedentary")
                {
                    MacroLowFat(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Light")
                {
                    MacroLowFat(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Moderate")
                {
                    MacroLowFat(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Active")
                {
                    MacroLowFat(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Very active")
                {
                    MacroLowFat(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Extra active")
                {
                    MacroLowFat(veryIntenseBMR);
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBoxMacro.SelectedItem == "Заседналост")
                {
                    MacroLowFat(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Лека")
                {
                    MacroLowFat(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Умерена")
                {
                    MacroLowFat(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Активна")
                {
                    MacroLowFat(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Много активна")
                {
                    MacroLowFat(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Екстра активна")
                {
                    MacroLowFat(veryIntenseBMR);
                }
            }
        }

        private void lowCarbsButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBoxMacro.SelectedItem == "Sedentary")
                {
                    MacroLowCarb(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Light")
                {
                    MacroLowCarb(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Moderate")
                {
                    MacroLowCarb(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Active")
                {
                    MacroLowCarb(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Very active")
                {
                    MacroLowCarb(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Extra active")
                {
                    MacroLowCarb(veryIntenseBMR);
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBoxMacro.SelectedItem == "Заседналост")
                {
                    MacroLowCarb(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Лека")
                {
                    MacroLowCarb(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Умерена")
                {
                    MacroLowCarb(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Активна")
                {
                    MacroLowCarb(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Много активна")
                {
                    MacroLowCarb(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Екстра активна")
                {
                    MacroLowCarb(veryIntenseBMR);
                }
            }
        }

        private void highProteinButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (activityComboBoxMacro.SelectedItem == "Sedentary")
                {
                    MacroHighProtein(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Light")
                {
                    MacroHighProtein(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Moderate")
                {
                    MacroHighProtein(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Active")
                {
                    MacroHighProtein(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Very active")
                {
                    MacroHighProtein(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Extra active")
                {
                    MacroHighProtein(veryIntenseBMR);
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (activityComboBoxMacro.SelectedItem == "Заседналост")
                {
                    MacroHighProtein(sedentaryBMR);
                }
                if (activityComboBoxMacro.SelectedItem == "Лека")
                {
                    MacroHighProtein(exerciseBMR13);
                }
                if (activityComboBoxMacro.SelectedItem == "Умерена")
                {
                    MacroHighProtein(exerciseBMR45);
                }
                if (activityComboBoxMacro.SelectedItem == "Активна")
                {
                    MacroHighProtein(DailyBMR34);
                }
                if (activityComboBoxMacro.SelectedItem == "Много активна")
                {
                    MacroHighProtein(intenseBMR67);
                }
                if (activityComboBoxMacro.SelectedItem == "Екстра активна")
                {
                    MacroHighProtein(veryIntenseBMR);
                }
            }
        }
    }
}
