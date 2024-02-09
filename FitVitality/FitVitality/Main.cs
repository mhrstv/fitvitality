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
        bool dashboard_Opened = false;
        bool calculators_Opened = false;
        bool workouts_Opened = false;
        bool nutrition_Opened = false;
        bool settings_Opened = false;

        public string _userID;

        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

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
            if (dashboard_Opened == false)
            {
                loadForm(new home(_userID));
                dashboard_Opened = true;
                calculators_Opened = false;
                workouts_Opened = false;
                nutrition_Opened = false;
                settings_Opened = false;
            }
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UserData WHERE UserID = @userID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", _userID);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        var cfg = new Config("FitVitality.ini");
                        if (cfg.Read("Language", "SETTINGS") == "en")
                        {
                            if (reader.Read())
                            {
                                loggedInAsLabel.Text = "Logged in as " + reader["Username"].ToString();
                            }
                        }
                        if (cfg.Read("Language", "SETTINGS") == "bg")
                        {
                            if (reader.Read())
                            {
                                loggedInAsLabel.Text = "Влязъл като " + reader["Username"].ToString();
                            }
                        }
                    }
                }
            }
        }

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
        private void kryptonButton2_Click_3(object sender, EventArgs e)
        {
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
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
            settingsButton.BackColor = Color.Silver;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.White;
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

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

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
    }
}
