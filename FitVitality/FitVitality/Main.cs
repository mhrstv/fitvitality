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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.name == "" && Properties.Settings.Default.age == 0 && Properties.Settings.Default.heigth == 0 && Properties.Settings.Default.weigth == 0)
            {

            }
        }
    }
}
