using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_BMI_Calc
{
    static class Program
    {
        public static BMICalculator calculatorForm;
        public static SplashScreen splashForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            calculatorForm = new BMICalculator();
            splashForm = new SplashScreen();
            Application.Run(splashForm);
        }
    }
}
