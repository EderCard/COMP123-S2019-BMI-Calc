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
        private double _Height { get; set; }
        private double _Weight { get; set; }
        private double _BMI { get; set; }
        private double _bmiLevel { get; set; }
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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This method clear fields and set Imperial unit
        /// </summary>
        private void ClearForm()
        {
            ImperialRadioButton.Checked = true;
            MetricRadioButton.Checked = false;
            HeightUnitLabel.Text = "Inches";
            WeightUnitLabel.Text = "Pounds";
            HeightTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            ScaleTextBox.Text = string.Empty;
            ScaleTextBox.BackColor = Color.LightGray;
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
                _BMI = CalculateBMI(_Height, _Weight);
                ResultTimer.Start();
                ResultTextBox.Text = _BMI.ToString("F1");
                ResultProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                if (_BMI <= 18.5)
                {
                    _bmiLevel = 1;
                    ResultProgressBar.ForeColor = Color.Gold;
                    ScaleTextBox.Text = "Underweight";
                    ScaleTextBox.BackColor= Color.Gold;
                    ScaleTextBox.ForeColor = Color.White;
                    ScaleTextBox.Font= new Font(this.Font, FontStyle.Bold);
                }
                else if (_BMI <= 24.9)
                {
                    _bmiLevel = 2;
                    ResultProgressBar.ForeColor = Color.LimeGreen;
                    ScaleTextBox.Text = "Normal";
                    ScaleTextBox.BackColor = Color.LimeGreen;
                    ScaleTextBox.ForeColor = Color.White;
                    ScaleTextBox.Font = new Font(this.Font, FontStyle.Bold);
                }
                else if (_BMI <= 29.9)
                {
                    _bmiLevel = 3;
                    ResultProgressBar.ForeColor = Color.DarkOrange;
                    ScaleTextBox.Text = "Overweight";
                    ScaleTextBox.BackColor = Color.DarkOrange;
                    ScaleTextBox.ForeColor = Color.White;
                    ScaleTextBox.Font = new Font(this.Font, FontStyle.Bold);
                }
                else if (_BMI >= 30)
                {
                    _bmiLevel = 4;
                    ResultProgressBar.ForeColor = Color.DarkRed;
                    ScaleTextBox.Text = "Obese";
                    ScaleTextBox.BackColor = Color.DarkRed;
                    ScaleTextBox.ForeColor = Color.White;
                    ScaleTextBox.Font = new Font(this.Font, FontStyle.Bold);
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
            Height = double.Parse(HeightTextBox.Text);
            Weight = double.Parse(WeightTextBox.Text);

            if (ImperialRadioButton.Checked)
            {
                _BMI = Math.Round(Weight * 703 / Math.Pow(Height, 2), 1);
            }
            else if (MetricRadioButton.Checked)
            {
                _BMI = Math.Round(Weight / Math.Pow(Height / 100, 2), 1);
            }
            return _BMI;
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
            switch (_bmiLevel)
            {
                case 1:
                    if (ResultProgressBar.Value == 25)
                    {
                        ResultTimer.Stop();
                    }
                    break;
                case 2:
                    if (ResultProgressBar.Value == 50)
                    {
                        ResultTimer.Stop();
                    }
                    break;
                case 3:
                    if (ResultProgressBar.Value == 75)
                    {
                        ResultTimer.Stop();
                    }
                    break;
                case 4:
                    if (ResultProgressBar.Value == 100)
                    {
                        ResultTimer.Stop();
                    }
                    break;
            }
        }
        /// <summary>
        /// This is the event handler for the load form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This is the event handler for the Height KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }
        /// <summary>
        /// This is the event handler for the Weight KeyPress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }
        /// <summary>
        /// This method validate field content for only numeric values
        /// </summary>
        /// <param name="e"></param>
        private static void ValidateNumericDigit(KeyPressEventArgs e)
        {
            //allow "number", "." and "backscape"
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// This is the event handler for the closing form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
