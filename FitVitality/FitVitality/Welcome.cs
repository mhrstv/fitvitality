﻿using System;
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
        int index = 0;

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
            weight.Visible = false;
            goal.Visible = false;
            activity.Visible = false;
            listPanels.Add(name);
            listPanels.Add(age);
            listPanels.Add(weight);
            listPanels.Add(goal);
            listPanels.Add(activity);
            listPanels[index].BringToFront();
            welcomelabeltimer.Enabled = true;
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
                index--;
                listPanels[index].BringToFront();
                buttonNext.Visible = true;
            }
            else if (index < listPanels.Count - 1)
            {
                buttonPrevious.Visible = false;
                done.Visible = false;
            }
            if (index == 0)
            {
                buttonPrevious.Visible = false;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < listPanels.Count - 1)
            {
                index++;
                listPanels[index].BringToFront();
                buttonPrevious.Visible = true;
            }
            else if (index > 0)
            {
                buttonNext.Visible = false;
            }
            if (index == listPanels.Count - 1)
            {
                buttonNext.Visible = false;
                done.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelWelcome.Width <= 609)
            {
                panelWelcome.Width += 6;
            }
            if (panelWelcome.Width >= 609)
            {
                welcomelabeltimer.Enabled = false;
                Thread.Sleep(400);
                timername1.Enabled = true;
                panelWelcome.Visible = false;
                name.Visible = true;
                age.Visible = true;
                weight.Visible = true;
                goal.Visible = true;
                activity.Visible = true;
                buttonNext.Visible = true;
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            for (double i = this.Opacity; i >= 0; i = i - 0.00004)
            {
                this.Opacity = i;
            }
            Thread.Sleep(500);
            this.Hide();
            main.Show();
        }

        private void timername1_Tick(object sender, EventArgs e)
        {
            if (nameLabel1.Width <= 482)
            {
                nameLabel1.Width += 6;
            }
            if (nameLabel1.Width >= 482)
            {
                timername1.Enabled = false;
                timerName.Enabled = true;
            }
        }

        private void timerName_Tick(object sender, EventArgs e)
        {
            if (nameLabel2.Width <= 142)
            {
                nameLabel2.Width += 2;
            }
            if (nameLabel2.Width >= 142)
            {
                timerName.Enabled = false;
                kryptonTextBox1.Visible = true;
            }
        }

        private void buttonPrevious_MouseEnter(object sender, EventArgs e)
        {
            buttonPrevious.Image = Properties.Resources.previoustracked;
        }

        private void buttonPrevious_MouseLeave(object sender, EventArgs e)
        {
            buttonPrevious.Image = Properties.Resources.triangleprevious;
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.Image = Properties.Resources.nexttracked;
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.Image = Properties.Resources.trianglenext;
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
