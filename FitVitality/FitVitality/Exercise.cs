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
    public partial class Exercise : UserControl
    {
        public event EventHandler ButtonClicked;

        public Exercise()
        {
            InitializeComponent();
        }

        private void removeLabel_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Exercise_Load(object sender, EventArgs e)
        {

        }
        #region
        private string exerciseName;
        private string exerciseListName;
        [Category("Properties")]
        public string ExerciseName
        {
            get { return exerciseName; }
            set { exerciseName = value; exerciseLabel.Text = value; }
        }
        public string ExerciseListName
        {
            get { return exerciseListName; }
            set { exerciseListName = value; }
        }
        #endregion
    }
}
