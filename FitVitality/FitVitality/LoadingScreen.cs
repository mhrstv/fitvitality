using Krypton.Toolkit;
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
            if (this.Opacity >= 1)
            {
                loadTimer.Enabled = true;
                panel3.Width += 10;
                if (panel3.Width >= panel2.Width)
                {
                    loadTimer.Stop();
                    Thread.Sleep(500);
                    panel3.Visible = false;
                    panel2.Visible = false;
                    Thread.Sleep(500);
                    Form1 form = new Form1();
                    for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                    {
                        this.Opacity = i;
                    }
                    Thread.Sleep(500);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void loadingScreen_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void loadingScreen_Activated(object sender, EventArgs e)
        {

        }

        private void loadingScreen_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadingScreen_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity = this.Opacity + 0.00002;
            }
        }
    }
}
