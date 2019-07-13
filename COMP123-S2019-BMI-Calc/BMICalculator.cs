using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Ederson Cardoso
 *   ID: 301033332
 *   
 * This program calculate BMI based on a simplified formula the uses only Height and Weight.
 * It can be calculated using imperial or metric units.
 */
namespace COMP123_S2019_BMI_Calc
{
    public partial class BMICalculator : Form
    {
        double Height;
        double Weight;
        double BMI;
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event Handler for the ImperialRadioButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "Inches";
            WeightUnitLabel.Text = "Pounds";
            ResultTextBox.Text = string.Empty;
        }
        /// <summary>
        /// This is the Event Handler for the MetricRadioButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "cm";
            WeightUnitLabel.Text = "kg";
            ResultTextBox.Text = string.Empty;
        }
        /// <summary>
        /// This is the Event Handler for the ResetButton click event
        /// Clear fields and set Imperial unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ImperialRadioButton.Checked = true;
            MetricRadioButton.Checked = false;
            HeightUnitLabel.Text = "Inches";
            WeightUnitLabel.Text = "Pounds";
            HeigthTextBox.Text = string.Empty;
            WeigthTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
        }
        /// <summary>
        /// This is the Event Handler for the CalculateButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            BMI = CalculateBMI(Height, Weight);
            ResultTextBox.Text = BMI.ToString();
            if (BMI <= 18.5)
            {
                ResultTextBox.BackColor = Color.Gold;
            }
            else if (BMI <= 24.9)
            {
                ResultTextBox.BackColor = Color.LightGreen;
            }
            else if (BMI <= 29.9)
            {
                ResultTextBox.BackColor = Color.Orange;
            }
            else if (BMI >= 30)
            {
                ResultTextBox.BackColor = Color.Tomato;
            }
        }
        /// <summary>
        /// This is the method to calculate BMI
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Weight"></param>
        private double CalculateBMI(double Height, double Weight)
        {
            Height = double.Parse(HeigthTextBox.Text);
            Weight = double.Parse(WeigthTextBox.Text);

            if (ImperialRadioButton.Checked)
            {
                BMI = Math.Round(Weight * 703 / Math.Pow(Height, 2), 1);
            }
            else if (MetricRadioButton.Checked)
            {
                BMI = Math.Round(Weight / Math.Pow(Height / 100, 2), 1);
            }
            return BMI;
        }
    }
}
