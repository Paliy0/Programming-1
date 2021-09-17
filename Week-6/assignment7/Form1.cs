using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double degrees = double.Parse(txtboxDegrees.Text);
            double result = 0;
            
            if (radCtoK.Checked)
            {
                result = Celsius2Kelvin(degrees);
            }
            else if (radCtoF.Checked)
            {
                result = Celsius2Fahrenheit(degrees);
            }
           else if (radFtoC.Checked)
            {
                result = Fahrenheit2Celsius(degrees);
            }

            lblResult.Text = result.ToString("0.00");
        }

        static double Celsius2Kelvin(double degrees)
        {
            return degrees + 273;
        }

        static double Celsius2Fahrenheit(double degrees)
        {
            return (degrees * 9 / 5) + 32;
        }

        static double Fahrenheit2Celsius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
