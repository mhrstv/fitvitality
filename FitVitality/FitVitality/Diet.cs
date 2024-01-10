using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FitVitality
{
    public partial class Diet : Form
    {
        bool balancedClicked = false;
        bool highProteinClicked = false;
        bool lowFatClicked = false;
        bool lowCarbsClicked = false;
        double bmr;
        double sedentaryBMR;
        double exerciseBMR13;
        double exerciseBMR45;
        double DailyBMR34;
        double intenseBMR67;
        double veryIntenseBMR;
        private int age;
        private string gender;
        private string weight;
        private string height;
        private string goal;
        private int currentCalories = 0;
        private int currentCarbs = 0;
        private int currentProtein = 0;
        private int currentFats = 0;

        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public string _userID;
        public Diet(string UserID)
        {
            InitializeComponent();
            _userID = UserID;
        }

        public void MacroBalanced(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
            }
            if (goal == "Maintain")
            {
                activity = activity;
                calorieIntake.Text = $"{currentCalories} / {activity.ToString()}";
                protein.Text = $"{currentProtein} / {activity * 0.25 / 4}:f0";
                fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
            }
        }
        public void MacroLowFat(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
            }
            if (goal == "Maintain")
            {
                activity = activity;
                calorieIntake.Text = $"{currentCalories} / {activity.ToString()}";
                protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
            }
        }
        public void MacroLowCarb(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
            }
            if (goal == "Maintain")
            {
                activity = activity;
                calorieIntake.Text = $"{currentCalories} / {activity.ToString()}";
                protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
            }
        }
        public void MacroHighProtein(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
            }
            if (goal == "Maintain")
            {
                activity = activity;
                calorieIntake.Text = $" / {activity.ToString()}";
                protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
            }
        }
        private void Diet_Load(object sender, EventArgs e)
        {
            List<FoodItem> items = new List<FoodItem>();
            for (int i = 0; i < 3; i++)
            {
                FoodItem item = new FoodItem();
                item.FoodName = "Egg";
                item.FoodCalories = 133;
                item.FoodProtein = 100;
                item.FoodFat = 23;
                item.FoodCarbs = 86;
                items.Add(item);
                foodPanel.Controls.Add(item);
            }
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

            balancedButton.Image = Properties.Resources.balancedSelected;
            highProteinButton.Image = Properties.Resources.highProtein;
            lowFatButton.Image = Properties.Resources.lowFat;
            lowCarbsButton.Image = Properties.Resources.lowCarbs;
            balancedClicked = true;
            highProteinClicked = false;
            lowCarbsClicked = false;
            lowFatClicked = false;
        }

        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kCalLabel.Visible = true;
            cLabel.Visible = true;
            pLabel.Visible = true;
            fLabel.Visible = true;
            calorieIntake.Visible = true;
            carbohydrates.Visible = true;
            fat.Visible = true;
            protein.Visible = true;
            balancedButton.Visible = true;
            balancedButton.Image = Properties.Resources.balancedSelected;
            highProteinButton.Image = Properties.Resources.highProtein;
            lowFatButton.Image = Properties.Resources.lowFat;
            lowCarbsButton.Image = Properties.Resources.lowCarbs;
            balancedClicked = true;
            highProteinClicked = false;
            lowCarbsClicked = false;
            lowFatClicked = false;
            lowCarbsButton.Visible = true;
            lowFatButton.Visible = true;
            highProteinButton.Visible = true;
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

        private void balancedButton_Click(object sender, EventArgs e)
        {
            balancedButton.Image = Properties.Resources.balancedSelected;
            highProteinButton.Image = Properties.Resources.highProtein;
            lowFatButton.Image = Properties.Resources.lowFat;
            lowCarbsButton.Image = Properties.Resources.lowCarbs;
            balancedClicked = true;
            highProteinClicked = false;
            lowFatClicked = false;
            lowCarbsClicked = false;
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

        private void highProteinButton_Click(object sender, EventArgs e)
        {
            balancedButton.Image = Properties.Resources.balanced;
            highProteinButton.Image = Properties.Resources.highProteinSelected;
            lowFatButton.Image = Properties.Resources.lowFat;
            lowCarbsButton.Image = Properties.Resources.lowCarbs;
            balancedClicked = false;
            highProteinClicked = true;
            lowFatClicked = false;
            lowCarbsClicked = false;
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

        private void lowFatButton_Click(object sender, EventArgs e)
        {
            balancedButton.Image = Properties.Resources.balanced;
            highProteinButton.Image = Properties.Resources.highProtein;
            lowFatButton.Image = Properties.Resources.lowFatSelected;
            lowCarbsButton.Image = Properties.Resources.lowCarbs;
            balancedClicked = false;
            highProteinClicked = false;
            lowFatClicked = true;
            lowCarbsClicked = false;
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

        private void lowCarbsButton_Click(object sender, EventArgs e)
        {
            balancedButton.Image = Properties.Resources.balanced;
            highProteinButton.Image = Properties.Resources.highProtein;
            lowFatButton.Image = Properties.Resources.lowFat;
            lowCarbsButton.Image = Properties.Resources.lowCarbsSelected;
            balancedClicked = false;
            highProteinClicked = false;
            lowFatClicked = false;
            lowCarbsClicked = true;
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

        private void balancedButton_MouseEnter(object sender, EventArgs e)
        {
            if (!balancedClicked)
            {
                balancedButton.Image = Properties.Resources.balancedHover;
            }
        }

        private void balancedButton_MouseLeave(object sender, EventArgs e)
        {
            if (!balancedClicked)
            {
                balancedButton.Image = Properties.Resources.balanced;
            }
        }

        private void highProteinButton_MouseEnter(object sender, EventArgs e)
        {
            if (!highProteinClicked)
            {
                highProteinButton.Image = Properties.Resources.highProteinHover;
            }
        }

        private void highProteinButton_MouseLeave(object sender, EventArgs e)
        {
            if (!highProteinClicked)
            {
                highProteinButton.Image = Properties.Resources.highProtein;
            }
        }

        private void lowFatButton_MouseEnter(object sender, EventArgs e)
        {
            if (!lowFatClicked)
            {
                lowFatButton.Image = Properties.Resources.lowFatHover;
            }
        }

        private void lowFatButton_MouseLeave(object sender, EventArgs e)
        {
            if (!lowFatClicked)
            {
                lowFatButton.Image = Properties.Resources.lowFat;
            }
        }

        private void lowCarbsButton_MouseEnter(object sender, EventArgs e)
        {
            if (!lowCarbsClicked)
            {
                lowCarbsButton.Image = Properties.Resources.lowCarbsHover;
            }
        }

        private void lowCarbsButton_MouseLeave(object sender, EventArgs e)
        {
            if (!lowCarbsClicked)
            {
                lowCarbsButton.Image = Properties.Resources.lowCarbs;
            }
        }
    }
}
