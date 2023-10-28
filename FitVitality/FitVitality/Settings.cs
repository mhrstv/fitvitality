using Krypton.Toolkit;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitVitality
{
    public partial class Settings : Form
    {
        public string userID;
        public Settings()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
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
                        if (reader.Read())
                        {
                            MessageBox.Show("Account deleted successfully!");
                            Login login = new Login();
                            Form.ActiveForm.Close();
                            login.Show();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            userID = cfg.Read("UserID", "SETTINGS");
            
        }
    }
}
