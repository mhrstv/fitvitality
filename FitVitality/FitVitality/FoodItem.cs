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
        public FoodItem()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClicked;
        public event EventHandler Add;
        public event EventHandler Remove;
        #region Properties
        private string _foodName;
        private double _foodCalories;
        private double _foodProtein;
        private double _foodCarbs;
        private double _foodFat;
        private double _foodGrams;
        private string _foodImage;
        private double _gramsDynamic;
        private double _caloriesDynamic;
        private double _proteinDynamic;
        private double _carbsDynamic;
        private double _fatDynamic;
        private double _caloriesStatic;
        private double _proteinStatic;
        private double _carbsStatic;
        private double _fatStatic;

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
        private bool checkIfNumeric(string s)
        {
            double output;
            return double.TryParse(s, out output);
        }
        private void textBoxGrams_TextChanged()
        {

        }

        private void textBoxGrams_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxGrams_TextChanged(object sender, EventArgs e)
        {

        }

        private void foodNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBoxGrams.Text != "" && checkIfNumeric(textBoxGrams.Text))
            {
                CaloriesDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _caloriesStatic, 0);
                ProteinDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _proteinStatic, 1);
                CarbsDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _carbsStatic, 1);
                FatDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _fatStatic, 1);
                GramsDynamic = Convert.ToInt32(textBoxGrams.Text);
                FoodGrams += Convert.ToInt32(textBoxGrams.Text);
                FoodCalories += CaloriesDynamic;
                FoodProtein += ProteinDynamic;
                FoodCarbs += CarbsDynamic;
                FoodFat += FatDynamic;
                caloriesLabel.Text = $"kCal:{FoodCalories:f0}";
                pLabel.Text = $"P:{FoodProtein:f1}g";
                cLabel.Text = $"C:{FoodCarbs:f1}g";
                fLabel.Text = $"F:{FoodFat:f1}g";
                gramsLabel.Text = $"{FoodGrams:f0}g";
                Add?.Invoke(this, EventArgs.Empty);
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (textBoxGrams.Text != "" && checkIfNumeric(textBoxGrams.Text) && FoodGrams - int.Parse(textBoxGrams.Text) > 0)
            {
                CaloriesDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _caloriesStatic, 0);
                ProteinDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _proteinStatic, 1);
                CarbsDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _carbsStatic, 1);
                FatDynamic = Math.Round((Convert.ToDouble(textBoxGrams.Text) / 100) * _fatStatic, 1);
                GramsDynamic = Convert.ToInt32(textBoxGrams.Text);
                FoodGrams -= Convert.ToInt32(textBoxGrams.Text);
                FoodCalories -= CaloriesDynamic;
                FoodProtein -= ProteinDynamic;
                FoodCarbs -= CarbsDynamic;
                FoodFat -= FatDynamic;
                caloriesLabel.Text = $"kCal:{FoodCalories:f0}";
                pLabel.Text = $"P:{FoodProtein:f1}g";
                cLabel.Text = $"C:{FoodCarbs:f1}g";
                fLabel.Text = $"F:{FoodFat:f1}g";
                gramsLabel.Text = $"{FoodGrams:f0}g";
                Remove?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FoodItem_Load(object sender, EventArgs e)
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
            set { _foodCalories = value; caloriesLabel.Text = $"kCal:{value}"; }
        }
        [Category("Custom Props")]
        public double FoodProtein
        {
            get { return _foodProtein; }
            set { _foodProtein = value; pLabel.Text = $"P:{Math.Round(value, 1):f1}g"; }
        }
        [Category("Custom Props")]
        public double FoodCarbs
        {
            get { return _foodCarbs; }
            set { _foodCarbs = value; cLabel.Text = $"C:{Math.Round(value, 1):f1}g"; }
        }
        [Category("Custom Props")]
        public double FoodFat
        {
            get { return _foodFat; }
            set { _foodFat = value; fLabel.Text = $"F:{Math.Round(value, 1):f1}g"; }
        }

        [Category("Custom Props")]
        public double FoodGrams
        {
            get { return _foodGrams; }
            set { _foodGrams = value; gramsLabel.Text = $"{FoodGrams}g"; }
        }
        [Category("Custom Props")]
        public string FoodImage
        {
            get { return _foodImage; }
            set { _foodImage = value; foodImage.ImageLocation = value; }
        }
        public double GramsDynamic
        {
            get { return _gramsDynamic; }
            set { _gramsDynamic = value; }
        }
        public double CaloriesDynamic
        {
            get { return _caloriesDynamic; }
            set { _caloriesDynamic = value; }
        }
        public double ProteinDynamic
        {
            get { return _proteinDynamic; }
            set { _proteinDynamic = value; }
        }
        public double CarbsDynamic
        {
            get { return _carbsDynamic; }
            set { _carbsDynamic = value; }
        }
        public double FatDynamic
        {
            get { return _fatDynamic; }
            set { _fatDynamic = value; }
        }
        public double CaloriesStatic
        {
            get { return _caloriesStatic; }
            set { _caloriesStatic = value; }
        }
        public double ProteinStatic
        {
            get { return _proteinStatic; }
            set { _proteinStatic = value; }
        }
        public double CarbsStatic
        {
            get { return _carbsStatic; }
            set { _carbsStatic = value; }
        }
        public double FatStatic
        {
            get { return _fatStatic; }
            set { _fatStatic = value; }
        }
        #endregion
    }
}
