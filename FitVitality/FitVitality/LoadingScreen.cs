using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitVitality
{
    public partial class startLoadScreen : Form
    {
        public startLoadScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void startLoadScreen_Load(object sender, EventArgs e)
        {

        }

        private void kryptonProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_3(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_4(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            kryptonProgressBar1.Increment(6);
            if (kryptonProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
    }
}
