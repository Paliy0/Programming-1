using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double tshirtNum = double.Parse(shirtTxtbox.Text);
            double jeansNum = double.Parse(jeansTxtbox.Text);

            double tshirtPrice = 30.00;
            double jeanPrice = 100.00;

            double jeanTotal = jeanPrice * jeansNum;
            double shirtTotal = tshirtNum * tshirtPrice;
            double total = jeanTotal + shirtTotal;
            double vat = total * 0.21;
            double totalPrice = total + vat;

            priceLbl.Text = ($"{total:0.00}€");
            vatLbl.Text = ($"{vat:0.00}€");
            totalLbl.Text = ($"{totalPrice:0.00}€");

            DateTime now = DateTime.Now;
            dateLbl.Text = now.ToString("");

        }
    }
}
