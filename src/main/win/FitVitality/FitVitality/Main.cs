﻿using System;
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

        enum Modules
        {
            Dashboard,
            Calculators,
            Workouts,
            Nutrition,
            Settings
        }
        Modules module;

        public string _userID;

        const string connectionString = @"Server=tcp: mssql-163547-0.cloudclusters.net, 11009;Initial Catalog=FitVitality;User ID=Member;Password=Userpass123!;Connection Timeout=30;TrustServerCertificate=True";
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
            loadForm(new home(_userID));
            module = Modules.Dashboard;

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
            if (module != Modules.Workouts)
            {
                loadForm(new Workouts(_userID));
                module = Modules.Workouts;
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
            if (module != Modules.Dashboard)
            {
                loadForm(new home(_userID));
                module = Modules.Dashboard;
            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (module != Modules.Settings)
            {
                loadForm(new Settings(_userID));
                module = Modules.Settings;
            }
        }

        private void buttonCalculators_Click(object sender, EventArgs e)
        {
            if (module != Modules.Calculators)
            {
                loadForm(new Calculators(_userID));
                module = Modules.Calculators;
            }
        }

        private void kryptonButton1_Click_2(object sender, EventArgs e)
        {
            if (module != Modules.Nutrition)
            {
                loadForm(new Diet(_userID));
                module = Modules.Nutrition;
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
    }
}