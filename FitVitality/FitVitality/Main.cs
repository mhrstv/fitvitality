using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;

namespace FitVitality
{
    public partial class Form1 : KryptonForm
    {
        string username;

        bool dashboard_Opened = false;
        bool calculators_Opened = false;
        bool workouts_Opened = false;
        bool nutrition_Opened = false;
        bool settings_Opened = false;

        public string _userID;

        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = @"Server=tcp: mssql-163547-0.cloudclusters.net, 10009;Initial Catalog=FitVitality;User ID=Member;Password=Userpass123!;Connection Timeout=30;TrustServerCertificate=True";
        //private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //Метод за зареждане на форми в главния прозорец
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form x = Form as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(x);
            this.mainPanel.Tag = x;
            x.Show();
        }
        private bool mouseDown;
        private Point lastLocation;
        public Form1(string userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Зареждане на началната форма
            if (dashboard_Opened == false)
            {
                loadForm(new home(_userID));
                dashboard_Opened = true;
                calculators_Opened = false;
                workouts_Opened = false;
                nutrition_Opened = false;
                settings_Opened = false;
            }

            //Извежда потребителското име в лейбъла
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UserData WHERE UserID = @userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var cfg = new Config("FitVitality.ini");
                        if (cfg.Read("Language", "SETTINGS") == "en")
                        {
                            if (reader.Read())
                            {
                                username = reader["Username"].ToString();
                                loggedInAsLabel.Text = "Logged in as: " + reader["Username"].ToString();
                                buttonHome.ToolTipValues.Heading = "Dashboard";
                                buttonCalculators.ToolTipValues.Heading = "Calculators";
                                buttonDashboard.ToolTipValues.Heading = "Workouts";
                                dietButton.ToolTipValues.Heading = "Diet";
                                settingsButton.ToolTipValues.Heading = "Settings";
                            }
                        }
                        if (cfg.Read("Language", "SETTINGS") == "bg")
                        {
                            if (reader.Read())
                            {
                                username = reader["Username"].ToString();
                                loggedInAsLabel.Text = "Влязъл като: " + reader["Username"].ToString();
                                buttonHome.ToolTipValues.Heading = "Табло";
                                buttonCalculators.ToolTipValues.Heading = "Калкулатори";
                                buttonDashboard.ToolTipValues.Heading = "Тренировки";
                                dietButton.ToolTipValues.Heading = "Диета";
                                settingsButton.ToolTipValues.Heading = "Настройки";
                            }
                        }
                    }
                }
            }
        }

        //Метод за плавно затваряне на формата
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity += 0.00004;
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (workouts_Opened == false)
            {
                loadForm(new Workouts(_userID));
                dashboard_Opened = false;
                calculators_Opened = false;
                workouts_Opened = true;
                nutrition_Opened = false;
                settings_Opened = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.IndianRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.White;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.Silver;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (dashboard_Opened == false)
            {
                loadForm(new home(_userID));
                dashboard_Opened = true;
                calculators_Opened = false;
                workouts_Opened = false;
                nutrition_Opened = false;
                settings_Opened = false;
            }

        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settings_Opened == false)
            {
                loadForm(new Settings(_userID));
                dashboard_Opened = false;
                calculators_Opened = false;
                workouts_Opened = false;
                nutrition_Opened = false;
                settings_Opened = true;
            }
        }

        private void buttonCalculators_Click(object sender, EventArgs e)
        {
            if (calculators_Opened == false)
            {
                loadForm(new Calculators(_userID));
                dashboard_Opened = false;
                calculators_Opened = true;
                workouts_Opened = false;
                nutrition_Opened = false;
                settings_Opened = false;
            }
        }

        private void kryptonButton1_Click_2(object sender, EventArgs e)
        {
            if (nutrition_Opened == false)
            {
                loadForm(new Diet(_userID));
                dashboard_Opened = false;
                calculators_Opened = false;
                workouts_Opened = false;
                nutrition_Opened = true;
                settings_Opened = false;
            }
        }

        //Метод за проверка за смяна на езика
        private void loggedAsTimer_Tick(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                loggedInAsLabel.Text = "Logged in as: " + username;
                buttonHome.ToolTipValues.Heading = "Dashboard";
                buttonCalculators.ToolTipValues.Heading = "Calculators";
                buttonDashboard.ToolTipValues.Heading = "Workouts";
                dietButton.ToolTipValues.Heading = "Diet";
                settingsButton.ToolTipValues.Heading = "Settings";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                loggedInAsLabel.Text = "Влязъл като: " + username;
                buttonHome.ToolTipValues.Heading = "Табло";
                buttonCalculators.ToolTipValues.Heading = "Калкулатори";
                buttonDashboard.ToolTipValues.Heading = "Тренировки";
                dietButton.ToolTipValues.Heading = "Диета";
                settingsButton.ToolTipValues.Heading = "Настройки";
            }
        }

        private void loggedInAsLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void loggedInAsLabel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void loggedInAsLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void logo2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void logo2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void logo2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void logo1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void logo1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void logo1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
