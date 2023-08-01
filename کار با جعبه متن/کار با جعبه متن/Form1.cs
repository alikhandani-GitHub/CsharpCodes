using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace کار_با_جعبه_متن
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "سلام " + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int factor = 1;
            for (int i = 1; i <= a; i++)
                factor *= i;
            textBox2.Text = factor.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '@')
                textBox1.PasswordChar = '\0';
            else
                textBox1.PasswordChar = '@';
                            
        }
    }
}
