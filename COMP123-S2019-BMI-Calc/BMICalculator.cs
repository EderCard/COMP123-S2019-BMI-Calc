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
        int bmiLevel;
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
            ResultProgressBar.Value = 0;
            ResultTimer.Stop();
        }
        /// <summary>
        /// This is the Event Handler for the CalculateButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                BMI = CalculateBMI(Height, Weight);
                ResultTimer.Start();
                ResultTextBox.Text = BMI.ToString();
                ResultProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                if (BMI <= 18.5)
                {
                    ResultProgressBar.ForeColor = Color.Gold;
                    bmiLevel = 1;
                }
                else if (BMI <= 24.9)
                {
                    ResultProgressBar.ForeColor = Color.LimeGreen;
                    bmiLevel = 2;
                }
                else if (BMI <= 29.9)
                {
                    ResultProgressBar.ForeColor = Color.DarkOrange;
                    bmiLevel = 3;
                }
                else if (BMI >= 30)
                {
                    ResultProgressBar.ForeColor = Color.DarkRed;
                    bmiLevel = 4;
                }
                ResultProgressBar.Value = 0;
            }
            catch
            {
                MessageBox.Show("You must provide Height and Weight to \ncalculate your BMI - Body Mass Index");
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
        /// <summary>
        /// This is the TimerTick event that stops the ProgressBar in each BMI level
        /// There are four levels os BMI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultTimer_Tick(object sender, EventArgs e)
        {
            ResultProgressBar.Increment(1);

            if (bmiLevel == 1)
            {
                if (ResultProgressBar.Value == 25)
                {
                    ResultTimer.Stop();
                }
            }
            if (bmiLevel == 2)
            {
                if (ResultProgressBar.Value == 50)
                {
                    ResultTimer.Stop();
                }
            }
            if (bmiLevel == 3)
            {
                if (ResultProgressBar.Value == 75)
                {
                    ResultTimer.Stop();
                }
            }
            if (bmiLevel == 4)
            {
                if (ResultProgressBar.Value == 100)
                {
                    ResultTimer.Stop();
                }
            }
        }
    }
}
