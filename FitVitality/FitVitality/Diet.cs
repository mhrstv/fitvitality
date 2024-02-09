using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Policy;

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
        string currentGoal;

        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public string _userID;

        List<SearchFoodItem> searchFoodItems = new List<SearchFoodItem>();
        List<FoodItem> foodItems = new List<FoodItem>();
        public Diet(string UserID)
        {
            InitializeComponent();
            _userID = UserID;
        }
        int caloriesGoal;
        int proteinGoal;
        int fatsGoal;
        int carbsGoal;
        public void MacroBalanced(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                if (currentCalories < activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentCalories > activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentProtein < activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentProtein > activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentFats < activity * 0.25 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 9, 0));
                }
                if (currentFats > activity * 0.25 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 9, 0));
                }
                if (currentCarbs < activity * 0.5 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.5 / 4, 0));
                }
                if (currentCarbs > activity * 0.5 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.5 / 4, 0));
                }
            }
            if (goal == "Maintain")
            {
                activity = activity;
                if (currentCalories < activity)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentCalories > activity)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentProtein < activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentProtein > activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentFats < activity * 0.25 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 9, 0));
                }
                if (currentFats > activity * 0.25 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 9, 0));
                }
                if (currentCarbs < activity * 0.5 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.5 / 4, 0));
                }
                if (currentCarbs > activity * 0.5 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.5 / 4, 0));
                }
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                if (currentCalories < activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentCalories > activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentProtein < activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentProtein > activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentFats < activity * 0.25 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 9, 0));
                }
                if (currentFats > activity * 0.25 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.25 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 9, 0));
                }
                if (currentCarbs < activity * 0.5 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.5 / 4, 0));
                }
                if (currentCarbs > activity * 0.5 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.5 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.5 / 4, 0));
                }
            }
        }
        public void MacroLowFat(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                if (currentCalories < activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentCalories > activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentProtein < activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentProtein > activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentFats < activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentFats > activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentCarbs < activity * 0.55 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.55 / 4, 0));
                }
                if (currentCarbs > activity * 0.55 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.55 / 4, 0));
                }
            }
            if (goal == "Maintain")
            {
                activity = activity;
                if (currentCalories < activity)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentCalories > activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentProtein < activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentProtein > activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentFats < activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentFats > activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentCarbs < activity * 0.55 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.55 / 4, 0));
                }
                if (currentCarbs > activity * 0.55 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.55 / 4, 0));
                }
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                if (currentCalories < activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentCalories > activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentProtein < activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentProtein > activity * 0.25 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.25 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.25 / 4, 0));
                }
                if (currentFats < activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentFats > activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentCarbs < activity * 0.55 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.55 / 4, 0));
                }
                if (currentCarbs > activity * 0.55 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.55 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.55 / 4, 0));
                }
            }
        }
        public void MacroLowCarb(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                if (currentCalories < activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentCalories > activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentProtein < activity * 0.3 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 4, 0));
                }
                if (currentProtein > activity * 0.3 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 4, 0));
                }
                if (currentFats < activity * 0.3 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 9, 0));
                }
                if (currentFats > activity * 0.3 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 9, 0));
                }
                if (currentCarbs < activity * 0.4 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.4 / 4, 0));
                }
                if (currentCarbs > activity * 0.4 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.4 / 4, 0));
                }
            }
            if (goal == "Maintain")
            {
                activity = activity;
                if (currentCalories < activity)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentCalories > activity)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentProtein < activity * 0.3 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 4, 0));
                }
                if (currentProtein > activity * 0.3 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 4, 0));
                }
                if (currentFats < activity * 0.3 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 9, 0));
                }
                if (currentFats > activity * 0.3 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 9, 0));
                }
                if (currentCarbs < activity * 0.4 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.4 / 4, 0));
                }
                if (currentCarbs > activity * 0.4 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.4 / 4, 0));
                }
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                if (currentCalories < activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentCalories > activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentProtein < activity * 0.3 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 4, 0));
                }
                if (currentProtein > activity * 0.3 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.3 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 4, 0));
                }
                if (currentFats < activity * 0.3 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 9, 0));
                }
                if (currentFats > activity * 0.3 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.3 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.3 / 9, 0));
                }
                if (currentCarbs < activity * 0.4 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.4 / 4, 0));
                }
                if (currentCarbs > activity * 0.4 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.4 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.4 / 4, 0));
                }
            }
        }
        public void MacroHighProtein(double activity)
        {
            if (goal == "Cut")
            {
                activity *= Math.Round(0.75, 0);
                if (currentCalories < activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentCalories > activity * 0.88)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 0.88, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 0.88, 0));
                }
                if (currentProtein < activity * 0.35 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.35 / 4, 0));
                }
                if (currentProtein > activity * 0.35 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.35 / 4, 0));
                }
                if (currentFats < activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentFats > activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentCarbs < activity * 0.45 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.45 / 4, 0));
                }
                if (currentCarbs > activity * 0.45 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.45 / 4, 0));
                }
            }
            if (goal == "Maintain")
            {
                activity = activity;
                if (currentCalories < activity)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentCalories > activity)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity, 0));
                }
                if (currentProtein < activity * 0.35 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.35 / 4, 0));
                }
                if (currentProtein > activity * 0.35 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.35 / 4, 0));
                }
                if (currentFats < activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentFats > activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentCarbs < activity * 0.45 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.45 / 4, 0));
                }
                if (currentCarbs > activity * 0.45 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.45 / 4, 0));
                }
            }
            if (goal == "Bulk")
            {
                activity *= Math.Round(1.25, 0);
                if (currentCalories < activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Black;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentCalories > activity * 1.12)
                {
                    calorieIntake.ForeColor = Color.Red;
                    calorieIntake.Text = $"{currentCalories} / {Math.Round(activity * 1.12, 0)}";
                    caloriesGoal = Convert.ToInt32(Math.Round(activity * 1.12, 0));
                }
                if (currentProtein < activity * 0.35 / 4)
                {
                    protein.ForeColor = Color.Black;
                    protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.35 / 4, 0));
                }
                if (currentProtein > activity * 0.35 / 4)
                {
                    protein.ForeColor = Color.Red;
                    protein.Text = $"{currentProtein} / {activity * 0.35 / 4:f0}";
                    proteinGoal = Convert.ToInt32(Math.Round(activity * 0.35 / 4, 0));
                }
                if (currentFats < activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Black;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentFats > activity * 0.2 / 9)
                {
                    fat.ForeColor = Color.Red;
                    fat.Text = $"{currentFats} / {activity * 0.2 / 9:f0}";
                    fatsGoal = Convert.ToInt32(Math.Round(activity * 0.2 / 9, 0));
                }
                if (currentCarbs < activity * 0.45 / 4)
                {
                    carbohydrates.ForeColor = Color.Black;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.45 / 4, 0));
                }
                if (currentCarbs > activity * 0.45 / 4)
                {
                    carbohydrates.ForeColor = Color.Red;
                    carbohydrates.Text = $"{currentCarbs} / {activity * 0.45 / 4:f0}";
                    carbsGoal = Convert.ToInt32(Math.Round(activity * 0.45 / 4, 0));
                }
            }
        }
        private void Diet_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                dietLabel.Text = "Diet";
                manageGoalLabel.Text = "Manage\nGoal";
                addFoodLabel.Text = "Today`s food";
                dailyGoalLabel.Text = "Daily\nGoal";
                activityLevelLabel.Text = "Activity level:";
                manageGoalDescription.Text = "In this section you enter your \r\ngoal " +
                    "and activity depending \r\non your busyness and dream\r\nphysique.\r\n";
                macroАbbreviation.Text = "C -  Carbohydrates, P - Protein, F - Fats\r\n";
                activityComboBox.Items.Clear();
                activityComboBox.Items.Add("Sedentary");
                activityComboBox.Items.Add("Light");
                activityComboBox.Items.Add("Moderate");
                activityComboBox.Items.Add("Active");
                activityComboBox.Items.Add("Very active");
                activityComboBox.Items.Add("Extra active");
                hintLabel.Text = "Add food to the box from the search bar.";
                chooseActivityLabel.Text = "Please select the desired\r\nactivity level and " +
                    "nutrition goal\r\nin order to make all the tabs visible!\r\n";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                dietLabel.Text = "Диета";
                manageGoalLabel.Text = "Управлявайте\nЦелта";
                addFoodLabel.Text = "Днешно хранене";
                dailyGoalLabel.Text = "Днешна\nЦел";
                activityLevelLabel.Text = "Активност:";
                manageGoalDescription.Text = "В тази секция въвеждате\r\nцелта и активността си\r\n" +
                    "според вашата заетост\r\nи желан външен вид.";
                macroАbbreviation.Text = "C -  Въглехидрат, P - Протеин, F - Мазнини\r\n";
                activityComboBox.Items.Clear();
                activityComboBox.Items.Add("Заседналост");
                activityComboBox.Items.Add("Лека");
                activityComboBox.Items.Add("Умерена");
                activityComboBox.Items.Add("Активна");
                activityComboBox.Items.Add("Много активна");
                activityComboBox.Items.Add("Екстра активна");
                hintLabel.Text = "Добави храна от кутията за търсене.";
                chooseActivityLabel.Text = "Моля изберете желаната\r\nактивност и цел " +
                    "за да\r\nнаправите всички панели\r\nвидими.";
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

            hiddenPanel1.Width = 241;
            hiddenPanel1.Height = 308;
            hiddenPanel2.Width = 197;
            hiddenPanel2.Height = 308;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (cfg.Read("Language", "SETTINGS") == "en")
                        {
                            if (reader.Read())
                            {
                                if (reader["ActivitySelection"].ToString() != String.Empty)
                                {
                                    switch (reader["ActivitySelection"].ToString())
                                    {
                                        case "Sedentary":
                                            activityComboBox.SelectedItem = "Sedentary";
                                            break;
                                        case "Light":
                                            activityComboBox.SelectedItem = "Light";
                                            break;
                                        case "Moderate":
                                            activityComboBox.SelectedItem = "Moderate";
                                            break;
                                        case "Active":
                                            activityComboBox.SelectedItem = "Active";
                                            break;
                                        case "Very active":
                                            activityComboBox.SelectedItem = "Very active";
                                            break;
                                        case "Extra active":
                                            activityComboBox.SelectedItem = "Extra active";
                                            break;
                                    }
                                    if (reader["MacroSelection"].ToString() != String.Empty)
                                    {
                                        switch (reader["MacroSelection"].ToString())
                                        {
                                            case "Balanced":
                                                balancedButton_Click(sender, e);
                                                break;
                                            case "HighProtein":
                                                highProteinButton_Click(sender, e);
                                                break;
                                            case "LowFat":
                                                lowFatButton_Click(sender, e);
                                                break;
                                            case "LowCarbs":
                                                lowCarbsButton_Click(sender, e);
                                                break;
                                        }
                                        hiddenPanel1.Visible = false;
                                        hiddenPanel2.Visible = false;
                                    }
                                    else
                                    {
                                        if (activityComboBox.Text != "")
                                        {
                                            hiddenPanel1.Visible = false;
                                            hiddenPanel2.Visible = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (activityComboBox.Text != "")
                                    {
                                        hiddenPanel1.Visible = true;
                                        hiddenPanel2.Visible = true;
                                    }
                                }
                            }
                        }
                        if (cfg.Read("Language", "SETTINGS") == "bg")
                        {
                            if (reader.Read())
                            {
                                if (reader["ActivitySelection"].ToString() != String.Empty)
                                {
                                    switch (reader["ActivitySelection"].ToString())
                                    {
                                        case "Sedentary":
                                            activityComboBox.SelectedItem = "Заседналост";
                                            break;
                                        case "Light":
                                            activityComboBox.SelectedItem = "Лека";
                                            break;
                                        case "Moderate":
                                            activityComboBox.SelectedItem = "Умерена";
                                            break;
                                        case "Active":
                                            activityComboBox.SelectedItem = "Активна";
                                            break;
                                        case "Very active":
                                            activityComboBox.SelectedItem = "Много активна";
                                            break;
                                        case "Extra active":
                                            activityComboBox.SelectedItem = "Екстра активна";
                                            break;
                                    }
                                    if (reader["MacroSelection"].ToString() != String.Empty)
                                    {
                                        switch (reader["MacroSelection"].ToString())
                                        {
                                            case "Balanced":
                                                balancedButton_Click(sender, e);
                                                break;
                                            case "HighProtein":
                                                highProteinButton_Click(sender, e);
                                                break;
                                            case "LowFat":
                                                lowFatButton_Click(sender, e);
                                                break;
                                            case "LowCarbs":
                                                lowCarbsButton_Click(sender, e);
                                                break;
                                        }
                                        hiddenPanel1.Visible = false;
                                        hiddenPanel2.Visible = false;
                                    }
                                    else
                                    {
                                        if (activityComboBox.Text != "")
                                        {
                                            hiddenPanel1.Visible = false;
                                            hiddenPanel2.Visible = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (activityComboBox.Text != "")
                                    {
                                        hiddenPanel1.Visible = true;
                                        hiddenPanel2.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
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

            foodItems.Clear();
            foodPanel.Controls.Clear();
            string dbFoodItems = "";
            string dbFoodItemsAmount = "";
            string dbFoodItemsCalories = "";
            string dbFoodItemsProtein = "";
            string dbFoodItemsCarbs = "";
            string dbFoodItemsFat = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dbFoodItems = reader["Items"].ToString();
                            dbFoodItemsAmount = reader["ItemsAmount"].ToString();
                            dbFoodItemsCalories = reader["ItemsCalories"].ToString();
                            dbFoodItemsProtein = reader["ItemsProtein"].ToString();
                            dbFoodItemsCarbs = reader["ItemsCarbs"].ToString();
                            dbFoodItemsFat = reader["ItemsFats"].ToString();
                        }
                    }
                }
            }
            List<string> dbFoodItemsList = dbFoodItems.Split(",").ToList();
            List<string> dbFoodItemsAmountList = dbFoodItemsAmount.Split(",").ToList();
            List<string> dbFoodItemsCaloriesList = dbFoodItemsCalories.Split(",").ToList();
            List<string> dbFoodItemsProteinList = dbFoodItemsProtein.Split(",").ToList();
            List<string> dbFoodItemsCarbsList = dbFoodItemsCarbs.Split(",").ToList();
            List<string> dbFoodItemsFatList = dbFoodItemsFat.Split(",").ToList();
            for (int i = 0; i < dbFoodItemsList.Count; i++)
            {
                FoodItem foodItem = new FoodItem();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM FoodItems WHERE Name = @FoodName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodName", dbFoodItemsList[i]);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foodItem.FoodName = reader["Name"].ToString();
                                foodItem.FoodCalories = Convert.ToDouble(dbFoodItemsCaloriesList[i]);
                                foodItem.FoodProtein = Convert.ToDouble(dbFoodItemsProteinList[i]);
                                foodItem.FoodCarbs = Convert.ToDouble(dbFoodItemsCarbsList[i]);
                                foodItem.FoodFat = Convert.ToDouble(dbFoodItemsFatList[i]);
                                foodItem.CaloriesStatic = Convert.ToDouble(reader["Calories"].ToString());
                                foodItem.ProteinStatic = Convert.ToDouble(reader["Protein"].ToString());
                                foodItem.CarbsStatic = Convert.ToDouble(reader["Carbohydrates"].ToString());
                                foodItem.FatStatic = Convert.ToDouble(reader["Fat"].ToString());
                                foodItem.FoodGrams = Convert.ToInt32(dbFoodItemsAmountList[i]);
                                foodItem.FoodImage = reader["Image"].ToString();
                                foodItem.ButtonClicked += (sender, e) => foodItem_Click(sender, e);
                                foodItem.Add += (sender, e) => foodItem_Add(sender, e, foodItem.FoodCalories, foodItem.FoodProtein, foodItem.FoodCarbs, foodItem.FoodFat);
                                foodItem.Remove += (sender, e) => foodItem_Remove(sender, e, foodItem.FoodCalories, foodItem.FoodProtein, foodItem.FoodCarbs, foodItem.FoodFat);
                                currentCalories += (int)Math.Round(foodItem.FoodCalories, 0);
                                currentCarbs += (int)Math.Round(foodItem.FoodCarbs, 1);
                                currentProtein += (int)Math.Round(foodItem.FoodProtein, 1);
                                currentFats += (int)Math.Round(foodItem.FoodFat, 1);
                                foodItems.Add(foodItem);
                                foodPanel.Controls.Add(foodItem);
                            }
                        }
                    }
                }
            }
            activityComboBox_SelectedIndexChanged(sender, e);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["MacroSelection"].ToString() != String.Empty)
                            {
                                switch (reader["MacroSelection"].ToString())
                                {
                                    case "Balanced":
                                        balancedButton_Click(sender, e);
                                        break;
                                    case "HighProtein":

                                        highProteinButton_Click(sender, e);
                                        break;
                                    case "LowFat":
                                        lowFatButton_Click(sender, e);
                                        break;
                                    case "LowCarbs":
                                        lowCarbsButton_Click(sender, e);
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
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
                balancedButton.Image = Properties.Resources.balanced;
                highProteinButton.Image = Properties.Resources.highProtein;
                lowFatButton.Image = Properties.Resources.lowFat;
                lowCarbsButton.Image = Properties.Resources.lowCarbs;
                lowCarbsButton.Visible = true;
                lowFatButton.Visible = true;
                highProteinButton.Visible = true;
                if (activityComboBox.Text != "")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE UserNutrition " +
                                       "SET ActivitySelection = @ActivitySelection " +
                                       "WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", _userID);
                            if (activityComboBox.SelectedItem == "Sedentary")
                            {
                                MacroBalanced(sedentaryBMR);
                            }
                            if (activityComboBox.SelectedItem == "Light")
                            {
                                MacroBalanced(exerciseBMR13);
                            }
                            if (activityComboBox.SelectedItem == "Moderate")
                            {
                                MacroBalanced(exerciseBMR45);
                            }
                            if (activityComboBox.SelectedItem == "Active")
                            {
                                MacroBalanced(DailyBMR34);
                            }
                            if (activityComboBox.SelectedItem == "Very active")
                            {
                                MacroBalanced(intenseBMR67);
                            }
                            if (activityComboBox.SelectedItem == "Extra active")
                            {
                                MacroBalanced(veryIntenseBMR);
                            }
                            command.Parameters.AddWithValue("@ActivitySelection", activityComboBox.SelectedItem.ToString());
                            connection.Open();
                            command.ExecuteNonQuery();
                            if (activityComboBox.Text != "")
                            {
                                hiddenPanel2.Visible = false;

                            }
                        }
                    }
                }
                else
                {
                    hiddenPanel1.Visible = true;
                    hiddenPanel2.Visible = true;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
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
                balancedButton.Image = Properties.Resources.balancedbg;
                highProteinButton.Image = Properties.Resources.highProteinbg;
                lowFatButton.Image = Properties.Resources.lowFatbg;
                lowCarbsButton.Image = Properties.Resources.lowCarbsbg;
                lowCarbsButton.Visible = true;
                lowFatButton.Visible = true;
                highProteinButton.Visible = true;
                if (activityComboBox.Text != "")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE UserNutrition " +
                                       "SET ActivitySelection = @ActivitySelection " +
                                       "WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", _userID);
                            if (activityComboBox.SelectedItem == "Заседналост")
                            {
                                MacroBalanced(sedentaryBMR);
                            }
                            if (activityComboBox.SelectedItem == "Лека")
                            {
                                MacroBalanced(exerciseBMR13);
                            }
                            if (activityComboBox.SelectedItem == "Умерена")
                            {
                                MacroBalanced(exerciseBMR45);
                            }
                            if (activityComboBox.SelectedItem == "Активна")
                            {
                                MacroBalanced(DailyBMR34);
                            }
                            if (activityComboBox.SelectedItem == "Много активна")
                            {
                                MacroBalanced(intenseBMR67);
                            }
                            if (activityComboBox.SelectedItem == "Екстра активна")
                            {
                                MacroBalanced(veryIntenseBMR);
                            }
                            command.Parameters.AddWithValue("@ActivitySelection", activityComboBox.SelectedItem.ToString());
                            connection.Open();
                            
                            command.ExecuteNonQuery();
                            if (activityComboBox.Text != "")
                            {
                                hiddenPanel2.Visible = false;

                            }
                        }
                    }
                }
                else
                {
                    hiddenPanel1.Visible = true;
                    hiddenPanel2.Visible = true;
                }
            }
        }

        private void balancedButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balancedSelected;
                highProteinButton.Image = Properties.Resources.highProtein;
                lowFatButton.Image = Properties.Resources.lowFat;
                lowCarbsButton.Image = Properties.Resources.lowCarbs;
                balancedClicked = true;
                highProteinClicked = false;
                lowFatClicked = false;
                lowCarbsClicked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "Balanced");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Sedentary")
                {
                    MacroBalanced(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Light")
                {
                    MacroBalanced(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Moderate")
                {
                    MacroBalanced(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Active")
                {
                    MacroBalanced(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Very active")
                {
                    MacroBalanced(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Extra active")
                {
                    MacroBalanced(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balancedSelectedbg;
                highProteinButton.Image = Properties.Resources.highProteinbg;
                lowFatButton.Image = Properties.Resources.lowFatbg;
                lowCarbsButton.Image = Properties.Resources.lowCarbsbg;
                balancedClicked = true;
                highProteinClicked = false;
                lowFatClicked = false;
                lowCarbsClicked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "Balanced");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Заседналост")
                {
                    MacroBalanced(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Лека")
                {
                    MacroBalanced(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Умерена")
                {
                    MacroBalanced(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Активна")
                {
                    MacroBalanced(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Много активна")
                {
                    MacroBalanced(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Екстра активна")
                {
                    MacroBalanced(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
        }

        private void highProteinButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balanced;
                highProteinButton.Image = Properties.Resources.highProteinSelected;
                lowFatButton.Image = Properties.Resources.lowFat;
                lowCarbsButton.Image = Properties.Resources.lowCarbs;
                balancedClicked = false;
                highProteinClicked = true;
                lowFatClicked = false;
                lowCarbsClicked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "HighProtein");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Sedentary")
                {
                    MacroHighProtein(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Light")
                {
                    MacroHighProtein(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Moderate")
                {
                    MacroHighProtein(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Active")
                {
                    MacroHighProtein(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Very active")
                {
                    MacroHighProtein(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Extra active")
                {
                    MacroHighProtein(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balancedbg;
                highProteinButton.Image = Properties.Resources.highProteinSelectedbg;
                lowFatButton.Image = Properties.Resources.lowFatbg;
                lowCarbsButton.Image = Properties.Resources.lowCarbsbg;
                balancedClicked = false;
                highProteinClicked = true;
                lowFatClicked = false;
                lowCarbsClicked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "HighProtein");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Заседналост")
                {
                    MacroHighProtein(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Лека")
                {
                    MacroHighProtein(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Умерена")
                {
                    MacroHighProtein(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Активна")
                {
                    MacroHighProtein(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Много активна")
                {
                    MacroHighProtein(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Екстра активна")
                {
                    MacroHighProtein(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
        }

        private void lowFatButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balanced;
                highProteinButton.Image = Properties.Resources.highProtein;
                lowFatButton.Image = Properties.Resources.lowFatSelected;
                lowCarbsButton.Image = Properties.Resources.lowCarbs;
                balancedClicked = false;
                highProteinClicked = false;
                lowFatClicked = true;
                lowCarbsClicked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "LowFat");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Sedentary")
                {
                    MacroLowFat(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Light")
                {
                    MacroLowFat(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Moderate")
                {
                    MacroLowFat(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Active")
                {
                    MacroLowFat(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Very active")
                {
                    MacroLowFat(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Extra active")
                {
                    MacroLowFat(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balancedbg;
                highProteinButton.Image = Properties.Resources.highProteinbg;
                lowFatButton.Image = Properties.Resources.lowFatSelectedbg;
                lowCarbsButton.Image = Properties.Resources.lowCarbsbg;
                balancedClicked = false;
                highProteinClicked = false;
                lowFatClicked = true;
                lowCarbsClicked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "LowFat");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Заседналост")
                {
                    MacroLowFat(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Лека")
                {
                    MacroLowFat(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Умерена")
                {
                    MacroLowFat(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Активна")
                {
                    MacroLowFat(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Много активна")
                {
                    MacroLowFat(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Екстра активна")
                {
                    MacroLowFat(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
        }

        private void lowCarbsButton_Click(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balanced;
                highProteinButton.Image = Properties.Resources.highProtein;
                lowFatButton.Image = Properties.Resources.lowFat;
                lowCarbsButton.Image = Properties.Resources.lowCarbsSelected;
                balancedClicked = false;
                highProteinClicked = false;
                lowFatClicked = false;
                lowCarbsClicked = true;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "LowCarbs");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Sedentary")
                {
                    MacroLowCarb(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Light")
                {
                    MacroLowCarb(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Moderate")
                {
                    MacroLowCarb(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Active")
                {
                    MacroLowCarb(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Very active")
                {
                    MacroLowCarb(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Extra active")
                {
                    MacroLowCarb(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                ifSearchNotClicked(sender, e);
                balancedButton.Image = Properties.Resources.balancedbg;
                highProteinButton.Image = Properties.Resources.highProteinbg;
                lowFatButton.Image = Properties.Resources.lowFatbg;
                lowCarbsButton.Image = Properties.Resources.lowCarbsSelectedbg;
                balancedClicked = false;
                highProteinClicked = false;
                lowFatClicked = false;
                lowCarbsClicked = true;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE UserNutrition " +
                                   "SET MacroSelection = @MacroSelection " +
                                   "WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", _userID);
                        command.Parameters.AddWithValue("@MacroSelection", "LowCarbs");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                if (activityComboBox.SelectedItem == "Заседналост")
                {
                    MacroLowCarb(sedentaryBMR);
                }
                if (activityComboBox.SelectedItem == "Лека")
                {
                    MacroLowCarb(exerciseBMR13);
                }
                if (activityComboBox.SelectedItem == "Умерена")
                {
                    MacroLowCarb(exerciseBMR45);
                }
                if (activityComboBox.SelectedItem == "Активна")
                {
                    MacroLowCarb(DailyBMR34);
                }
                if (activityComboBox.SelectedItem == "Много активна")
                {
                    MacroLowCarb(intenseBMR67);
                }
                if (activityComboBox.SelectedItem == "Екстра активна")
                {
                    MacroLowCarb(veryIntenseBMR);
                }
                if (activityComboBox.Text != "")
                {
                    hiddenPanel1.Visible = false;
                }
            }
        }

        private void balancedButton_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!balancedClicked)
                {
                    balancedButton.Image = Properties.Resources.balancedHover;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!balancedClicked)
                {
                    balancedButton.Image = Properties.Resources.balancedHoverbg;
                }
            }
        }

        private void balancedButton_MouseLeave(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!balancedClicked)
                {
                    balancedButton.Image = Properties.Resources.balanced;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!balancedClicked)
                {
                    balancedButton.Image = Properties.Resources.balancedbg;
                }
            }
        }

        private void highProteinButton_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!highProteinClicked)
                {
                    highProteinButton.Image = Properties.Resources.highProteinHover;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!highProteinClicked)
                {
                    highProteinButton.Image = Properties.Resources.highProteinHoverbg;
                }
            }
        }

        private void highProteinButton_MouseLeave(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!highProteinClicked)
                {
                    highProteinButton.Image = Properties.Resources.highProtein;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!highProteinClicked)
                {
                    highProteinButton.Image = Properties.Resources.highProteinbg;
                }
            }
        }

        private void lowFatButton_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!lowFatClicked)
                {
                    lowFatButton.Image = Properties.Resources.lowFatHover;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!lowFatClicked)
                {
                    lowFatButton.Image = Properties.Resources.lowFatHoverbg;
                }
            }
        }

        private void lowFatButton_MouseLeave(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!lowFatClicked)
                {
                    lowFatButton.Image = Properties.Resources.lowFat;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!lowFatClicked)
                {
                    lowFatButton.Image = Properties.Resources.lowFatbg;
                }
            }
        }

        private void lowCarbsButton_MouseEnter(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!lowCarbsClicked)
                {
                    lowCarbsButton.Image = Properties.Resources.lowCarbsHover;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!lowCarbsClicked)
                {
                    lowCarbsButton.Image = Properties.Resources.lowCarbsHoverbg;
                }
            }
        }

        private void lowCarbsButton_MouseLeave(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                if (!lowCarbsClicked)
                {
                    lowCarbsButton.Image = Properties.Resources.lowCarbs;
                }
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                if (!lowCarbsClicked)
                {
                    lowCarbsButton.Image = Properties.Resources.lowCarbsbg;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            if (searchPanel.Visible != true && searchTextBox.Text != "")
            {
                searchPanel.Controls.Clear();
                searchFoodItems.Clear();
                string keyword = searchTextBox.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM FoodItems WHERE Name LIKE @keyword";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                searchPanel.Visible = true;
                                SearchFoodItem searchFoodItem = new SearchFoodItem();
                                searchFoodItem.FoodName = reader["Name"].ToString();
                                searchFoodItem.FoodCalories = double.Parse(reader["Calories"].ToString());
                                searchFoodItem.FoodProtein = double.Parse(reader["Protein"].ToString());
                                searchFoodItem.FoodCarbs = double.Parse(reader["Carbohydrates"].ToString());
                                searchFoodItem.FoodFat = double.Parse(reader["Fat"].ToString());
                                searchFoodItem.FoodGrams = 100;
                                searchFoodItem.FoodImage = reader["Image"].ToString();
                                searchFoodItems.Add(searchFoodItem);
                            }
                        }
                    }
                }
                searchPanel.Height = 0;
                for (int i = 0; i < searchFoodItems.Count; i++)
                {
                    string foodName = searchFoodItems[i].FoodName;
                    double foodCalories = searchFoodItems[i].FoodCalories;
                    double foodProtein = searchFoodItems[i].FoodProtein;
                    double foodCarbs = searchFoodItems[i].FoodCarbs;
                    double foodFat = searchFoodItems[i].FoodFat;
                    double foodGrams = searchFoodItems[i].FoodGrams;
                    string foodImage = searchFoodItems[i].FoodImage;
                    searchFoodItems[i].ButtonClicked += (sender, e) => searchFoodItem_Click(sender, e, foodName, foodCalories, foodProtein, foodCarbs, foodFat, foodGrams, foodImage);
                    if (searchPanel.Height < 120)
                    {
                        searchPanel.Height += 40;
                    }
                    searchPanel.Controls.Add(searchFoodItems[i]);
                }
            }
            else if (searchPanel.Visible == true && searchTextBox.Text != "")
            {
                searchPanel.Controls.Clear();
                searchFoodItems.Clear();
                string keyword = searchTextBox.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM FoodItems WHERE Name LIKE @keyword";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                SearchFoodItem searchFoodItem = new SearchFoodItem();
                                searchFoodItem.FoodName = reader["Name"].ToString();
                                searchFoodItem.FoodCalories = double.Parse(reader["Calories"].ToString());
                                searchFoodItem.FoodProtein = double.Parse(reader["Protein"].ToString());
                                searchFoodItem.FoodCarbs = double.Parse(reader["Carbohydrates"].ToString());
                                searchFoodItem.FoodFat = double.Parse(reader["Fat"].ToString());
                                searchFoodItem.FoodGrams = 100;
                                searchFoodItem.FoodImage = reader["Image"].ToString();
                                searchFoodItems.Add(searchFoodItem);
                            }
                        }
                    }
                }
                searchPanel.Height = 0;
                for (int i = 0; i < searchFoodItems.Count; i++)
                {
                    string foodName = searchFoodItems[i].FoodName;
                    double foodCalories = searchFoodItems[i].FoodCalories;
                    double foodProtein = searchFoodItems[i].FoodProtein;
                    double foodCarbs = searchFoodItems[i].FoodCarbs;
                    double foodFat = searchFoodItems[i].FoodFat;
                    double foodGrams = searchFoodItems[i].FoodGrams;
                    string foodImage = searchFoodItems[i].FoodImage;
                    searchFoodItems[i].ButtonClicked += (sender, e) => searchFoodItem_Click(sender, e, foodName, foodCalories, foodProtein, foodCarbs, foodFat, foodGrams, foodImage);
                    if (searchPanel.Height < 120)
                    {
                        searchPanel.Height += 40;
                    }
                    searchPanel.Controls.Add(searchFoodItems[i]);
                }
            }
            else
            {
                searchTextBox.StateCommon.Border.Color1 = Color.Red;
                searchTextBox.StateNormal.Border.Color1 = Color.Red;
                var cfg = new Config("FitVitality.ini");
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    searchTextBox.CueHint.CueHintText = "Search must not be empty.";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    searchTextBox.CueHint.CueHintText = "Търсачката не тможе да е празна.";
                }
                searchTextBox.CueHint.Color1 = Color.Red;
            }
        }

        private void searchPanel_Leave(object sender, EventArgs e)
        {

        }
        private void ifSearchNotClicked(object sender, EventArgs e)
        {
            if (searchPanel.Visible == true)
            {
                searchPanel.Visible = false;
                searchFoodItems.Clear();
                searchPanel.Controls.Clear();
                searchTextBox.Enabled = false;
                searchTextBox.Enabled = true;
                var cfg = new Config("FitVitality.ini");
                if (cfg.Read("Language", "SETTINGS") == "en")
                {
                    searchTextBox.CueHint.CueHintText = "Search";
                }
                if (cfg.Read("Language", "SETTINGS") == "bg")
                {
                    searchTextBox.CueHint.CueHintText = "Търси";
                }
                searchTextBox.CueHint.Color1 = Color.FromArgb(63, 63, 63);
                searchTextBox.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
                searchTextBox.StateNormal.Border.Color1 = Color.FromArgb(177, 192, 214);
            }
        }

        private void foodPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodPanel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void Diet_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void macroАbbreviation_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void manageGoalDescription_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void activityLevelLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void activityComboBox_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void manageGoalLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void addFoodLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void dailyGoalLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void dietLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void kCalLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void calorieIntake_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void cLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void carbohydrates_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void pLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void protein_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void fLabel_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }

        private void fat_Click(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }
        private void searchFoodItem_Click(object sender, EventArgs e, string name, double calories, double protein, double carbs, double fat, double grams, string image)
        {
            searchPanel.Visible = false;
            searchFoodItems.Clear();
            searchPanel.Controls.Clear();
            FoodItem foodItem = new FoodItem();
            foodItem.FoodName = name;
            foodItem.FoodCalories = calories;
            foodItem.FoodProtein = protein;
            foodItem.FoodCarbs = carbs;
            foodItem.FoodFat = fat;
            foodItem.FoodGrams = grams;
            foodItem.CaloriesStatic = calories;
            foodItem.ProteinStatic = protein;
            foodItem.CarbsStatic = carbs;
            foodItem.FatStatic = fat;
            foodItem.FoodImage = image;
            foodItem.ButtonClicked += (sender, e) => foodItem_Click(sender, e);
            foodItem.Add += (sender, e) => foodItem_Add(sender, e, calories, protein, carbs, fat);
            foodItem.Remove += (sender, e) => foodItem_Remove(sender, e, calories, protein, carbs, fat);
            foodPanel.Controls.Add(foodItem);
            foodItems.Add(foodItem);
            currentCalories += (int)Math.Round(foodItem.FoodCalories, 0);
            currentCarbs += (int)Math.Round(foodItem.FoodCarbs, 0);
            currentProtein += (int)Math.Round(foodItem.FoodProtein, 0);
            currentFats += (int)Math.Round(foodItem.FoodFat, 0);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["MacroSelection"].ToString() != String.Empty)
                            {
                                switch (reader["MacroSelection"].ToString())
                                {
                                    case "Balanced":
                                        balancedButton_Click(sender, e);
                                        break;
                                    case "HighProtein":
                                        highProteinButton_Click(sender, e);
                                        break;
                                    case "LowFat":
                                        lowFatButton_Click(sender, e);
                                        break;
                                    case "LowCarbs":
                                        lowCarbsButton_Click(sender, e);
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            string items = "";
            string itemsamount = "";
            string itemsCalories = "";
            string itemsProtein = "";
            string itemsCarbs = "";
            string itemsFat = "";
            for (int i = 0; i < foodItems.Count; i++)
            {
                items += foodItems[i].FoodName + ",";
                itemsamount += foodItems[i].FoodGrams + ",";
                itemsCalories += foodItems[i].FoodCalories + ",";
                itemsProtein += foodItems[i].FoodProtein + ",";
                itemsCarbs += foodItems[i].FoodCarbs + ",";
                itemsFat += foodItems[i].FoodFat + ",";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE UserNutrition " +
                               "SET Items = @FoodItems, ItemsAmount = @FoodAmount, ItemsCalories = @FoodCalories, ItemsProtein = @FoodProtein, ItemsCarbs = @FoodCarbs, ItemsFats = @FoodFat " +
                               "WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    command.Parameters.AddWithValue("@FoodItems", items);
                    command.Parameters.AddWithValue("@FoodAmount", itemsamount);
                    command.Parameters.AddWithValue("@FoodCalories", itemsCalories);
                    command.Parameters.AddWithValue("@FoodProtein", itemsProtein);
                    command.Parameters.AddWithValue("@FoodCarbs", itemsCarbs);
                    command.Parameters.AddWithValue("@FoodFat", itemsFat);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void foodItem_Add(object sender, EventArgs e, double calories, double protein, double carbs, double fat)
        {
            for (int i = 0; i < foodItems.Count; i++)
            {
                if (foodItems[i].Equals(sender))
                {

                    currentCalories += (int)Math.Round(foodItems[i].CaloriesDynamic, 0);
                    currentCarbs += (int)Math.Round(foodItems[i].CarbsDynamic, 0);
                    currentProtein += (int)Math.Round(foodItems[i].ProteinDynamic, 0);
                    currentFats += (int)Math.Round(foodItems[i].FatDynamic, 0);

                    activityComboBox_SelectedIndexChanged(sender, e);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", _userID);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    if (reader["MacroSelection"].ToString() != String.Empty)
                                    {
                                        switch (reader["MacroSelection"].ToString())
                                        {
                                            case "Balanced":
                                                balancedButton_Click(sender, e);
                                                break;
                                            case "HighProtein":
                                                highProteinButton_Click(sender, e);
                                                break;
                                            case "LowFat":
                                                lowFatButton_Click(sender, e);
                                                break;
                                            case "LowCarbs":
                                                lowCarbsButton_Click(sender, e);
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            string items = "";
            string itemsamount = "";
            string itemsCalories = "";
            string itemsProtein = "";
            string itemsCarbs = "";
            string itemsFat = "";
            for (int i = 0; i < foodItems.Count; i++)
            {
                items += foodItems[i].FoodName + ",";
                itemsamount += foodItems[i].FoodGrams + ",";
                itemsCalories += foodItems[i].FoodCalories + ",";
                itemsProtein += foodItems[i].FoodProtein + ",";
                itemsCarbs += foodItems[i].FoodCarbs + ",";
                itemsFat += foodItems[i].FoodFat + ",";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE UserNutrition " +
                               "SET Items = @FoodItems, ItemsAmount = @FoodAmount, ItemsCalories = @FoodCalories, ItemsProtein = @FoodProtein, ItemsCarbs = @FoodCarbs, ItemsFats = @FoodFat " +
                               "WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    command.Parameters.AddWithValue("@FoodItems", items);
                    command.Parameters.AddWithValue("@FoodAmount", itemsamount);
                    command.Parameters.AddWithValue("@FoodCalories", itemsCalories);
                    command.Parameters.AddWithValue("@FoodProtein", itemsProtein);
                    command.Parameters.AddWithValue("@FoodCarbs", itemsCarbs);
                    command.Parameters.AddWithValue("@FoodFat", itemsFat);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void foodItem_Remove(object sender, EventArgs e, double calories, double protein, double carbs, double fat)
        {
            for (int i = 0; i < foodItems.Count; i++)
            {
                if (foodItems[i].Equals(sender))
                {
                    currentCalories -= (int)Math.Round(foodItems[i].CaloriesDynamic, 0);
                    currentCarbs -= (int)Math.Round(foodItems[i].CarbsDynamic, 0);
                    currentProtein -= (int)Math.Round(foodItems[i].ProteinDynamic, 0);
                    currentFats -= (int)Math.Round(foodItems[i].FatDynamic, 0);

                    activityComboBox_SelectedIndexChanged(sender, e);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", _userID);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    if (reader["MacroSelection"].ToString() != String.Empty)
                                    {
                                        switch (reader["MacroSelection"].ToString())
                                        {
                                            case "Balanced":
                                                balancedButton_Click(sender, e);
                                                break;
                                            case "HighProtein":
                                                highProteinButton_Click(sender, e);
                                                break;
                                            case "LowFat":
                                                lowFatButton_Click(sender, e);
                                                break;
                                            case "LowCarbs":
                                                lowCarbsButton_Click(sender, e);
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            string items = "";
            string itemsamount = "";
            string itemsCalories = "";
            string itemsProtein = "";
            string itemsCarbs = "";
            string itemsFat = "";
            for (int i = 0; i < foodItems.Count; i++)
            {
                items += foodItems[i].FoodName + ",";
                itemsamount += foodItems[i].FoodGrams + ",";
                itemsCalories += foodItems[i].FoodCalories + ",";
                itemsProtein += foodItems[i].FoodProtein + ",";
                itemsCarbs += foodItems[i].FoodCarbs + ",";
                itemsFat += foodItems[i].FoodFat + ",";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE UserNutrition " +
                               "SET Items = @FoodItems, ItemsAmount = @FoodAmount, ItemsCalories = @FoodCalories, ItemsProtein = @FoodProtein, ItemsCarbs = @FoodCarbs, ItemsFats = @FoodFat " +
                               "WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    command.Parameters.AddWithValue("@FoodItems", items);
                    command.Parameters.AddWithValue("@FoodAmount", itemsamount);
                    command.Parameters.AddWithValue("@FoodCalories", itemsCalories);
                    command.Parameters.AddWithValue("@FoodProtein", itemsProtein);
                    command.Parameters.AddWithValue("@FoodCarbs", itemsCarbs);
                    command.Parameters.AddWithValue("@FoodFat", itemsFat);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void foodItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < foodItems.Count; i++)
            {
                if (foodItems[i].Equals(sender))
                {
                    currentCalories -= (int)Math.Round(foodItems[i].FoodCalories, 0);
                    currentCarbs -= (int)Math.Round(foodItems[i].FoodCarbs, 0);
                    currentProtein -= (int)Math.Round(foodItems[i].FoodProtein, 0);
                    currentFats -= (int)Math.Round(foodItems[i].FoodFat, 0);
                    foodItems.RemoveAt(i);
                    foodPanel.Controls.RemoveAt(i);
                    if (currentCalories < 0 || currentCarbs < 0 || currentFats < 0 || currentProtein < 0)
                    {
                        currentCalories = 0;
                        currentCarbs = 0;
                        currentProtein = 0;
                        currentFats = 0;
                    }
                    if (foodItems.Count < 1)
                    {
                        currentCalories = 0;
                        currentCarbs = 0;
                        currentProtein = 0;
                        currentFats = 0;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM UserNutrition WHERE UserID = @UserID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", _userID);
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    if (reader["MacroSelection"].ToString() != String.Empty)
                                    {
                                        switch (reader["MacroSelection"].ToString())
                                        {
                                            case "Balanced":
                                                balancedButton_Click(sender, e);
                                                break;
                                            case "HighProtein":
                                                highProteinButton_Click(sender, e);
                                                break;
                                            case "LowFat":
                                                lowFatButton_Click(sender, e);
                                                break;
                                            case "LowCarbs":
                                                lowCarbsButton_Click(sender, e);
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string items = "";
            string itemsamount = "";
            string itemsCalories = "";
            string itemsProtein = "";
            string itemsCarbs = "";
            string itemsFat = "";
            for (int i = 0; i < foodItems.Count; i++)
            {
                items += foodItems[i].FoodName + ",";
                itemsamount += foodItems[i].FoodGrams + ",";
                itemsCalories += foodItems[i].FoodCalories + ",";
                itemsProtein += foodItems[i].FoodProtein + ",";
                itemsCarbs += foodItems[i].FoodCarbs + ",";
                itemsFat += foodItems[i].FoodFat + ",";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE UserNutrition " +
                               "SET Items = @FoodItems, ItemsAmount = @FoodAmount, ItemsCalories = @FoodCalories, ItemsProtein = @FoodProtein, ItemsCarbs = @FoodCarbs, ItemsFats = @FoodFat  " +
                               "WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    command.Parameters.AddWithValue("@FoodItems", items);
                    command.Parameters.AddWithValue("@FoodAmount", itemsamount);
                    command.Parameters.AddWithValue("@FoodCalories", itemsCalories);
                    command.Parameters.AddWithValue("@FoodProtein", itemsProtein);
                    command.Parameters.AddWithValue("@FoodCarbs", itemsCarbs);
                    command.Parameters.AddWithValue("@FoodFat", itemsFat);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTextBox.StateCommon.Border.Color1 = Color.FromArgb(177, 192, 214);
            searchTextBox.StateNormal.Border.Color1 = Color.FromArgb(177, 192, 214);
            searchTextBox.CueHint.CueHintText = "";
            searchTextBox.CueHint.Color1 = Color.FromArgb(177, 192, 214);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                searchIcon_Click(this, new EventArgs());
            }
        }

        private void searchIcon_MouseHover(object sender, EventArgs e)
        {

        }

        private void Diet_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void Diet_Leave(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE UserNutrition " +
                    "SET CurrentCalories = @CurrentCalories, CurrentProtein = @CurrentProtein, CurrentCarbs = @CurrentCarbs, CurrentFats = @CurrentFats, " +
                    "CaloriesGoal = @CaloriesGoal, ProteinGoal = @ProteinGoal, FatsGoal = @FatsGoal, CarbsGoal = @CarbsGoal " +
                    "WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    command.Parameters.AddWithValue("@CurrentCalories", currentCalories);
                    command.Parameters.AddWithValue("@CurrentProtein", currentProtein);
                    command.Parameters.AddWithValue("@CurrentCarbs", currentCarbs);
                    command.Parameters.AddWithValue("@CurrentFats", currentFats);
                    command.Parameters.AddWithValue("@CaloriesGoal", caloriesGoal);
                    command.Parameters.AddWithValue("@ProteinGoal", proteinGoal);
                    command.Parameters.AddWithValue("@FatsGoal", fatsGoal);
                    command.Parameters.AddWithValue("@CarbsGoal", carbsGoal);
                    command.ExecuteNonQuery();
                }
            }
            double caloriePercentage = ((double)currentCalories / (double)caloriesGoal) * 100;
            double proteinPercentage = ((double)currentProtein / (double)proteinGoal) * 100;
            double carbsPercentage = ((double)currentCarbs / (double)carbsGoal) * 100;
            double fatsPercentage = ((double)currentFats / (double)fatsGoal) * 100;
            if (currentCalories > caloriesGoal)
            {
                caloriePercentage = 100;
            }
            if (currentProtein > proteinGoal)
            {
                proteinPercentage = 100;
            }
            if (currentCarbs > carbsGoal)
            {
                carbsPercentage = 100;
            }
            if (currentFats > fatsGoal)
            {
                fatsPercentage = 100;
            }

            double totalPercentage = (caloriePercentage + proteinPercentage + carbsPercentage + fatsPercentage) / 4;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "";
                if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Monday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                else if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Tuesday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                else if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Wednesday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                else if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Thursday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                else if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Friday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                else if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Saturday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                else if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                {
                    query = "UPDATE WeeklyInformation " +
                   "SET Sunday = @Percentage " +
                   "WHERE UserID = @UserID";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    command.Parameters.AddWithValue("@Percentage", (int)totalPercentage);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void activityComboBox_Click_1(object sender, EventArgs e)
        {
            ifSearchNotClicked(sender, e);
        }
    }
}
