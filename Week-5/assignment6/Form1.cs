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

        int[] numbers = new int[20];
        int[] comparison = new int[20];

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(501);
                lblTable.Text += $"Element {i:00} = {numbers[i]} \n";
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int compNum = int.Parse(txtboxCompare.Text);

            for (int i = 0; i < comparison.Length; i++)
            {
                if (compNum > numbers[i])
                {
                    comparison[i] = numbers[i] + 10;
                    lblCompare.Text += $"Element {i:00} = {comparison[i]} \n";
                }
                else if (compNum < numbers[i])
                {
                    comparison[i] = numbers[i] - 5;
                    lblCompare.Text += $"Element {i:00} = {comparison[i]} \n";
                }
            }
            btnCompare.Enabled = false;
        }
    }
}
