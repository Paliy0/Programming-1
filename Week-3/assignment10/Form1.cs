using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(ageTxtbox.Text);
            double price = 12;

            if (age >= 5 && age <= 12)
            {
                price = price / 2;
            }
            else if (age < 5 || age >= 55)
            {
                price = 0;
            }
        
            priceLbl.Text = ($"{price:0.00}€");

        }

    }
}
