﻿using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class WorkoutsDashboard : Form
    {
        public string _userID;
        public WorkoutsDashboard(string userID)
        {
            InitializeComponent();
            _userID = userID;
        }
    }
}