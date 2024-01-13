using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitVitality
{
    public partial class FoodItem : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public string _userID;
        public FoodItem()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClicked;
        #region Properties
        private string _foodName;
        private double _foodCalories;
        private double _foodProtein;
        private double _foodCarbs;
        private double _foodFat;
        private string _foodImage;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void removeFoodItem_MouseEnter(object sender, EventArgs e)
        {
            removeFoodItem.BackColor = Color.FromArgb(182, 105, 105);
        }

        private void removeFoodItem_MouseLeave(object sender, EventArgs e)
        {
            removeFoodItem.BackColor = Color.Transparent;
        }

        private void textBoxGrams_TextChanged(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public string FoodName
        {
            get { return _foodName; }
            set { _foodName = value; foodNameLabel.Text = value; }
        }
        [Category("Custom Props")]
        public double FoodCalories
        {
            get { return _foodCalories; }
            set { _foodCalories = value; caloriesLabel.Text = "kCal:" + value.ToString(); }
        }
        [Category("Custom Props")]
        public double FoodProtein
        {
            get { return _foodProtein; }
            set { _foodProtein = value; pLabel.Text = "P:" + value.ToString() + "g"; }
        }
        [Category("Custom Props")]
        public double FoodCarbs
        {
            get { return _foodCarbs; }
            set { _foodCarbs = value; cLabel.Text = "C:" + value.ToString() + "g"; }
        }
        [Category("Custom Props")]
        public double FoodFat
        {
            get { return _foodFat; }
            set { _foodFat = value; fLabel.Text = "F:" + value.ToString() + "g"; }
        }
        [Category("Custom Props")]
        public string FoodImage
        {
            get { return foodImage.ImageLocation; }
            set { foodImage.ImageLocation = value; _foodImage = value; }
        }
        #endregion
    }
}
