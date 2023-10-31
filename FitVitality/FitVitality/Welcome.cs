using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace FitVitality
{
    public partial class Welcome : KryptonForm
    {
        List<Panel> listPanels = new List<Panel>();
        private bool mouseDown;
        private Point lastLocation;
        int index;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            buttonPrevious.Visible = false;
            buttonNext.Visible = false;
            name.Visible = false;
            age.Visible = false;
            gender.Visible = false;
            weight.Visible = false;
            height.Visible = false;
            goal.Visible = false;
            activity.Visible = false;
            listPanels.Add(name);
            listPanels.Add(age);
            listPanels.Add(gender);
            listPanels.Add(weight);
            listPanels.Add(height);
            listPanels.Add(goal);
            listPanels.Add(activity);
            listPanels[0].BringToFront();
            timer1.Enabled = true;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMin_MouseEnter(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.Silver;
        }

        private void buttonMin_MouseLeave(object sender, EventArgs e)
        {
            buttonMin.BackColor = Color.FromArgb(36, 41, 46);
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.IndianRed;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(36, 41, 46);
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Welcome_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity += 0.00004;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanels[--index].BringToFront();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < listPanels.Count - 1)
            {
                listPanels[++index].BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width <= 609)
            {
                panel1.Width += 6;
            }
            if (panel1.Width >= 609)
            {
                timer1.Enabled = false;

            }
        }
    }
}
