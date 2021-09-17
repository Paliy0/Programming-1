using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startAmount = double.Parse(startTxtbox.Text);
            double interest = 0.05;

            for(int i = 1; i <= 5; i++)
            {
                startAmount = (startAmount * interest) + startAmount;
            }
            finalLbl.Text = startAmount.ToString("0.00€");
        }
    }
}
