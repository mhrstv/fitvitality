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
    public partial class FoodItem : UserControl
    {
        public FoodItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _foodName;
        private int _foodCalories;
        private int _foodProtein;
        private int _foodCarbs;
        private int _foodFat;
        private Image _foodImage;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void removeFoodItem_MouseEnter(object sender, EventArgs e)
        {
            removeFoodItem.BackColor = Color.FromArgb(182, 105, 105);
        }

        private void removeFoodItem_MouseLeave(object sender, EventArgs e)
        {
            removeFoodItem.BackColor = Color.Transparent;
        }

        [Category("Custom Props")]
        public string FoodName
        {
            get { return _foodName; }
            set { _foodName = value; foodNameLabel.Text = value; }
        }
        [Category("Custom Props")]
        public int FoodCalories
        {
            get { return _foodCalories; }
            set { _foodCalories = value; caloriesLabel.Text = "kCal" + value.ToString(); }
        }
        [Category("Custom Props")]
        public int FoodProtein
        {
            get { return _foodProtein; }
            set { _foodProtein = value; pLabel.Text = "P:" + value.ToString(); }
        }
        [Category("Custom Props")]
        public int FoodCarbs
        {
            get { return _foodCarbs; }
            set { _foodCarbs = value; cLabel.Text = "C:" + value.ToString(); }
        }
        [Category("Custom Props")]
        public int FoodFat
        {
            get { return _foodFat; }
            set { _foodFat = value; fLabel.Text = "F:" + value.ToString(); }
        }
        [Category("Custom Props")]
        public Image FoodImage
        {
            get { return foodImage.Image; }
            set { foodImage.Image = value; }
        }
        #endregion
    }
}
