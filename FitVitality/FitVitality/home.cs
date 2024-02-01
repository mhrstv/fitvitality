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
    public partial class home : Form
    {
        private string name;
        private int age;
        private string gender;
        private string weight;
        private string height;
        private string goal;
        private string _userID;
        //private string connectionString = @"Server=tcp:fitvitality.database.windows.net,1433;Initial Catalog=FitVitality-AWS;Persist Security Info=False;User ID=Member;Password=useraccessPass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public home(string userID)
        {
            InitializeComponent();
            _userID = userID;
        }


        private void home_Load(object sender, EventArgs e)
        {
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
                            name = reader["Name"].ToString();
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Today FROM Workouts WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Today"].ToString() == "Completed")
                            {
                                workoutCompletedCheckBox.Checked = true;
                            }
                            else
                            {
                                workoutCompletedCheckBox.Checked = false;
                            }
                        }
                    }
                }
            }
            int currentCalories = 0;
            int caloriesGoal = 0;
            int currentProtein = 0;
            int proteinGoal = 0;
            int currentCarbs = 0;
            int carbsGoal = 0;
            int currentFats = 0;
            int fatsGoal = 0;
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
                            if (reader["CurrentCalories"].ToString() != "" && reader["CurrentProtein"].ToString() != "" && reader["CurrentCarbs"].ToString() != "" && reader["CurrentFats"].ToString() != ""
                                && reader["CaloriesGoal"].ToString() != "" && reader["ProteinGoal"].ToString() != "" && reader["CarbsGoal"].ToString() != "" && reader["FatsGoal"].ToString() != "")
                            {
                                currentCalories = int.Parse(reader["CurrentCalories"].ToString());
                                caloriesGoal = int.Parse(reader["CaloriesGoal"].ToString());
                                currentProtein = int.Parse(reader["CurrentProtein"].ToString());
                                proteinGoal = int.Parse(reader["ProteinGoal"].ToString());
                                currentCarbs = int.Parse(reader["CurrentCarbs"].ToString());
                                carbsGoal = int.Parse(reader["CarbsGoal"].ToString());
                                currentFats = int.Parse(reader["CurrentFats"].ToString());
                                fatsGoal = int.Parse(reader["FatsGoal"].ToString());
                            }
                        }
                    }
                }
            }
            calorieIntake.Text = $"{currentCalories}/{caloriesGoal}";
            protein.Text = $"{currentProtein}/{proteinGoal}";
            carbohydrates.Text = $"{currentCarbs}/{carbsGoal}";
            fat.Text = $"{currentFats}/{fatsGoal}";
            if (currentCalories > caloriesGoal)
            {
                calorieIntake.ForeColor = Color.Red;
            }
            if (currentProtein > proteinGoal)
            {
                protein.ForeColor = Color.Red;
            }
            if (currentCarbs > carbsGoal)
            {
                carbohydrates.ForeColor = Color.Red;
            }
            if (currentFats > fatsGoal)
            {
                fat.ForeColor = Color.Red;
            }


            string monday_workout = "Rest Day";
            string tuesday_workout = "Rest Day";
            string wednesday_workout = "Rest Day";
            string thursday_workout = "Rest Day";
            string friday_workout = "Rest Day";
            string saturday_workout = "Rest Day";
            string sunday_workout = "Rest Day";
            List<string> monday_List = new List<string>();
            List<string> tuesday_List = new List<string>();
            List<string> wednesday_List = new List<string>();
            List<string> thursday_List = new List<string>();
            List<string> friday_List = new List<string>();
            List<string> saturday_List = new List<string>();
            List<string> sunday_List = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "";
                query = "SELECT * FROM Workouts WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Monday"].ToString() != "Rest Day")
                            {
                                monday_List = reader["Monday"].ToString().Split(',').ToList();
                            }
                            if (reader["Tuesday"].ToString() != "Rest Day")
                            {
                                tuesday_List = reader["Tuesday"].ToString().Split(',').ToList();
                            }
                            if (reader["Wednesday"].ToString() != "Rest Day")
                            {
                                wednesday_List = reader["Wednesday"].ToString().Split(',').ToList();
                            }
                            if (reader["Thursday"].ToString() != "Rest Day")
                            {
                                thursday_List = reader["Thursday"].ToString().Split(',').ToList();
                            }
                            if (reader["Friday"].ToString() != "Rest Day")
                            {
                                friday_List = reader["Friday"].ToString().Split(',').ToList();
                            }
                            if (reader["Saturday"].ToString() != "Rest Day")
                            {
                                saturday_List = reader["Saturday"].ToString().Split(',').ToList();
                            }
                            if (reader["Sunday"].ToString() != "Rest Day")
                            {
                                sunday_List = reader["Sunday"].ToString().Split(',').ToList();
                            }
                        }
                    }
                }
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                workoutsLabel.Text = "Monday";
                for (int i = 0; i < monday_List.Count; i++)
                {
                    if (i < monday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + monday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + monday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                workoutsLabel.Text = "Tuesday";
                for (int i = 0; i < tuesday_List.Count; i++)
                {
                    if (i < tuesday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + tuesday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + tuesday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                workoutsLabel.Text = "Wednesday";
                for (int i = 0; i < wednesday_List.Count; i++)
                {
                    if (i < wednesday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + wednesday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + wednesday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                workoutsLabel.Text = "Thursday";
                for (int i = 0; i < thursday_List.Count; i++)
                {
                    if (i < thursday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + thursday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + thursday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                workoutsLabel.Text = "Friday";
                for (int i = 0; i < friday_List.Count; i++)
                {
                    if (i < friday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + friday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + friday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                workoutsLabel.Text = "Saturday";
                for (int i = 0; i < saturday_List.Count; i++)
                {
                    if (i < saturday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + saturday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + saturday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                workoutsLabel.Text = "Sunday";
                for (int i = 0; i < sunday_List.Count; i++)
                {
                    if (i < sunday_List.Count - 1) workoutsTextBox.Text += "3x12 - " + sunday_List[i] + "\n";
                    else workoutsTextBox.Text += "3x12 - " + sunday_List[i];
                }
                if (workoutsTextBox.Text == "")
                {
                    workoutsTextBox.Text = "None - Rest Day";
                    workoutsTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
        }

        private void home_Activated(object sender, EventArgs e)
        {
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
                            name = reader["Name"].ToString();
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bmi_label_Click(object sender, EventArgs e)
        {

        }

        private void rotationTimer_Tick_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        public void loadForm(object Form)
        {
            if (this.Parent.Controls.Count > 0)
            {
                this.Parent.Controls.RemoveAt(0);
            }
            Form x = Form as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(x);
            this.Parent.Tag = x;
            x.Show();
        }
        private void createNextButton_Click(object sender, EventArgs e)
        {

            loadForm(new Workouts(_userID));
        }

        private void workoutCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Workouts SET Today = @Today WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", _userID);
                    if (workoutCompletedCheckBox.Checked == true)
                    {
                        command.Parameters.AddWithValue("@Today", "Completed");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Today", "Not Completed");
                    }
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
