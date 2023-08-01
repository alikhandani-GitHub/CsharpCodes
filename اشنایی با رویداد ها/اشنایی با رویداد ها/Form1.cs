using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace اشنایی_با_رویداد_ها
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = "iran";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Blue)
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = Color.Blue;
        }
        public void Clear(object sender, EventArgs e)
        {
            this.Text = " ";
        }
        public void Rainbow(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Purple)
                this.BackColor = Color.Red;
            else if (this.BackColor == Color.Red)
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.Purple;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
                textBox1.Visible = false;
            else
                textBox1.Visible = true;
        }
    }
}
