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
    public partial class SearchFoodItem : UserControl
    {
        public SearchFoodItem()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClicked;
        #region
        private string _foodName;
        private string _foodNameOrigin;
        private double _foodCalories;
        private double _foodProtein;
        private double _foodCarbs;
        private double _foodFat;
        private double _foodGrams;
        private string _foodImage;

        private void SearchFoodItem_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SearchFoodItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void SearchFoodItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(160, 160, 160);
        }

        private void SearchFoodItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void SearchFoodItem_Load(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public string FoodName
        {
            get { return _foodName; }
            set { _foodName = value; foodName.Text = value; }
        }
        [Category("Custom Props")]
        public string FoodNameOrigin
        {
            get { return _foodNameOrigin; }
            set { _foodNameOrigin = value; }
        }
        [Category("Custom Props")]
        public double FoodCalories
        {
            get { return _foodCalories; }
            set { _foodCalories = value; }
        }
        [Category("Custom Props")]
        public double FoodProtein
        {
            get { return _foodProtein; }
            set { _foodProtein = value; }
        }
        [Category("Custom Props")]
        public double FoodCarbs
        {
            get { return _foodCarbs; }
            set { _foodCarbs = value; }
        }
        [Category("Custom Props")]
        public double FoodFat
        {
            get { return _foodFat; }
            set { _foodFat = value; }
        }
        [Category("Custom Props")]
        public double FoodGrams
        {
            get { return _foodGrams; }
            set { _foodGrams = 100; }
        }

        [Category("Custom Props")]
        public string FoodImage
        {
            get { return _foodImage; }
            set { _foodImage = value; foodImage.ImageLocation = value; }
        }

        #endregion
    }
}
