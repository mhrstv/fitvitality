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
        private Random random;
        public Workouts(string userID)
        {
            InitializeComponent();
            _userID = userID;
            colorTimer.Interval = 100;
            colorTimer.Tick += colorTimer_Tick;

            random = new Random();
        }

        private void Workouts_Load(object sender, EventArgs e)
        {
            colorTimer.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorTimer.Stop();
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
