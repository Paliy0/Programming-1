using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void avrgBtn_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(num1Txtbox.Text);
            double num2 = double.Parse(num2Txtbox.Text);
            double num3 = double.Parse(num3Txtbox.Text);

            double avrg = (num1 + num2 + num3) / 3;

            avrgLbl.Text = avrg.ToString("0.000");
        }
    }
}
