using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            string input = priceTxtbox.Text;

            double price = double.Parse(input);
            double vat = price * 0.21;
            double total = price + vat;

            priceLbl.Text = price.ToString("0.00");
            vatLbl.Text = vat.ToString("0.00");
            totalLbl.Text = total.ToString("0.00");
        }
    }
}
