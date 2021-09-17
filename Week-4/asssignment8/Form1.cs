using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asssignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(numTxtbox.Text);

            double sum1 = 0;
            
            for (int i = 0; i <= num; i++)
            {
                sum1 += i;
            }

            double sum2 = num * (num + 1) / 2;

            sum1Lbl.Text = sum1.ToString();
            sum2Lbl.Text = sum2.ToString();

            if (sum1 == sum2)
            {
                resultLbl.Text = "The sum and formula are equal.";
            }
            else
            {
                resultLbl.Text = "The sum and formula are not equal.";
            }
        }
    }
}
