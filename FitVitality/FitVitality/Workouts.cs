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

        // Булеви променливи, които отбелязват дали е натиснато да или не
        bool yesClicked = false;
        bool noClicked = false;

        // Допълнителни булеви променливи, които отбелязват какъв тип тренировка ще се изпълнява
        bool cardioClicked = false;
        string name = "";

        // Булеви променливи, които отбелязват дали е натиснато готова тренировка или създаване на собствена
        bool preClicked = false;
        bool createClicked = false;

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Name FROM UserSettings WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Name"].ToString();
                        }
                    }
                }
            }
            trainPlaceLabel.Text = $"Hello, {name}. This is the workout section and we will \r\nask you a few questions in order to create the \r\nperfect workout for you.\r\nTo begin with, what place do you desire to workout at?\r\n";
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
            activityGroupPanel.Visible = true;
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
            muscleGroupPanel.Visible = true;
            activityGroupPanel.Visible = false;
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

        private void upperButton_Click(object sender, EventArgs e)
        {
            if (upperBodyClicked)
            {
                upperBodyClicked = false;
                upperButton.Image = Properties.Resources.upper;
            }
            else
            {
                upperBodyClicked = true;
                upperButton.Image = Properties.Resources.upperPressed;
            }

            if (upperBodyClicked || lowerBodyClicked || coreClicked)
            {
                nextButton3.Visible = true;
            }
            else
            {
                nextButton3.Visible = false;
            }
        }

        private void lowerButton_Click(object sender, EventArgs e)
        {
            if (lowerBodyClicked)
            {
                lowerBodyClicked = false;
                lowerButton.Image = Properties.Resources.lower;
            }
            else
            {
                lowerBodyClicked = true;
                lowerButton.Image = Properties.Resources.lowerPressed;
            }

            if (upperBodyClicked || lowerBodyClicked || coreClicked)
            {
                nextButton3.Visible = true;
            }
            else
            {
                nextButton3.Visible = false;
            }
        }

        private void coreButton_Click(object sender, EventArgs e)
        {
            if (coreClicked)
            {
                coreClicked = false;
                coreButton.Image = Properties.Resources.core;
            }
            else
            {
                coreClicked = true;
                coreButton.Image = Properties.Resources.corePressed;
            }

            if (upperBodyClicked || lowerBodyClicked || coreClicked)
            {
                nextButton3.Visible = true;
            }
            else
            {
                nextButton3.Visible = false;
            }
        }

        private void upperButton_MouseEnter(object sender, EventArgs e)
        {
            upperButton.Image = Properties.Resources.upperHover;
        }

        private void upperButton_MouseLeave(object sender, EventArgs e)
        {
            if (!upperBodyClicked)
            {
                upperButton.Image = Properties.Resources.upper;
            }
            else
            {
                upperButton.Image = Properties.Resources.upperPressed;
            }
        }

        private void lowerButton_MouseEnter(object sender, EventArgs e)
        {
            lowerButton.Image = Properties.Resources.lowerHover;
        }

        private void lowerButton_MouseLeave(object sender, EventArgs e)
        {
            if (!lowerBodyClicked)
            {
                lowerButton.Image = Properties.Resources.lower;
            }
            else
            {
                lowerButton.Image = Properties.Resources.lowerPressed;
            }
        }

        private void coreButton_MouseEnter(object sender, EventArgs e)
        {
            coreButton.Image = Properties.Resources.coreHovered;
        }

        private void coreButton_MouseLeave(object sender, EventArgs e)
        {
            if (!coreClicked)
            {
                coreButton.Image = Properties.Resources.core;
            }
            else
            {
                coreButton.Image = Properties.Resources.corePressed;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            muscleGroupPanel.Visible = false;
            if (upperBodyClicked)
                upperBodyPanel.Visible = true;
            if (!upperBodyClicked && lowerBodyClicked)
                lowerBodyPanel.Visible = true;
            if (!upperBodyClicked && !lowerBodyClicked)
                cardioPanel.Visible = true;
        }

        private void shouldersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (shouldersCheckBox.Checked)
            {
                shouldersPicture.Image = Properties.Resources.shouldersSelected;
                nextButton4.Visible = true;
            }
            else
            {
                shouldersPicture.Image = Properties.Resources.shoulders;
                if (!armsCheckBox.Checked && !backCheckBox.Checked && !chestCheckBox.Checked)
                {
                    nextButton4.Visible = false;
                }
            }
        }

        private void chestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chestCheckBox.Checked)
            {
                chestPicture.Image = Properties.Resources.chestSelected;
                nextButton4.Visible = true;
            }
            else
            {
                chestPicture.Image = Properties.Resources.chest;
                if (!armsCheckBox.Checked && !shouldersCheckBox.Checked && !backCheckBox.Checked)
                {
                    nextButton4.Visible = false;
                }
            }
        }

        private void armsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (armsCheckBox.Checked)
            {
                armsPicture.Image = Properties.Resources.armsSelected;
                nextButton4.Visible = true;
            }
            else
            {
                armsPicture.Image = Properties.Resources.arms;
                if (!backCheckBox.Checked && !shouldersCheckBox.Checked && !chestCheckBox.Checked)
                {
                    nextButton4.Visible = false;
                }
            }
        }

        private void backCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (backCheckBox.Checked)
            {
                backPicture.Image = Properties.Resources.backSelected;
                nextButton4.Visible = true;
            }
            else
            {
                backPicture.Image = Properties.Resources.back;
                if (!armsCheckBox.Checked && !shouldersCheckBox.Checked && !chestCheckBox.Checked)
                {
                    nextButton4.Visible = false;
                }
            }
        }

        private void nextButton4_Click(object sender, EventArgs e)
        {
            if (lowerBodyClicked)
            {
                lowerBodyPanel.Visible = true;
                upperBodyPanel.Visible = false;
            }
            else
            {
                upperBodyPanel.Visible = false;
                cardioPanel.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (quadricepsCheckBox.Checked)
            {
                quadricepsPicture.Image = Properties.Resources.quadricepsSelected;
                nextButton5.Visible = true;
            }
            else
            {
                quadricepsPicture.Image = Properties.Resources.quadriceps;
                if (!hamstringsCheckBox.Checked && !calvesCheckBox.Checked && !glutesCheckBox.Checked)
                {
                    nextButton5.Visible = false;
                }
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (hamstringsCheckBox.Checked)
            {
                hamstringsPicture.Image = Properties.Resources.hamstringsSelected;
                nextButton5.Visible = true;
            }
            else
            {
                hamstringsPicture.Image = Properties.Resources.hamstrings;
                if (!quadricepsCheckBox.Checked && !calvesCheckBox.Checked && !glutesCheckBox.Checked)
                {
                    nextButton5.Visible = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (calvesCheckBox.Checked)
            {
                calvesPicture.Image = Properties.Resources.calvesSelected;
                nextButton5.Visible = true;
            }
            else
            {
                calvesPicture.Image = Properties.Resources.calves;
                if (!hamstringsCheckBox.Checked && !quadricepsCheckBox.Checked && !glutesCheckBox.Checked)
                {
                    nextButton5.Visible = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (glutesCheckBox.Checked)
            {
                glutesPicture.Image = Properties.Resources.glutesSelected;
                nextButton5.Visible = true;
            }
            else
            {
                glutesPicture.Image = Properties.Resources.glutes;
                if (!hamstringsCheckBox.Checked && !calvesCheckBox.Checked && !quadricepsCheckBox.Checked)
                {
                    nextButton5.Visible = false;
                }
            }
        }

        private void nextButton5_Click(object sender, EventArgs e)
        {
            lowerBodyPanel.Visible = false;
            upperBodyPanel.Visible = false;
            cardioPanel.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            yesPictureBox.Image = Properties.Resources.yesSelected;
            noPictureBox.Image = Properties.Resources.no;
            yesClicked = true;
            noClicked = false;
            nextButton6.Visible = true;
            cardioClicked = true;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            noPictureBox.Image = Properties.Resources.noSelected;
            yesPictureBox.Image = Properties.Resources.yes;
            noClicked = true;
            yesClicked = false;
            nextButton6.Visible = true;
            cardioClicked = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!yesClicked)
            {
                yesPictureBox.Image = Properties.Resources.yesHovered;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!yesClicked)
            {
                yesPictureBox.Image = Properties.Resources.yes;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (!noClicked)
            {
                noPictureBox.Image = Properties.Resources.noHovered;
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (!noClicked)
            {
                noPictureBox.Image = Properties.Resources.no;
            }

        }

        private void nextButton6_Click(object sender, EventArgs e)
        {
            lowerBodyPanel.Visible = false;
            upperBodyPanel.Visible = false;
            cardioPanel.Visible = false;
            workoutTypePanel.Visible = true;
        }

        private void prePicture_Click(object sender, EventArgs e)
        {
            prePicture.Image = Properties.Resources.prePressed;
            createPicture.Image = Properties.Resources.create;
            preClicked = true;
            createClicked = false;
            nextButt7.Visible = true;
        }

        private void createPicture_Click(object sender, EventArgs e)
        {
            prePicture.Image = Properties.Resources.pre;
            createPicture.Image = Properties.Resources.createSelected;
            preClicked = false;
            createClicked = true;
            nextButt7.Visible = true;
        }

        private void prePicture_MouseEnter(object sender, EventArgs e)
        {
            if (!preClicked)
            {
                prePicture.Image = Properties.Resources.preHovered;
            }
        }

        private void prePicture_MouseLeave(object sender, EventArgs e)
        {
            if (!preClicked)
            {
                prePicture.Image = Properties.Resources.pre;
            }
        }

        private void createPicture_MouseEnter(object sender, EventArgs e)
        {
            if (!createClicked)
            {
                createPicture.Image = Properties.Resources.createHovered;
            }
        }

        private void createPicture_MouseLeave(object sender, EventArgs e)
        {
            if (!createClicked)
            {
                createPicture.Image = Properties.Resources.create;
            }
        }

        private void nextButton7_Click(object sender, EventArgs e)
        {
        }

        private void nextButt7_Click(object sender, EventArgs e)
        {
            if (preClicked)
            {
                preGenPanel.Visible = true;
            }
            if (createClicked)
            {
                createPanel.Visible = true;
            }
        }
    }
}
