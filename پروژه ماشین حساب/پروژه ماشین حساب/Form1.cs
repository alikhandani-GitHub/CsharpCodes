using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace پروژه_ماشین_حساب
{
    public partial class Form1 : Form
    {
        bool ispointAddad = false;
        double firstNumber;
        char MyOperator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
            firstNumber = Double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            MyOperator = '+';
            ispointAddad = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
            firstNumber = Double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            MyOperator = '-';
            ispointAddad = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (MyOperator)
            {
                case '+':
                    txtDisplay.Text = (firstNumber + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case '-':
                    txtDisplay.Text = (firstNumber - Double.Parse(txtDisplay.Text)).ToString();
                    break;
        }   }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ispointAddad)
            {
                txtDisplay.Text += '.';
                ispointAddad = true;
            }
                                              
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.ForeColor = Color.Green;
          //  txtDisplay.BackColor = Color.Green;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.ForeColor = Color.Red;
          //  txtDisplay.BackColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.ForeColor = Color.Blue;
           // txtDisplay.BackColor = Color.Blue;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.BackColor = Color.Pink;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.BackColor = Color.Purple;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.BackColor = Color.Brown;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Font myfont = new Font("font", 12.0f);
            txtDisplay.Font = myfont;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Font myfont = new Font("font",20.0f);
            txtDisplay.Font = myfont;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Font myfont = new Font("font", 16.0f);
            txtDisplay.Font = myfont;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
