using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "iran";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Ali";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Text == "iran")
                this.Text = "Ali";
            else
                this.Text = "iran";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Yellow)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Width += 10;
             
        }
    }
}
