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

        private void button1_Click(object sender, EventArgs e)
        {
            int sides = int.Parse(sideTxtbox.Text);

            for (int i = 1; i <= sides; i++)
            {
                if (i == sides || i == 1)
                {
                    for (int n = 1; n <= sides; n++)
                    {
                        squareLbl.Text += "X";
                    }
                    squareLbl.Text += "\n";
                }
                else if (i > 1 || i < sides)
                {
                    squareLbl.Text += "X";
                    for (int n = 1; n <= sides - 2; n++)
                    {
                        squareLbl.Text += " ";
                    }
                    squareLbl.Text += "X\n";
                }
            }
        }
    }
}
