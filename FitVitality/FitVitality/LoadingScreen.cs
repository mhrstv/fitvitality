﻿using Krypton.Toolkit;
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
using System.Threading;

namespace FitVitality
{
    public partial class loadingScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse// height of ellipse
        );
        public loadingScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float j = 39;
            timer1.Enabled = true;
            progressBar1.Increment(4);
            if (progressBar1.Value == 100)
            {
                Thread.Sleep(1000);
                for (int i = 213; i > 12; i--)
                {
                    
                }
                Thread.Sleep(150);
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void loadingScreen_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }
    }
}
