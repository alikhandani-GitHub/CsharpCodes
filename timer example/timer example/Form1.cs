using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
          //  this.Text += "*";
          //  this.Left += 10;
            // this.Top += 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "حرکت")
            {
                this.button1.Text = "توقف";
                this.timer1.Enabled = false;
            }
            else if (button1.Text == "توقف")
            {
                this.button1.Text = "حرکت";
                this.timer1.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
