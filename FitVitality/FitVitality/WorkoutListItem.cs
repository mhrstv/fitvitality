using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitVitality
{
    public partial class WorkoutListItem : UserControl
    {
        public event EventHandler ButtonClicked;
        public WorkoutListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _workoutNumber;
        private string _workoutExercises;

        private void WorkoutListItem_Load(object sender, EventArgs e)
        {
            var cfg = new Config("FitVitality.ini");
            if (cfg.Read("Language", "SETTINGS") == "en")
            {
                workoutNumLabel.Text = "Workout [Number]";
                selectButton.Text = "Preview";
            }
            if (cfg.Read("Language", "SETTINGS") == "bg")
            {
                workoutNumLabel.Text = "Тренировка [Number]";
                selectButton.Text = "Преглед";
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void workoutNumLabel_Click(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public string WorkoutNumber
        {
            get { return _workoutNumber; }
            set { _workoutNumber = value; workoutNumLabel.Text = value; }
        }
        [Category("Custom Props")]
        public string WorkoutExercises
        {
            get { return _workoutExercises; }
            set { _workoutExercises = value; labelExercises.Text = value; }
        }

        #endregion
    }
}
