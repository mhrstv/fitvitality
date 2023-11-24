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
    public partial class Calculators : Form
    {
        public string _userID;
        public Calculators(string userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void bmi_openButton_Click(object sender, EventArgs e)
        {
            double x = bmi_panel.Location.X;
            double y = bmi_panel.Location.Y;
            bmr_panel.Visible = false;
            bodyfat_panel.Visible = false;
            calorie_panel.Visible = false;
            macro_panel.Visible = false;
            idealweight_panel.Visible = false;
            for (; x < 129 && y > 55; x += 2.5, y -= 1.5)
            {
                bmi_panel.Location = new Point((int)x, (int)y);
            }
            bmi_panel.Height = 259;
            bmi_panel.Width = 432;
        }
    }
}
