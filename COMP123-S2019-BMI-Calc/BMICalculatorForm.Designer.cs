namespace COMP123_S2019_BMI_Calc
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMICalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeigthTextBox = new System.Windows.Forms.TextBox();
            this.WeigthTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ScaleTextBox = new System.Windows.Forms.TextBox();
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayoutPanel
            // 
            this.BMICalculatorTableLayoutPanel.ColumnCount = 5;
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.MetricRadioButton, 3, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeigthTextBox, 1, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeigthTextBox, 1, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ScaleTextBox, 0, 8);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResetButton, 0, 5);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.CalculateButton, 2, 5);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 6);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightUnitLabel, 3, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightUnitLabel, 3, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResultTextBox, 3, 6);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResultProgressBar, 3, 6);
            this.BMICalculatorTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.BMICalculatorTableLayoutPanel.Name = "BMICalculatorTableLayoutPanel";
            this.BMICalculatorTableLayoutPanel.RowCount = 5;
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMICalculatorTableLayoutPanel.Size = new System.Drawing.Size(280, 417);
            this.BMICalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ImperialRadioButton, 3);
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Location = new System.Drawing.Point(171, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightLabel.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.HeightLabel, 3);
            this.HeightLabel.Location = new System.Drawing.Point(3, 47);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 31);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "My Height";
            // 
            // HeigthTextBox
            // 
            this.HeigthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.HeigthTextBox, 2);
            this.HeigthTextBox.Location = new System.Drawing.Point(59, 81);
            this.HeigthTextBox.Name = "HeigthTextBox";
            this.HeigthTextBox.Size = new System.Drawing.Size(106, 38);
            this.HeigthTextBox.TabIndex = 3;
            this.HeigthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeigthTextBox
            // 
            this.WeigthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.WeigthTextBox, 2);
            this.WeigthTextBox.Location = new System.Drawing.Point(59, 155);
            this.WeigthTextBox.Name = "WeigthTextBox";
            this.WeigthTextBox.Size = new System.Drawing.Size(106, 38);
            this.WeigthTextBox.TabIndex = 3;
            this.WeigthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightLabel.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.WeightLabel, 3);
            this.WeightLabel.Location = new System.Drawing.Point(3, 121);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 31);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight";
            // 
            // ScaleTextBox
            // 
            this.ScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ScaleTextBox, 5);
            this.ScaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleTextBox.Location = new System.Drawing.Point(3, 308);
            this.ScaleTextBox.Multiline = true;
            this.ScaleTextBox.Name = "ScaleTextBox";
            this.BMICalculatorTableLayoutPanel.SetRowSpan(this.ScaleTextBox, 2);
            this.ScaleTextBox.Size = new System.Drawing.Size(274, 106);
            this.ScaleTextBox.TabIndex = 7;
            this.ScaleTextBox.Text = "BMI SCALE    RESULT\r\nUnderweight   Less than 18.5\r\nNormal             Between 18." +
    "5 and 24.9\r\nOverweight      Between 25 and 29.9\r\nObese              30 or greate" +
    "r";
            this.ScaleTextBox.UseWaitCursor = true;
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ResultProgressBar, 5);
            this.ResultProgressBar.Location = new System.Drawing.Point(3, 279);
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(274, 23);
            this.ResultProgressBar.TabIndex = 8;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.Goldenrod;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(3, 192);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 44);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.CalculateButton, 3);
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(115, 192);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(162, 44);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResultLabel.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ResultLabel, 3);
            this.ResultLabel.Location = new System.Drawing.Point(4, 242);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(161, 31);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Your BMI is:";
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightUnitLabel.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.HeightUnitLabel, 2);
            this.HeightUnitLabel.Location = new System.Drawing.Point(171, 81);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(95, 31);
            this.HeightUnitLabel.TabIndex = 5;
            this.HeightUnitLabel.Text = "Inches";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightUnitLabel.AutoSize = true;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.WeightUnitLabel, 2);
            this.WeightUnitLabel.Location = new System.Drawing.Point(171, 155);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(106, 31);
            this.WeightUnitLabel.TabIndex = 5;
            this.WeightUnitLabel.Text = "Pounds";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ResultTextBox, 2);
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(171, 242);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(106, 38);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMICalculatorTableLayoutPanel.ResumeLayout(false);
            this.BMICalculatorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeigthTextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.TextBox WeigthTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox ScaleTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateButton;
    }
}

