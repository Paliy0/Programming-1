using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double startKm = double.Parse(startTxtbox.Text);
            double endKM = double.Parse(endTxtbox.Text);
            double priceKm = double.Parse(priceTxtbox.Text);

            double totalKm = endKM - startKm;
            double price = totalKm * priceKm;
            double vat = price * 0.21;
            double totalPrice = vat + price;

            priceLbl.Text = ($"{price:0.00}€");
            vatLbl.Text = ($"{vat:0.00}€");
            totalLbl.Text = ($"{totalPrice:0.00}€");


        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            startTxtbox.Text = "";
            endTxtbox.Text = "";
            priceTxtbox.Text = "";
            priceLbl.Text = "--.--";
            vatLbl.Text = "--.--";
            totalLbl.Text = "--.--";
        }
    }
}
