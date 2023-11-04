using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;

namespace FitVitality
{
    public partial class Welcome : KryptonForm
    {
        List<Panel> listPanels = new List<Panel>();
        private bool mouseDown;
        private Point lastLocation;
        int page = 0;
        private bool female_Clicked = false;
        private bool male_Clicked = false;
        private bool cut_Clicked = false;
        private bool maintain_Clicked = false;
        private bool bulk_Clicked = false;
        private string dbName;
        private string dbAge;
        private string dbGender;
        private string dbWeight;
        private string dbHeight;
        private string dbGoal;
        public string userID;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            userID = cfg.Read("UserID", "SETTINGS");
            buttonPrevious.Visible = false;
            buttonNext.Visible = false;
            namePanel.Visible = false;
            ageGender_Panel.Visible = false;
            weightHeight_Panel.Visible = false;
            goalPanel.Visible = false;
            listPanels.Add(namePanel);
            listPanels.Add(ageGender_Panel);
            listPanels.Add(weightHeight_Panel);
            listPanels.Add(goalPanel);
            listPanels[page].BringToFront();
            welcomeLabelTimer.Enabled = true;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMin_MouseEnter(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.Silver;
        }

        private void buttonMin_MouseLeave(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.FromArgb(36, 41, 46);
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.IndianRed;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(36, 41, 46);
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Welcome_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity += 0.00004;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            dbName = textBox_Name.Text.ToString();
            helloLabel.Text = "Hello, " + dbName + "! Thank you for choosing FitVitality!";
            if (page > 0)
            {
                page--;
                listPanels[page].BringToFront();
                buttonNext.Visible = true;
            }
            else if (page < listPanels.Count - 1)
            {
                buttonPrevious.Visible = true;
            }
            if (page == 0)
            {
                buttonPrevious.Visible = false;
                currentPage.Image = Properties.Resources.firstPage;
            }
            if (page == 1)
            {
                currentPage.Image = Properties.Resources.secondPage;
            }
            if (page == 2)
            {
                currentPage.Image = Properties.Resources.thirdPage;
            }
            if (page == 3)
            {
                currentPage.Image = Properties.Resources.fourthPage;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dbName = textBox_Name.Text.ToString();
            helloLabel.Text = "Hello, " + dbName + "! Thank you for choosing FitVitality!";
            if (page < listPanels.Count - 1)
            {
                page++;
                listPanels[page].BringToFront();
                buttonPrevious.Visible = true;
            }
            else if (page > 0)
            {
                buttonNext.Visible = true;
            }
            if (page == listPanels.Count - 1)
            {
                buttonNext.Visible = false;
            }
            if (page == 1 && timerLabel3.Visible == false)
            {
                timerAge1.Enabled = true;
            }
            if (page == 2 && timerLabel2.Visible == false)
            {
                timerWeight1.Enabled = true;
            }
            if (page == 3 && timerLabel.Visible == false)
            {
                timerGoal1.Enabled = true;
            }
            if (page == 0)
            {
                currentPage.Image = Properties.Resources.firstPage;
            }
            if (page == 1)
            {
                currentPage.Image = Properties.Resources.secondPage;
            }
            if (page == 2)
            {
                currentPage.Image = Properties.Resources.thirdPage;
            }
            if (page == 3)
            {
                currentPage.Image = Properties.Resources.fourthPage;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelWelcome.Width <= 609)
            {
                panelWelcome.Width += 6;
            }
            if (panelWelcome.Width >= 609)
            {
                welcomeLabelTimer.Enabled = false;
                Thread.Sleep(400);
                timerName1.Enabled = true;
                panelWelcome.Visible = false;
                namePanel.Visible = true;
                ageGender_Panel.Visible = true;
                weightHeight_Panel.Visible = true;
                goalPanel.Visible = true;
                currentPage.Image = Properties.Resources.firstPage;
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
            return true;
        }
        private bool validAge(string age)
        {
            foreach(char c in age)
            {
                if(!char.IsNumber(c))
                {
                    return false;
                }
            }
            if(int.Parse(age) < 13 || int.Parse(age) > 120)
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

        private void done_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var cfg = new Config("FitVitality.ini");
            dbName = textBox_Name.Text.ToString();
            dbAge = textBox_Age.Text;
            if (male_Clicked)
            {
                dbGender = "Male";
            }
            else
            {
                dbGender = "Female";
            }
            dbWeight = textBox_Weight.Text;
            dbHeight = textBox_Height.Text;
            if (bulk_Clicked)
            {
                dbGoal = "Bulk";
            }
            else if (cut_Clicked)
            {
                dbGoal = "Cut";
            }
            else
            {
                dbGoal = "Maintain";
            }
            if (validName(dbName) && validAge(dbAge) && validWeight(dbWeight) && validHeight(dbHeight) && dbGender != "" && dbGoal != "")
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
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
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@Name", dbName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", dbGender);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@Height", height);
                        command.Parameters.AddWithValue("@Goal", dbGoal);
                        command.ExecuteNonQuery();
                        Form1 main = new Form1();
                        for (double i = this.Opacity; i >= 0; i = i - 0.00004)
                        {
                            this.Opacity = i;
                        }
                        Thread.Sleep(500);
                        this.Hide();
                        main.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("gg");
            }
        }

        private void timername1_Tick(object sender, EventArgs e)
        {
            if (namePanel1.Width <= 482)
            {
                namePanel1.Width += 6;
            }
            if (namePanel1.Width >= 482)
            {
                timerName1.Enabled = false;
                timerName2.Enabled = true;
            }
        }

        private void timerName_Tick(object sender, EventArgs e)
        {
            if (namePanel2.Width <= 142)
            {
                namePanel2.Width += 2;
            }
            if (namePanel2.Width >= 142)
            {
                timerName2.Enabled = false;
                textBox_Name.Visible = true;
                timerName3.Enabled = true;
            }
        }

        private void buttonPrevious_MouseEnter(object sender, EventArgs e)
        {
            buttonPrevious.Image = Properties.Resources.previoustracked;
        }

        private void buttonPrevious_MouseLeave(object sender, EventArgs e)
        {
            buttonPrevious.Image = Properties.Resources.triangleprevious;
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.Image = Properties.Resources.nexttracked;
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.Image = Properties.Resources.trianglenext;
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "")
            {
                buttonNext.Visible = true;
            }
            else
            {
                buttonNext.Visible = false;
            }
        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void male_Click(object sender, EventArgs e)
        {
            maleButton.Image = Properties.Resources.malepressed1;
            femaleButton.Image = Properties.Resources.female1;
            male_Clicked = true;
            female_Clicked = false;
        }

        private void female_Click(object sender, EventArgs e)
        {
            femaleButton.Image = Properties.Resources.femalepressed1;
            maleButton.Image = Properties.Resources.male1;
            female_Clicked = true;
            male_Clicked = false;
        }

        private void male_MouseEnter(object sender, EventArgs e)
        {
            if (!male_Clicked)
            {
                maleButton.Image = Properties.Resources.maletracked1;
            }
        }

        private void female_MouseEnter(object sender, EventArgs e)
        {
            if (!female_Clicked)
            {
                femaleButton.Image = Properties.Resources.femaletracked1;
            }
        }

        private void male_MouseLeave(object sender, EventArgs e)
        {
            if (!male_Clicked)
            {
                maleButton.Image = Properties.Resources.male1;
            }
        }

        private void female_MouseLeave(object sender, EventArgs e)
        {
            if (!female_Clicked)
            {
                femaleButton.Image = Properties.Resources.female1;
            }
        }

        private void timerage1_Tick(object sender, EventArgs e)
        {
            if (helloPanel.Width <= 378)
            {
                helloPanel.Width += 6;
            }
            if (helloPanel.Width >= 378)
            {
                timerAge1.Enabled = false;
                timerAge2.Enabled = true;
            }
        }

        private void timerage2_Tick(object sender, EventArgs e)
        {
            if (ageGenderPanel1.Width <= 427)
            {
                ageGenderPanel1.Width += 6;
            }
            if (ageGenderPanel1.Width >= 427)
            {
                timerAge2.Enabled = false;
                timerAge3.Enabled = true;
            }
        }

        private void timerage3_Tick(object sender, EventArgs e)
        {
            if (ageGenderPanel2.Width <= 121)
            {
                ageGenderPanel2.Width += 6;
            }
            if (ageGenderPanel2.Width >= 121)
            {
                timerAge3.Enabled = false;
                textBox_Age.Visible = true;
                timerAge4.Enabled = true;
            }
        }

        private void timerage4_Tick(object sender, EventArgs e)
        {
            if (ageGenderPanel3.Width <= 147)
            {
                ageGenderPanel3.Width += 6;
            }
            if (ageGenderPanel3.Width >= 147)
            {
                timerAge4.Enabled = false;
                timerAge5.Enabled = true;
            }
        }

        private void timerWeight1_Tick(object sender, EventArgs e)
        {
            if (weightHeightPanel1.Width <= 320)
            {
                weightHeightPanel1.Width += 6;
            }
            if (weightHeightPanel1.Width >= 320)
            {
                timerWeight1.Enabled = false;
                timerWeight2.Enabled = true;
            }
        }

        private void timerWeight2_Tick(object sender, EventArgs e)
        {
            if (weightHeightPanel2.Width <= 420)
            {
                weightHeightPanel2.Width += 6;
            }
            if (weightHeightPanel2.Width >= 420)
            {
                timerWeight2.Enabled = false;
                timerWeight3.Enabled = true;
            }
        }

        private void timerWeight3_Tick(object sender, EventArgs e)
        {
            if (weightHeightPanel3.Width <= 180)
            {
                weightHeightPanel3.Width += 6;
            }
            if (weightHeightPanel3.Width >= 180)
            {
                timerWeight3.Enabled = false;
                textBox_Weight.Visible = true;
                timerWeight4.Enabled = true;
            }
        }

        private void timerWeight4_Tick(object sender, EventArgs e)
        {
            if (weightHeightPanel4.Width <= 130)
            {
                weightHeightPanel4.Width += 6;
            }
            if (weightHeightPanel4.Width >= 130)
            {
                timerWeight4.Enabled = false;
                textBox_Height.Visible = true;
                timerWeight5.Enabled = true;
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbHeight_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            buttonBulk.Image = Properties.Resources.gainPressed;
            buttonCut.Image = Properties.Resources.loseNormal;
            buttonMaintain.Image = Properties.Resources.maintainNormal;
            bulk_Clicked = true;
            maintain_Clicked = false;
            cut_Clicked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buttonBulk.Image = Properties.Resources.gainNormal;
            buttonCut.Image = Properties.Resources.losePressed;
            buttonMaintain.Image = Properties.Resources.maintainNormal;
            bulk_Clicked = false;
            maintain_Clicked = false;
            cut_Clicked = true;
        }

        private void buttonMaintain_Click(object sender, EventArgs e)
        {
            buttonBulk.Image = Properties.Resources.gainNormal;
            buttonCut.Image = Properties.Resources.loseNormal;
            buttonMaintain.Image = Properties.Resources.maintainPressed;
            bulk_Clicked = false;
            maintain_Clicked = true;
            cut_Clicked = false;
        }

        private void buttonCut_MouseEnter(object sender, EventArgs e)
        {
            if (!cut_Clicked)
            {
                buttonCut.Image = Properties.Resources.loseTracked;
            }
        }

        private void buttonCut_MouseLeave(object sender, EventArgs e)
        {
            if (!cut_Clicked)
            {
                buttonCut.Image = Properties.Resources.loseNormal;
            }
        }

        private void buttonMaintain_MouseEnter(object sender, EventArgs e)
        {
            if (!maintain_Clicked)
            {
                buttonMaintain.Image = Properties.Resources.maintainTracked;
            }
        }

        private void buttonMaintain_MouseLeave(object sender, EventArgs e)
        {
            if (!maintain_Clicked)
            {
                buttonMaintain.Image = Properties.Resources.maintainNormal;
            }
        }

        private void buttonBulk_MouseEnter(object sender, EventArgs e)
        {
            if (!bulk_Clicked)
            {
                buttonBulk.Image = Properties.Resources.gainTracked;
            }
        }

        private void buttonBulk_MouseLeave(object sender, EventArgs e)
        {
            if (!bulk_Clicked)
            {
                buttonBulk.Image = Properties.Resources.gainNormal;
            }
        }

        private void timerGoal1_Tick(object sender, EventArgs e)
        {
            if (goalPanel1.Width <= 278)
            {
                goalPanel1.Width += 6;
            }
            if (goalPanel1.Width >= 278)
            {
                timerGoal1.Enabled = false;
                timerGoal2.Enabled = true;
            }
        }

        private void timerGoal2_Tick(object sender, EventArgs e)
        {
            if (goalsPanel.Height <= 133)
            {
                goalsPanel.Height += 6;
            }
            if (goalsPanel.Height >= 133)
            {
                timerGoal2.Enabled = false;
                timerLabel.Visible = true;
                doneButton.Visible = true;
            }
        }

        private void timerWeight5_Tick(object sender, EventArgs e)
        {
            if (info2_Panel.Width <= 179)
            {
                info2_Panel.Width += 6;
            }
            if (info2_Panel.Width >= 179)
            {
                timerWeight5.Enabled = false;
                timerWeight6.Enabled = true;
            }
        }

        private void timerWeight6_Tick(object sender, EventArgs e)
        {
            if (info1_Panel.Width <= 309)
            {
                info1_Panel.Width += 6;
            }
            if (info1_Panel.Width >= 309)
            {
                timerWeight6.Enabled = false;
                timerWeight7.Enabled = true;
            }
        }

        private void timerWeight7_Tick(object sender, EventArgs e)
        {
            if (info3_Panel.Width <= 309)
            {
                info3_Panel.Width += 6;
            }
            if (info3_Panel.Width >= 309)
            {
                timerWeight7.Enabled = false;
                timerLabel2.Visible = true;
            }
        }

        private void timerAge5_Tick(object sender, EventArgs e)
        {
            if (genderPanel.Height <= 40)
            {
                genderPanel.Height += 5;
            }
            if (genderPanel.Height >= 40)
            {
                timerAge5.Enabled = false;
                timerAge6.Enabled = true;
            }
        }

        private void timerAge6_Tick(object sender, EventArgs e)
        {
            if (info1_ageGender_Panel.Width <= 309)
            {
                info1_ageGender_Panel.Width += 5;
            }
            if (info1_ageGender_Panel.Width >= 309)
            {
                timerAge6.Enabled = false;
                timerAge7.Enabled = true;
            }
        }

        private void timerAge7_Tick(object sender, EventArgs e)
        {
            if (info2_ageGender_Panel.Width <= 309)
            {
                info2_ageGender_Panel.Width += 5;
            }
            if (info2_ageGender_Panel.Width >= 309)
            {
                timerAge7.Enabled = false;
                timerLabel3.Visible = true;
            }
        }

        private void timerName3_Tick(object sender, EventArgs e)
        {
            if (panel_nameUsage.Width <= 482)
            {
                panel_nameUsage.Width += 8;
            }
            if (panel_nameUsage.Width >= 482)
            {
                timerName3.Enabled = false;
            }
        }
    }
}
