using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboxText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox1.ForeColor = Color.Blue;
                    break;
                case 1:
                    textBox1.ForeColor = Color.Green;
                    break;
                case 2:
                    textBox1.ForeColor = Color.Red;
                    break;
                case 3:
                    textBox1.ForeColor = Color.Orange;
                    break;
                case 4:
                    textBox1.ForeColor = Color.Yellow;
                    break;
            }
         }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            {
                case 0:
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                    break;
                case 1:
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    break;
                case 2:
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Strikeout);
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    Font myfont = new Font("font", 16.0f);
                    textBox1.Font = myfont;
                    break;
                case 1:
                    Font MYfont = new Font("font", 20.0f);
                    textBox1.Font = MYfont;
                    break;
                case 2:
                    Font MyFont = new Font("font", 25.0f);
                    textBox1.Font = MyFont;
                    break;

            }
            /*{  برای سایز textbox
                case 0:
                    textBox1.Multiline = true;
                    textBox1.Height = 50;
                    textBox1.Width = 50;
                    break;
                case 1:
                    textBox1.Multiline = true;
                    textBox1.Height = 60;
                    textBox1.Width = 80;
                    break;
                case 2:
                    textBox1.Multiline = true;
                    textBox1.Height = 95;
                    textBox1.Width = 100;
                    break;*/
                    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
