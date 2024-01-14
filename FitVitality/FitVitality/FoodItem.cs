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
        public event EventHandler TextBoxChanged;
        #region Properties
        private string _foodName;
        private double _foodCalories;
        private double _foodProtein;
        private double _foodCarbs;
        private double _foodFat;
        private double _foodGrams;
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

        private void textBoxGrams_TextChanged()
        {
            if (textBoxGrams.Text != "")
            {
                TextBoxChanged?.Invoke(this, EventArgs.Empty);
                FoodCalories = Math.Round((FoodCalories / FoodGrams) * Convert.ToDouble(textBoxGrams.Text), 2);
                caloriesLabel.Text = "kCal:" + FoodCalories.ToString();
                FoodProtein = Math.Round((FoodProtein / FoodGrams) * Convert.ToDouble(textBoxGrams.Text), 2);
                pLabel.Text = "P:" + FoodProtein.ToString() + "g";
                FoodCarbs = Math.Round((FoodCarbs / FoodGrams) * Convert.ToDouble(textBoxGrams.Text), 2);
                cLabel.Text = "C:" + FoodCarbs.ToString() + "g";
                FoodFat = Math.Round((FoodFat / FoodGrams) * Convert.ToDouble(textBoxGrams.Text), 2);
                fLabel.Text = "F:" + FoodFat.ToString() + "g";
            }
        }

        private void textBoxGrams_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                textBoxGrams_TextChanged();
            }
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
        public double FoodGrams
        {
            get { return _foodGrams; }
            set { _foodGrams = value; }
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
