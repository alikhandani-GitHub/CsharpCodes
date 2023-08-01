using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace رنگین_کمان
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomClass = new Random();
            int rndred = randomClass.Next(0, 255);
            int rndGreen = randomClass.Next(0, 255);
            int rndBlue = randomClass.Next(0, 255);
            this.BackColor = Color.FromArgb(rndred, rndGreen, rndBlue);
        }
    }
}
