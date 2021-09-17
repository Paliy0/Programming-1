using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment9
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
            int member = int.Parse(memberTxtbox.Text);
            double price = 0;

            if (footballRad.Checked)
            {
                price += 175;
            }
            else if (handballRad.Checked)
            {
                price += 225;
            }

            if (age > 40)
            {
                price -= 25;
            }

            if (member > 10)
            {
                price -= 20;
            }
            feeLbl.Text = price.ToString("0.00€");
        }
    }
}
