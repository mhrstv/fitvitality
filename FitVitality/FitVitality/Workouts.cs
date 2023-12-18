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

    public partial class Workouts : Form
    {
        public string _userID;

        // Булеви променливи, които отбелязват къде ще се изпълнява тренировката
        bool gymClicked = false;
        bool homeClicked = false;
        bool outdoorsClicked = false;

        // Булеви променливи, които отбелязват кои части от тялото ще се тренират
        bool upperBodyClicked = false;
        bool coreClicked = false;
        bool lowerBodyClicked = false;

        // Допълнителни булеви променливи, които отбелязват какъв тип тренировка ще се изпълнява
        bool cardioClicked = false;

        string workoutPlace = "";
        int activity;

        private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public Workouts(string userID)
        {
            InitializeComponent();
            _userID = userID;


        }
        private void Workouts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            gymButton.Image = Properties.Resources.gymPressed;
            homeButton.Image = Properties.Resources.home1;
            outdoorsButton.Image = Properties.Resources.outdoors;
            gymClicked = true;
            homeClicked = false;
            outdoorsClicked = false;
            nextButton1.Visible = true;
            workoutPlace = "Gym";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            gymButton.Image = Properties.Resources.gym;
            homeButton.Image = Properties.Resources.homePressed;
            outdoorsButton.Image = Properties.Resources.outdoors;
            gymClicked = false;
            homeClicked = true;
            outdoorsClicked = false;
            nextButton1.Visible = true;
            workoutPlace = "Home";
        }

        private void outdoorsButton_Click(object sender, EventArgs e)
        {
            gymButton.Image = Properties.Resources.gym;
            homeButton.Image = Properties.Resources.home1;
            outdoorsButton.Image = Properties.Resources.outdoorsPressed;
            gymClicked = false;
            homeClicked = false;
            outdoorsClicked = true;
            nextButton1.Visible = true;
            workoutPlace = "Outdoors";
        }

        private void gymButton_MouseEnter(object sender, EventArgs e)
        {
            if (!gymClicked)
            {
                gymButton.Image = Properties.Resources.gymHover;
            }
        }

        private void gymButton_MouseLeave(object sender, EventArgs e)
        {
            if (!gymClicked)
            {
                gymButton.Image = Properties.Resources.gym;
            }
        }

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            if (!homeClicked)
            {
                homeButton.Image = Properties.Resources.homeHover;
            }
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            if (!homeClicked)
            {
                homeButton.Image = Properties.Resources.home1;
            }
        }

        private void outdoorsButton_MouseEnter(object sender, EventArgs e)
        {
            if (!outdoorsClicked)
            {
                outdoorsButton.Image = Properties.Resources.outdoorsHovered;
            }
        }

        private void outdoorsButton_MouseLeave(object sender, EventArgs e)
        {
            if (!outdoorsClicked)
            {
                outdoorsButton.Image = Properties.Resources.outdoors;
            }
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            trainPlacePanel.Visible = false;
            muscleGroupsPanel.Visible = true;
        }

        private void muscleGroupsBorders_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            {
                connection.Open();
                string query = "UPDATE UserSettings SET ActivityLevel = @ActivityLevel WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ActivityLevel", activity);
                command.Parameters.AddWithValue("@UserID", _userID);
                command.ExecuteNonQuery();
            }

        }

        private void activityLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (activityLevelComboBox.SelectedIndex)
            {
                case 0:
                    activity = 1;
                    nextButton2.Visible = true;
                    break;
                case 1:
                    activity = 2;
                    nextButton2.Visible = true;
                    break;
                case 2:
                    activity = 3;
                    nextButton2.Visible = true;
                    break;
                case 3:
                    activity = 4;
                    nextButton2.Visible = true;
                    break;
                case 4:
                    activity = 5;
                    nextButton2.Visible = true;
                    break;
                case 5:
                    activity = 6;
                    nextButton2.Visible = true;
                    break;
                case 6:
                    activity = 7;
                    nextButton2.Visible = true;
                    break;
                default:
                    nextButton2.Visible = false;
                    break;
            }
        }
    }
}
