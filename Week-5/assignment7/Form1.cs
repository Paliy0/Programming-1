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

        private void btnThrow_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int[] dice = new int[6];
            int value = 0;

            for (int i = 0; i < 5; i++)
            {
                dice[i] = 0;
            }
            for (int i = 0; i < 6001; i++)
            {
                value = rnd.Next(1,7);
                if (value == 1)
                {
                    dice[0] += 1;
                    lblVal1.Text = dice[0].ToString();
                }
                else if (value == 2)
                {
                    dice[1] += 1;
                    lblVal2.Text = dice[1].ToString();
                }
                else if(value == 3)
                {
                    dice[2] += 1;
                    lblVal3.Text = dice[2].ToString();
                }
                else if(value == 4)
                {
                    dice[3] += 1;
                    lblVal4.Text = dice[3].ToString();
                }
                else if(value == 5)
                {
                    dice[4] += 1;
                    lblVal5.Text = dice[4].ToString();
                }
                else if(value == 6)
                {
                    dice[5] += 1;
                    lblVal6.Text = dice[5].ToString();
                }         
                
            }
        }
    }
}
