using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double sec = double.Parse(secTxtbox.Text);
            double hours = sec / 3600;
            sec = sec % 3600;

            double min = sec / 60;
            sec = sec % 60;

            timeLbl.Text = ($"{hours:00}:{min:00}:{sec:00}");
        }
    }
}
