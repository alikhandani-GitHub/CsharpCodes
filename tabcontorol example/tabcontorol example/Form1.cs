using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontorol_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //radioButton1.Checked= true;
            this.Text = DateTime.Now.ToString();
            this.Text += textBox1.Text;
        }
        private void txt_textchang(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.One;
            switch(listBox1.SelectedIndex)
            {
                case 0:
                   this.tabPage2.BackColor = Color.Green;
                    break;
                case 1:
                    this.tabPage2.BackColor = Color.Blue;
                    break;
               case 2:
                   this.tabPage2.BackColor = Color.Red;
                    break;
                case 3:
                    this.tabPage2.BackColor = Color.Orange;
                    break;
                case 4:
                    this.tabPage2.BackColor = Color.Purple;
                    break;
                case 5:
                    this.tabPage2.BackColor = Color.Indigo;
                    break;
                case 6:
                    this.tabPage2.BackColor = Color.Yellow;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width -= 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Height += 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Height -= 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {           
             button1.Enabled = true;
            textBox1.Enabled = false;
        }
    }
}
