﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace FitVitality
{
    public partial class WorkoutListItem : UserControl
    {
        public WorkoutListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _workoutNumber;

        [Category("Custom Props")]
        public string WorkoutNumber
        {
            get { return _workoutNumber; }
            set { _workoutNumber = value; workoutNumLabel.Text = value; }
        }
        #endregion
    }
}
