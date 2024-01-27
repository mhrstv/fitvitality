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
    public partial class ExerciseListItem : UserControl
    {
        public event EventHandler ButtonClicked;

        public ExerciseListItem()
        {
            InitializeComponent();
        }

        private void ExerciseListItem_Load(object sender, EventArgs e)
        {

        }

        private void addLabel_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        #region
        private string exerciseName;
        private string exerciseListName;
        public string ExerciseName
        {
            get { return exerciseName; }
            set { exerciseName = value; }
        }
        [Category("Properties")]
        public string ExerciseListName
        {
            get { return exerciseListName; }
            set { exerciseListName = value; exerciseLabel.Text = value; }
        }
        #endregion
    }
}
