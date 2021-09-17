using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtboxNum1.Text);
            int number2 = int.Parse(txtboxNum2.Text);
            int sum = Add(number1, number2);

            lblResult.Text = sum.ToString();
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtboxNum1.Text);
            int number2 = int.Parse(txtboxNum2.Text);
            int subtraction = Subtract(number1, number2);

            lblResult.Text = subtraction.ToString();
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }


        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txtboxNum1.Text);
            int number2 = int.Parse(txtboxNum2.Text);
            int multiplication = Multiply(number1, number2);

            lblResult.Text = multiplication.ToString();
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(txtboxNum1.Text);
            double number2 = double.Parse(txtboxNum2.Text);
            double division = Divide(number1, number2);

            lblResult.Text = division.ToString("0.00");
        }
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
