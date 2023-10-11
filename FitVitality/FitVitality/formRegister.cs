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
    public partial class formRegister : Form
    {
        Form flog = new formLogin();
        public formRegister()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            flog.Show();
            
        }
    }
}
