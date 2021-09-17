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

        private void btnSqRef_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtboxNum.Text);

            SquareByReference(ref number);

            lblResult.Text = number.ToString();
        }

        void SquareByReference(ref int number)
        {
            number = number * number;
        }


        private void btnSqRefOut_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtboxNum.Text);
            int square;

            SquareByReferenceOut(number, out square);

            lblResult.Text = square.ToString();
        }

        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        private void btnSqVal_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtboxNum.Text);
            int square = SquareByValue(number);

            lblResult.Text = square.ToString();
        }
        int SquareByValue(int number)
        {
            return number * number;
        }

    }
}
