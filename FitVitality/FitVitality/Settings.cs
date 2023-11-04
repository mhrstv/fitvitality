using Krypton.Toolkit;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.ApplicationServices;

namespace FitVitality
{
    public partial class Settings : Form
    {
        public string userID;
        private PictureBox pb;
        public Settings()
        {
            InitializeComponent();

            pb = new PictureBox();
            panel1.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel1.Height = 174;
            panel1.Width = 341;
            deleteAccButton.Visible = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            userID = cfg.Read("UserID", "SETTINGS");

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConfirm.Text == "CONFIRM")
            {
                confirmButton.Enabled = true;
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality;Persist Security Info=False;User ID=fitvitality;Password=adminskaparola123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM UserData WHERE UserID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        panel1.Visible = false;
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
                connection.Close();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            deleteAccButton.Visible = true;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.DimGray;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(74, 74, 74);
        }
    }
}
