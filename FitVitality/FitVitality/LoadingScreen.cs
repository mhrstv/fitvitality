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
using Krypton.Toolkit;

namespace FitVitality
{
    public partial class loadingScreen : KryptonForm
    {
        public loadingScreen()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                loadTimer.Enabled = true;
                panelLoad.Width += 10;
                percentages.Text = ((int)(panelLoad.Width / 2.41)).ToString() + "%";
                if (panelLoad.Width >= panelLoad2.Width)
                {
                    loadTimer.Stop();
                    Thread.Sleep(500);
                    percentages.Visible = false;
                    panelLoad.Visible = false;
                    panelLoad2.Visible = false;
                    Thread.Sleep(500);

                    Login welcomeScreen = new Login();
                    for (double i = this.Opacity; i >= 0; i = i - 0.00002)
                    {
                        this.Opacity = i;
                    }
                    Thread.Sleep(500);
                    welcomeScreen.Show();
                    this.Hide();
                }
            }
        }

        private void loadingScreen_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(0, 0, 0);
            this.ShowInTaskbar = false;
            this.ControlBox = false;
        }

        private void loadingScreen_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            while (this.Opacity != 1)
            {
                this.Opacity += 0.00004;
            }
        }

        private void loadingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
