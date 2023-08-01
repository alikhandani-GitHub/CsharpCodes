using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace روز_ماه_سال
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label1.Text = "روز تولد را وارد کنید";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label1.Text = "ماه تولد را وارد کنید";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "سال تولد را وارد کنید";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0)
            {
                int day = Int32.Parse(textBox3.Text);
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("روز وارد شده معتبر نیست!");
                    textBox3.Focus();
                    textBox3.Clear();
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
                return;
            int month = Int32.Parse(textBox2.Text);
            if (month < 1 || month > 12)
            {
                MessageBox.Show("ماه وارد شده معتبر نیست!");
                textBox2.Focus();
                textBox2.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
                return;
            int year = Int32.Parse(textBox1.Text);
            if (year < 1290 || year > 1399)
            {
                MessageBox.Show("سال وارد شده معتبر نیست!");
                textBox1.Focus();
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int sen = Int32.Parse(textBox1.Text.ToString());
            int x = 1399 - sen;
            this.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sen = Int32.Parse(textBox1.Text);
            int mah = Int32.Parse(textBox2.Text);
            int roz = Int32.Parse(textBox3.Text);
            int x = 1399 - sen;
            int y = 2 - mah;
            int z = 6 - roz;
            MessageBox.Show("سال",x.ToString());
            MessageBox.Show("ماه",y.ToString());
            MessageBox.Show("روز",z.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
